using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotSet.MainForm
{
    public partial class MainForm : Form, IForm
    {
        private const int RECT_SIZE_STEP_PX = 10;
        public Bitmap MandelbrotSet { set => pictureBox.Image = value; }
        public long CalculationTime { set => labelTime.Text = $"{value} ms"; }
        private double AspectRatio => (double)pictureBox.Width / pictureBox.Height;
        private Rectangle selectionRectangle;
        private Point cursorLocation;

        private readonly IPresenter presenter;

        public MainForm()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            selectionRectangle = new Rectangle(
                location: new Point(0, 0),
                size: new Size(pictureBox.Width / 10, pictureBox.Height / 10));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter.DrawInitialImage(pictureBox.Size, (int)threadTaskSpinBox.Value);
        }


        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            cursorLocation = e.Location;
            MoveRectangleToCursor();
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ChangeRectangleSize(RECT_SIZE_STEP_PX);
            }
            else
            {
                ChangeRectangleSize(-RECT_SIZE_STEP_PX);
            }

            MoveRectangleToCursor();
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    presenter.ZoomToSelectedArea(
                        pictureBox.Size,
                        selectionRectangle.Size,
                        cursorLocation, (int)threadTaskSpinBox.Value);
                    break;

                case MouseButtons.Right:
                    presenter.ShowPreviousPlane(pictureBox.Size, (int)threadTaskSpinBox.Value);
                    break;
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            //draw the rectangle onto the pictureBox
            e.Graphics.DrawRectangle(new Pen(Color.White), selectionRectangle);
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void ChangeRectangleSize(int sizeIncrease)
        {
            selectionRectangle.Width += sizeIncrease;
            selectionRectangle.Height = (int)Math.Round(selectionRectangle.Width / AspectRatio);
        }

 
        private void MoveRectangleToCursor()
        {
            int newX = cursorLocation.X - selectionRectangle.Width / 2;
            int newY = cursorLocation.Y - selectionRectangle.Height / 2;

            selectionRectangle.Location = new Point(newX, newY);

            pictureBox.Refresh();
        }

        private double CalculateMagnification(AxisLengths axisLengths)
        {
            return Math.Round(ImageInfo.DEFAULT_AXIS_LENGTHS.X / axisLengths.X, 5);
        }

        private void threadTaskSpinBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
