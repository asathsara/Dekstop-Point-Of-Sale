using PointOfSale.Repositories;
using PointOfSale.Themes;
using System;
using System.Configuration;
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

            SetPanelGradients();

            // Set values


            DashboardRepository dashboardRepo = new DashboardRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

            // Get the total counts using the repository
            labelTotalItems.Text = dashboardRepo.GetItemCount().ToString();
            labelTotalEmployees.Text = dashboardRepo.GetEmployeesCount().ToString();
            labelTotalCustomers.Text = dashboardRepo.GetCustomerCount().ToString();

            // Get the first day and last day of the current month
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Get the total income for today
            string todayIncome = dashboardRepo.GetTodayTotal(today).ToString("F2");

            // Get the total profit for today (replacing discount with profit)
            string todayProfit = dashboardRepo.GetTodayProfit(today).ToString("F2");
            string todayOrders = dashboardRepo.GetTodayOrders(today).ToString();

            // Get the monthly totals
            string monthlyIncome = dashboardRepo.GetMonthlyIncome(firstDayOfMonth, lastDayOfMonth).ToString("F2");
            string monthlyProfit = dashboardRepo.GetMonthlyProfit(firstDayOfMonth, lastDayOfMonth).ToString("F2");
            string monthlyOrders = dashboardRepo.GetMonthlyOrders(firstDayOfMonth, lastDayOfMonth).ToString();


            labelMonthlyIncome.Text = monthlyIncome;
            labelMonthlyProfit.Text = monthlyProfit;
            labelMonthlyOrders.Text = monthlyOrders;

            labelTodayIncome.Text = todayIncome;
            labelTodayProfit.Text = todayProfit;
            labelTodayOrders.Text = todayOrders;
        }

        private void SetPanelGradients()
        {
            ThemeColors.ApplyGradientToPanel(roundedPanelTopOne, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
            ThemeColors.ApplyGradientToPanel(roundedPanelTopThree, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
            ThemeColors.ApplyGradientToPanel(roundedPanelTopTwo, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);

            ThemeColors.ApplyGradientToPanel(roundedPanelShapeOne, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeTwo, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeThree, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeFour, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeFive, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical); ThemeColors.ApplyGradientToPanel(roundedPanelShapeSix, ThemeColors.SkyBlue, ThemeColors.BrightBlue, LinearGradientMode.Vertical);
        }
    }
}
