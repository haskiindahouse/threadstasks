using System.Drawing;

namespace MandelbrotSet.MainForm
{
    public interface IPresenter
    {
        void DrawImageAsync(Size bitmapSize, ImageInfo imageInfo, int maxThreadsCount);
        void DrawInitialImage(Size bitmapSize, int maxThreadsCount = 30);
        void ZoomToSelectedArea(Size bitmapSize, Size rectangleSize, Point cursorLocation, int maxThreadsCount);
        void ShowPreviousPlane(Size bitmapSize, int maxThreadsCount);
        void SaveImageToHistory(ImageInfo imageInfo);

        Size CurrentBitmapSize { set;  get; }
    }
}
