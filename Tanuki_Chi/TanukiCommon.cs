using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanuki_Chi
{
    internal class TanukiCommon
    {
        /// <summary>
        /// 画像範囲取得
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Rectangle getImageBorder(Image image)
        {
            Bitmap bitmap = new Bitmap(image);

            FrameDimension frameDimension = new FrameDimension(bitmap.FrameDimensionsList[0]);
            int int_frame_count = bitmap.GetFrameCount(frameDimension);

            int int_left = -1;
            int int_top = -1;
            int int_right = -1;
            int int_bottom = -1;

            for (int int_frame_no = 0; int_frame_no < int_frame_count; ++int_frame_no)
            {
                bitmap.SelectActiveFrame(frameDimension, int_frame_no);

                // フレームをチェックしてX座標最小値を取得する。
                for (int int_x = 0; int_x < bitmap.Width; ++int_x)
                {
                    bool bol_found = false;
                    for (int int_y = 0; int_y < bitmap.Height; ++int_y)
                    {
                        Color color = bitmap.GetPixel(int_x, int_y);
                        if (color.A != 0)
                        {
                            bol_found = true;
                            if (int_left < int_x)
                            {
                                int_left = int_x;
                            }
                            break;
                        }
                    }
                    if (bol_found)
                    {
                        break;
                    }
                }

                // フレームをチェックしてY座標最小値を取得する。
                for (int int_y = 0; int_y < bitmap.Height; ++int_y)
                {
                    bool bol_found = false;
                    for (int int_x = 0; int_x < bitmap.Width; ++int_x)
                    {
                        Color color = bitmap.GetPixel(int_x, int_y);
                        if (color.A != 0)
                        {
                            bol_found = true;
                            if (int_top < int_y)
                            {
                                int_top = int_y;
                            }
                            break;
                        }
                    }
                    if (bol_found)
                    {
                        break;
                    }
                }

                // フレームをチェックしてX座標最大値を取得する。
                for (int int_x = bitmap.Width - 1; int_x >= 0; --int_x)
                {
                    bool bol_found = false;
                    for (int int_y = 0; int_y < bitmap.Height; ++int_y)
                    {
                        Color color = bitmap.GetPixel(int_x, int_y);
                        if (color.A != 0)
                        {
                            bol_found = true;
                            if (int_right < int_x)
                            {
                                int_right = int_x;
                            }
                            break;
                        }
                    }
                    if (bol_found)
                    {
                        break;
                    }
                }

                // フレームをチェックしてY座標最大値を取得する。
                for (int int_y = bitmap.Height - 1; int_y >= 0; --int_y)
                {
                    bool bol_found = false;
                    for (int int_x = 0; int_x < bitmap.Width; ++int_x)
                    {
                        Color color = bitmap.GetPixel(int_x, int_y);
                        if (color.A != 0)
                        {
                            bol_found = true;
                            if (int_bottom < int_y)
                            {
                                int_bottom = int_y;
                            }
                            break;
                        }
                    }
                    if (bol_found)
                    {
                        break;
                    }
                }
            }

            bitmap.Dispose();

            return new Rectangle(int_left, int_top, int_right - int_left, int_bottom - int_top);
        }
    }
}
