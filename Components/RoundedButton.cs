using PointOfSale.Themes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale.Components
{
    internal class RoundedButton : Button
    {
        // Fields
        private int bordersize = 0;
        private int topLeftRadius = 40;
        private int topRightRadius = 40;
        private int bottomLeftRadius = 40;
        private int bottomRightRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        // Properties for border radii
        public int TopLeftRadius
        {
            get { return topLeftRadius; }
            set { topLeftRadius = value; this.Invalidate(); }
        }
        public int TopRightRadius
        {
            get { return topRightRadius; }
            set { topRightRadius = value; this.Invalidate(); }
        }
        public int BottomLeftRadius
        {
            get { return bottomLeftRadius; }
            set { bottomLeftRadius = value; this.Invalidate(); }
        }
        public int BottomRightRadius
        {
            get { return bottomRightRadius; }
            set { bottomRightRadius = value; this.Invalidate(); }
        }

        // Constructor
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = ThemeColors.SoftBlue;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Poppins", 12, System.Drawing.FontStyle.Bold);
        }

        // Method to generate path for custom rounded corners
        private GraphicsPath GetFigurePath(RectangleF rect, int topLeft, int topRight, int bottomLeft, int bottomRight)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Top-left corner
            if (topLeft > 0)
                path.AddArc(rect.X, rect.Y, topLeft * 2, topLeft * 2, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // Top-right corner
            if (topRight > 0)
                path.AddArc(rect.Width - (topRight * 2), rect.Y, topRight * 2, topRight * 2, 270, 90);
            else
                path.AddLine(rect.Width, rect.Y, rect.Width, rect.Y);

            // Bottom-right corner
            if (bottomRight > 0)
                path.AddArc(rect.Width - (bottomRight * 2), rect.Height - (bottomRight * 2), bottomRight * 2, bottomRight * 2, 0, 90);
            else
                path.AddLine(rect.Width, rect.Height, rect.Width, rect.Height);

            // Bottom-left corner
            if (bottomLeft > 0)
                path.AddArc(rect.X, rect.Height - (bottomLeft * 2), bottomLeft * 2, bottomLeft * 2, 90, 90);
            else
                path.AddLine(rect.X, rect.Height, rect.X, rect.Height);

            path.CloseFigure();
            return path;
        }

        // Override OnPaint to handle custom drawing
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Ensure the radii don't exceed the button's height or width
            int adjustedTopLeftRadius = Math.Min(topLeftRadius, Math.Min(this.Width / 2, this.Height / 2));
            int adjustedTopRightRadius = Math.Min(topRightRadius, Math.Min(this.Width / 2, this.Height / 2));
            int adjustedBottomLeftRadius = Math.Min(bottomLeftRadius, Math.Min(this.Width / 2, this.Height / 2));
            int adjustedBottomRightRadius = Math.Min(bottomRightRadius, Math.Min(this.Width / 2, this.Height / 2));

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, adjustedTopLeftRadius, adjustedTopRightRadius, adjustedBottomLeftRadius, adjustedBottomRightRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, adjustedTopLeftRadius - 1, adjustedTopRightRadius - 1, adjustedBottomLeftRadius - 1, adjustedBottomRightRadius - 1))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(borderColor, bordersize))
            {
                penBorder.Alignment = PenAlignment.Inset;

                // Button surface
                this.Region = new Region(pathSurface);
                // Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                // Button border
                if (bordersize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        // Handle parent background color change
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Check if the Parent is not null
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
