using System.Drawing;

namespace MandelbrotSet.MainForm
{
    public interface IForm
    {
        Bitmap MandelbrotSet { set; }
        long CalculationTime { set; }
    }
}
