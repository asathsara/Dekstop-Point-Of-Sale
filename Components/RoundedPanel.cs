using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale.Components
{
    internal class RoundedPanel : Panel
    {
        // Fields for corner radii
        private int topLeftRadius = 40;
        private int topRightRadius = 40;
        private int bottomLeftRadius = 40;
        private int bottomRightRadius = 40;

        // Properties for adjusting corner radii
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
        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        // Helper method to create a GraphicsPath with adjustable corners
        private GraphicsPath GetFigurePath(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();

            // Top-left corner
            if (topLeftRadius > 0)
                path.AddArc(rect.X, rect.Y, topLeftRadius * 2, topLeftRadius * 2, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // Top-right corner
            if (topRightRadius > 0)
                path.AddArc(rect.Width - (topRightRadius * 2), rect.Y, topRightRadius * 2, topRightRadius * 2, 270, 90);
            else
                path.AddLine(rect.Width, rect.Y, rect.Width, rect.Y);

            // Bottom-right corner
            if (bottomRightRadius > 0)
                path.AddArc(rect.Width - (bottomRightRadius * 2), rect.Height - (bottomRightRadius * 2), bottomRightRadius * 2, bottomRightRadius * 2, 0, 90);
            else
                path.AddLine(rect.Width, rect.Height, rect.Width, rect.Height);

            // Bottom-left corner
            if (bottomLeftRadius > 0)
                path.AddArc(rect.X, rect.Height - (bottomLeftRadius * 2), bottomLeftRadius * 2, bottomLeftRadius * 2, 90, 90);
            else
                path.AddLine(rect.X, rect.Height, rect.X, rect.Height);

            path.CloseFigure();
            return path;
        }

        // Override OnPaint to handle custom drawing
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                this.Region = new Region(pathSurface); // Set the panel region to the rounded path
                e.Graphics.FillPath(brush, pathSurface); // Fill the background
            }
        }
    }
}