using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class GraphicsUtils
    {
        public const int THRESHOLD = 127;
        public const int MAX_INTENSITY = 255;
        public const int MIN_INTENSITY = 0;

        public static Image FloydSteinbergDithering(Image img)
        {
            Bitmap bitmap = new Bitmap(img);
            int width = bitmap.Width;
            int height = bitmap.Height;

            int[,] color = new int[width, height];
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    color[i, j] = (299 * pixel.R + 587 * pixel.G + 114 * pixel.B) / 1000;
                }
            }

            Bitmap res = new Bitmap(width, height);

            int error = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (color[x, y] > THRESHOLD)
                    {
                        res.SetPixel(x, y, Color.White);
                        error = color[x, y] - MAX_INTENSITY;
                    }
                    else
                    {
                        res.SetPixel(x, y, Color.Black);
                        error = color[x, y] - MIN_INTENSITY;
                    }
                    if (x < width - 1)
                    {
                        color[x + 1, y] += 7 / 16 * error;
                    }
                    if (x < width - 1 && y < height - 1)
                    {
                        color[x + 1, y + 1] += 1 / 16 * error;
                    }
                    if (y < height - 1)
                    {
                        color[x, y + 1] += 5 / 16 * error;
                    }
                    if (x > 0 && y < height - 1)
                    {
                        color[x - 1, y + 1] += 3 / 16 * error;
                    }
                }
            }
            return res;
        }
    }
}
