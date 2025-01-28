using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale.Themes
{
    public static class ThemeColors
    {
        public static Color LightGray { get; } = Color.FromArgb(0xEF, 0xEF, 0xEF); // Light Gray (#EFEFEF)
        public static Color SoftBlue { get; } = Color.FromArgb(0x6A, 0xA3, 0xFF);  // Soft Blue (#6AA3FF)
        public static readonly Color SkyBlue = Color.FromArgb(0xFF, 0x00, 0x99, 0xFF);   // Sky Blue (#0099FF)
        public static readonly Color BrightBlue = Color.FromArgb(0xFF, 0x32, 0xCC, 0xFF); // Bright Blue (#32CCFF)

        public static readonly Color TextColor = Color.FromArgb(0xFF, 0x32, 0xCC, 0xFF); // Bright Blue (#32CCFF)



        public static void ApplyGradientToPanel(Panel panel, Color startColor, Color endColor, LinearGradientMode mode)
        {
            panel.Paint += (s, e) =>
            {
                using (var gradientBrush = new LinearGradientBrush(panel.ClientRectangle, startColor, endColor, mode))
                {
                    e.Graphics.FillRectangle(gradientBrush, panel.ClientRectangle);
                }
            };

            // Force the panel to repaint
            panel.Invalidate();
        }


    }


}
