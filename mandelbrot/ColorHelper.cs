using System;
using System.Collections.Generic;
using System.Drawing;

namespace MandelbrotSet
{
    public static class ColorHelper
    {
        public static Color[] BLUE_BROWN = new List<Color>
            {
                Color.FromArgb(66, 30, 15),
                Color.FromArgb(25, 7, 26),
                Color.FromArgb(9, 1, 47),
                Color.FromArgb(4, 4, 73),
                Color.FromArgb(0, 7, 100),
                Color.FromArgb(12, 44, 138),
                Color.FromArgb(24, 82, 177),
                Color.FromArgb(57, 125, 209),
                Color.FromArgb(134, 181, 229),
                Color.FromArgb(211, 236, 248),
                Color.FromArgb(241,233,191),
                Color.FromArgb(248, 201, 95),
                Color.FromArgb(255, 170, 0),
                Color.FromArgb(204, 128, 0),
                Color.FromArgb(153, 87, 0),
                Color.FromArgb(106, 52, 3)
            }.ToArray();

        public static Color[] CreateGradient(Color startColor, Color endColor, int steps)
        {
            var colorArray = new Color[steps];

            int stepR = ((endColor.R - startColor.R) / (steps - 1));
            int stepG = ((endColor.G - startColor.G) / (steps - 1));
            int stepB = ((endColor.B - startColor.B) / (steps - 1));

            for (int i = 0; i < steps; i++)
            {
                colorArray[i] = Color.FromArgb(startColor.R + (stepR * i),
                                            startColor.G + (stepG * i),
                                            startColor.B + (stepB * i));
            }

            return colorArray;
        }

        public static List<Color> RainbowGradient(int count = 100)
        {
            List<Color> colors = new List<Color>();
            for (double i = 0; i < 1; i += 0.1)
            {
                Color color = HSL2RGB(i, 0.5, 0.5);
                var test = i;
                colors.Add(color);
            }

            return colors;
        }

        public static Color HSL2RGB(double h, double sl, double l)

        {

            double v;

            double r, g, b;



            r = l;   // default to gray

            g = l;

            b = l;

            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)

            {

                double m;

                double sv;

                int sextant;

                double fract, vsf, mid1, mid2;



                m = l + l - v;

                sv = (v - m) / v;

                h *= 6.0;

                sextant = (int)h;

                fract = h - sextant;

                vsf = v * sv * fract;

                mid1 = m + vsf;

                mid2 = v - vsf;

                switch (sextant)

                {

                    case 0:

                        r = v;

                        g = mid1;

                        b = m;

                        break;

                    case 1:

                        r = mid2;

                        g = v;

                        b = m;

                        break;

                    case 2:

                        r = m;

                        g = v;

                        b = mid1;

                        break;

                    case 3:

                        r = m;

                        g = mid2;

                        b = v;

                        break;

                    case 4:

                        r = mid1;

                        g = m;

                        b = v;

                        break;

                    case 5:

                        r = v;

                        g = m;

                        b = mid2;

                        break;

                }

            }

            return Color.FromArgb(Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));
        }
    }
}
