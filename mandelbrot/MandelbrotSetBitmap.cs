using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MandelbrotSet
{
    public static class MandelbrotSetBitmap
    {
        public const int MAX_ITERATIONS = 1000;

        private static int CORE_COUNT = Environment.ProcessorCount;
    
        private static int COLORS_PER_PIXEL = 4;

        public static Bitmap Render(Size bitmapSize, ImageInfo imageInfo, bool reportProgress, int maxThreadsCount = 30)
        {
            var bitmap = new Bitmap(bitmapSize.Width, bitmapSize.Height, PixelFormat.Format32bppRgb);

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            var bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);

            var pointer = bitmapData.Scan0;

            int size = Math.Abs(bitmapData.Stride) * bitmap.Height;

            byte[] pixels = new byte[size];

            Marshal.Copy(pointer, pixels, 0, size);

            var actions = CreateActions(pixels, bitmapSize, imageInfo, reportProgress);

            Parallel.Invoke(new ParallelOptions{MaxDegreeOfParallelism = maxThreadsCount}, actions);

            Marshal.Copy(pixels, 0, pointer, size);

            bitmap.UnlockBits(bitmapData);

            return bitmap;
        }

        public static Bitmap Render(Size bitmapSize, ImageInfo imageInfo, int maxThreadsCount)
        {
            return Render(bitmapSize, imageInfo, reportProgress: false, maxThreadsCount);
        }

        private static Action[] CreateActions(
            byte[] pixels,
            Size bitmapSize,
            ImageInfo imageInfo,
            bool reportProgress)
        {
            var actions = new List<Action>();

            int totalRows = bitmapSize.Height;
            int chunkSize = totalRows / CORE_COUNT;

            for (int i = 0; i < CORE_COUNT; i++)
            {
                int startRow;

                if (i == 0)
                {
                    startRow = 0;
                }
                else
                {
                    startRow = (chunkSize * i);
                }

                int endRow = chunkSize * (i + 1);

                actions.Add(() => CalculatePixels(
                    pixels,
                    bitmapSize,
                    imageInfo,
                    startRow,
                    endRow,
                    totalRows,
                    reportProgress));
            }

            if (chunkSize * CORE_COUNT < bitmapSize.Height)
            {
                int startRow = (chunkSize * CORE_COUNT);
                int endRow = bitmapSize.Height;

                actions.Add(() => CalculatePixels(
                    pixels,
                    bitmapSize,
                    imageInfo,
                    startRow,
                    endRow,
                    totalRows,
                    reportProgress));
            }

            return actions.ToArray();
        }

        private static void CalculatePixels(
            byte[] pixels,
            Size bitmapSize,
            ImageInfo imageInfo,
            int startRow,
            int endRow,
            int totalRows,
            bool reportProgress)
        {
            double axisWidth = imageInfo.AxisWidth;
            double planeHeight = imageInfo.AxisHeight;

            var focusPoint = imageInfo.FocusPoint;

            int bitmapWidth = bitmapSize.Width;
            int bitmapHeight = bitmapSize.Height;
            var colors = ColorHelper.RainbowGradient(10);
            for (int row = startRow; row < endRow; row++)
            {
                for (int column = 0; column < bitmapSize.Width; column++)
                {
                    double c_real = ((column - bitmapWidth / 2) * axisWidth / bitmapWidth)
                        + focusPoint.X;

                    double c_im = (-(row - bitmapHeight / 2) * planeHeight / bitmapWidth)
                        + focusPoint.Y;

                    double z_real = 0;
                    double z_im = 0;

                    int iteration = 0;

                    while (z_real * z_real + z_im * z_im < 4 && iteration < MAX_ITERATIONS)
                    {
                        double z_real_tmp = z_real * z_real - (z_im * z_im) + c_real;

                        z_im = 2 * z_real * z_im + c_im;
                        z_real = z_real_tmp;

                        iteration++;
                    }

                    Color color;

                    if (iteration < MAX_ITERATIONS)
                    {
                        color = colors[iteration % colors.Count];
                    }
                    else
                    {
                        color = Color.Black;
                    }

                    int i = ((row * bitmapWidth) + column) * COLORS_PER_PIXEL;

                    pixels[i] = color.B;
                    pixels[i + 1] = color.G;
                    pixels[i + 2] = color.R;
                }
            }
        }

        private static int CalculatePercent(int totalRows, int currentRow)
        {
            int percent = (int)Math.Round(((float)currentRow / totalRows) * 100);

            return percent;
        }
    }
}
