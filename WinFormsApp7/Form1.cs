namespace WinFormsApp7
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ConvertEurosToDollars(double euros, double rate)
        {
            return euros * rate;
        }

        private double ConvertDollarsToEuros(double dollars, double rate)
        {
            return dollars / rate;
        }

        private void btnToDollars_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEuros.Text, out double euros) && double.TryParse(txtRate.Text, out double rate))
            {
                double dollars = ConvertEurosToDollars(euros, rate);
                lblDollars.Text = $"{dollars:F2} USD";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Euros and Rate.");
            }
        }

        private void btnToEuros_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDollars.Text, out double dollars) && double.TryParse(txtRate.Text, out double rate))
            {
                double euros = ConvertDollarsToEuros(dollars, rate);
                lblEuros.Text = $"{euros:F2} EUR";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Dollars and Rate.");
            }
        }



        private void SolveQuadratic(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                MessageBox.Show("No real solutions");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                MessageBox.Show($"Solutions: x1 = {x1:F2}, x2 = {x2:F2}");
            }
        }
    }
}

