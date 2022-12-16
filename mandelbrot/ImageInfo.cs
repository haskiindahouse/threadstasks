namespace MandelbrotSet
{
    public class ImageInfo
    {
        private const double DEFAULT_AXIS_LENGTH = 4;

        public static AxisLengths DEFAULT_AXIS_LENGTHS
            = new AxisLengths(DEFAULT_AXIS_LENGTH, DEFAULT_AXIS_LENGTH);

        public static PointD DEFAULT_FOCUS_POINT = new PointD(0, 0);

        public AxisLengths AxisLengths { get; set; }
        public PointD FocusPoint { get; set; }
        public double AxisWidth => AxisLengths.X;
        public double AxisHeight => AxisLengths.Y;

        public ImageInfo(AxisLengths axisLengths, PointD focusPoint)
        {
            AxisLengths = axisLengths;
            FocusPoint = focusPoint;
        }       
    }
}
