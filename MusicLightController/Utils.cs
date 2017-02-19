using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLightController
{
    class Utils
    {
        public static Color BilinearInterpolation(Color q11, Color q12, Color q21, Color q22, float x, float y)
        {
            return Color.FromArgb((byte)BilinearInterpolation(q11.R, q12.R, q21.R, q22.R, x, y), (byte)BilinearInterpolation(q11.G, q12.G, q21.G, q22.G, x, y), (byte)BilinearInterpolation(q11.B, q12.B, q21.B, q22.B, x, y));
        }

        private static float BilinearInterpolation(float q11, float q12, float q21, float q22, float x, float y)
        {
            float x2x1, y2y1, x2x, y2y, yy1, xx1;
            x2x1 = 1.0f;
            y2y1 = 1.0f;
            x2x = 1.0f - x;
            y2y = 1.0f - y;
            yy1 = y;
            xx1 = x;
            return 1.0f / (x2x1 * y2y1) * (
                q11 * x2x * y2y +
                q21 * xx1 * y2y +
                q12 * x2x * yy1 +
                q22 * xx1 * yy1
            );
        }

        public static Color ParseRGB(string source)
        {
            string[] splits = source.Split(';');

            return Color.FromArgb(Convert.ToByte(splits[0]), Convert.ToByte(splits[1]), Convert.ToByte(splits[2]));
        }

        public static string ColorToString(Color c)
        {
            return c.R.ToString() + ";" + c.G.ToString() + ";" + c.B.ToString();
        }
    }
}
