using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale.Components
{
    public partial class RoundedTextbox : UserControl
    {
        private TextBox textBox;
        private int borderRadius = 10; // Default radius
        private int borderWidth = 0;   // Border width
        private string placeholderText = "Enter text..."; // Default placeholder text
        private bool isPlaceholderActive = true; // Flag to check if the placeholder is active
        private char passwordChar = '\0'; // Default no password char
        private Color borderColor = System.Drawing.SystemColors.Control;
        private Color backgroundColor = System.Drawing.SystemColors.Control;

        // Event to notify when Enter key is pressed
        public event EventHandler EnterKeyPressed;

        // Event to notify when text changes
        public new event EventHandler TextChanged;

        public RoundedTextbox()
        {
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(10);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                BackColor = backgroundColor,
                ForeColor = Color.Gray,
                Font = new Font("Poppins", 12),
                Dock = DockStyle.Fill,
                Text = placeholderText
            };
            this.Controls.Add(textBox);

            this.Size = new Size(200, 40);

            textBox.GotFocus += RemovePlaceholder;
            textBox.LostFocus += SetPlaceholder;
            textBox.KeyDown += TextBox_KeyDown;
            textBox.TextChanged += (sender, e) => TextChanged?.Invoke(this, e);

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;

            SetPlaceholderState();
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public int BorderWidth
        {
            get => borderWidth;
            set { borderWidth = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set { backgroundColor = value; textBox.BackColor = value; this.Invalidate(); }
        }

        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value; if (isPlaceholderActive) SetPlaceholderState(); }
        }

        public char PasswordChar
        {
            get => passwordChar;
            set { passwordChar = value; if (!isPlaceholderActive) textBox.PasswordChar = passwordChar; }
        }

        public new string Text
        {
            get => isPlaceholderActive ? string.Empty : textBox.Text;
            set
            {
                isPlaceholderActive = string.IsNullOrEmpty(value);
                if (isPlaceholderActive) SetPlaceholderState();
                else
                {
                    textBox.Text = value;
                    textBox.ForeColor = Color.Black;
                    textBox.PasswordChar = passwordChar;
                }
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = passwordChar;
                isPlaceholderActive = false;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text)) SetPlaceholderState();
        }

        private void SetPlaceholderState()
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;
            textBox.PasswordChar = '\0';
            isPlaceholderActive = true;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundedRectPath(rect, borderRadius))
            {
                using (Brush brush = new SolidBrush(backgroundColor))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int arcWidth = radius * 2;

            path.AddArc(rect.X, rect.Y, arcWidth, arcWidth, 180, 90);
            path.AddArc(rect.Right - arcWidth, rect.Y, arcWidth, arcWidth, 270, 90);
            path.AddArc(rect.Right - arcWidth, rect.Bottom - arcWidth, arcWidth, arcWidth, 0, 90);
            path.AddArc(rect.X, rect.Bottom - arcWidth, arcWidth, arcWidth, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
