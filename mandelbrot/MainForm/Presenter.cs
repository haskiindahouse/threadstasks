using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MandelbrotSet.MainForm
{
    public class Presenter : IPresenter
    {
        private AxisLengths CurrentAxisLengths => ImageInfoHistory.Last().AxisLengths;

        private PointD CurrentFocusPoint => ImageInfoHistory.Last().FocusPoint;

        private List<ImageInfo> ImageInfoHistory { get; }

        public Size CurrentBitmapSize { set; get; }

        private readonly IForm Form;

        public Presenter(IForm form)
        {
            ImageInfoHistory = new List<ImageInfo>();
            Form = form;

            ImageInfoHistory.Add(new ImageInfo(
                ImageInfo.DEFAULT_AXIS_LENGTHS,
                ImageInfo.DEFAULT_FOCUS_POINT));
        }

        public void DrawInitialImage(Size bitmapSize, int maxThreadsCount = 30)
        {
            var imageInfo = new ImageInfo(ImageInfo.DEFAULT_AXIS_LENGTHS,
                                ImageInfo.DEFAULT_FOCUS_POINT);

            DrawImageAsync(bitmapSize, imageInfo, maxThreadsCount);
        }


        public void ZoomToSelectedArea(Size bitmapSize, Size rectangleSize, Point cursorLocation, int maxThreadsCount)
        {
            var newAxisLengths = CalculateAxisLengths(bitmapSize, rectangleSize);
            var newFocusPoint = ConvertBitmapPointToGraphPoint(cursorLocation, bitmapSize);

            var imageInfo = new ImageInfo(newAxisLengths, newFocusPoint);

            SaveImageToHistory(imageInfo);

            DrawImageAsync(bitmapSize, imageInfo, maxThreadsCount);
        }

        public void ShowPreviousPlane(Size bitmapSize, int maxThreadsCount)
        {
            if (ImageInfoHistory.Count == 1)
            {
                DrawInitialImage(bitmapSize);
            }
            else
            {
                ImageInfoHistory.Remove(ImageInfoHistory.Last());

                var imageInfo = ImageInfoHistory.Last();
                DrawImageAsync(bitmapSize, imageInfo, maxThreadsCount);
            }
        }

        public void SaveImageToHistory(ImageInfo imageInfo)
        {
            ImageInfoHistory.Add(imageInfo);
        }

        public async void DrawImageAsync(Size bitmapSize, ImageInfo imageInfo, int maxThreadsCount = 30)
        {
            CurrentBitmapSize = bitmapSize;

            long before = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            await Task.Run(() =>
            {
                var bitmap = MandelbrotSetBitmap.Render(bitmapSize, imageInfo, maxThreadsCount);

                if (bitmap != null)
                {
                    Form.MandelbrotSet = bitmap;
                }
            });

            long after = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Form.CalculationTime = after - before;
        }

        private PointD ConvertBitmapPointToGraphPoint(Point bitmapPoint, Size bitmapSize)
        {
            int pointX = bitmapPoint.X;
            int pointY = bitmapPoint.Y;

            return new PointD(
                x: ((pointX - bitmapSize.Width / 2) * CurrentAxisLengths.X / bitmapSize.Width)
                + CurrentFocusPoint.X,

                y: (-(pointY - bitmapSize.Height / 2) * CurrentAxisLengths.Y / bitmapSize.Width)
                + CurrentFocusPoint.Y
            );
        }

        private AxisLengths CalculateAxisLengths(Size bitmapSize, Size rectangleSize)
        {
            return new AxisLengths(
                xLength: CurrentAxisLengths.X / ((double)bitmapSize.Width / rectangleSize.Width),
                yLength: CurrentAxisLengths.Y / ((double)bitmapSize.Height / rectangleSize.Height)
            );
        }
    }
}
