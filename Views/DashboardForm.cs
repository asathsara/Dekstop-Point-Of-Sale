using PointOfSale.Themes;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {



            // Example usage with an existing panel
            ThemeColors.ApplyGradientToPanel(roundedPanelTopOne, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
            ThemeColors.ApplyGradientToPanel(roundedPanelTopThree, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
            ThemeColors.ApplyGradientToPanel(roundedPanelTopTwo, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);

            ThemeColors.ApplyGradientToPanel(roundedPanelShapeOne, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeTwo, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeThree, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeFour, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeFive, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeSix, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
        }
    }
}
