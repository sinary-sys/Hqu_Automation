using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADRCVisualization.Class_Files
{
    static class BitmapModifier
    {
        /// <summary>
        /// Joins two bitmap images, right beside each other
        /// </summary>
        /// <param name="bmp1"></param>
        /// <param name="bmp2"></param>
        /// <returns></returns>
        public static Bitmap CombineImages(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap target = new Bitmap(bmp1.Width, bmp1.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(target);
            g.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

            g.DrawImage(bmp1, 0, 0);
            g.DrawImage(bmp2, 0, 0);

            return target;
        }

        /// <summary>
        /// Rotates an image to a specific angle
        /// </summary>
        /// <param name="b">Bitmap image</param>
        /// <param name="angle">Target angle</param>
        /// <returns></returns>
        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            if (!float.IsNaN(angle))
            {
                Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
                Graphics g = Graphics.FromImage(returnBitmap);

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                g.DrawImage(b, 0, 0, b.Width, b.Height);  //My Final Solution :3

                return returnBitmap;
            }
            else
            {
                return b;
            }
        }
        
        /// <summary>
        /// Adds two bitmap images overtop one another. Only works well with transparent image.
        /// </summary>
        /// <param name="original">Image to be added to.</param>
        /// <param name="adding">Must be at least partially transparent.</param>
        /// <returns></returns>
        public static Bitmap MergeBitmaps(Bitmap original, Bitmap adding)
        {
            Bitmap bitmap = new Bitmap(original.Width + adding.Width, Math.Max(original.Height, adding.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawImage(original, 0, 0);
                g.DrawImage(adding, original.Width, 0);
            }

            return bitmap;
        }
    }
}
