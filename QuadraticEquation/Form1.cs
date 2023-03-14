using System.Globalization;
using QuadraticEquation;

namespace QuadraticEquation
{
    public partial class Form1 : Form
    {

        private int decimalNumber = 15;

        private double zeroEquality = 0.0000000001;

        private Exception NotQuadraticEquation = new Exception("You entered not a quadratic equation");

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (e.KeyChar == '.')
                    e.KeyChar = ',';
                if (e.KeyChar == ',')
                {
                    if (((TextBox)sender).Text.Contains(",") || ((TextBox)sender).Text.Length == 0)
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '-')
                {

                    if (((TextBox)sender).Text.Length > 0)
                        e.KeyChar = (char)Keys.None;
                }
                if (Char.IsDigit(e.KeyChar))
                {

                    if ((((TextBox)sender).Text == "0" || ((TextBox)sender).Text == "-0"))
                        e.KeyChar = (char)Keys.None;
                }
            }
            else
                e.KeyChar = (char)Keys.None;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aTextBox.Clear();
            bTextBox.Clear();
            cTextBox.Clear();
            dTextBox.Clear();
            xFirstTextBox.Clear();
            xSecondTextBox.Clear();
        }

        private string[] quadraticEquation(double a, double b, double c)
        {
            string[] result = new string[3];
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                result[0] = "D < 0";
            }
            else if (d < zeroEquality)
            {
                if (a < zeroEquality && a == Math.Abs(a))
                    throw NotQuadraticEquation;

                double x = Math.Round(-b / (2 * a), decimalNumber);
                
                result[0] = d.ToString();
                result[1] = result[2] = x.ToString();

            }
            else
            {
                if (a < zeroEquality && a == Math.Abs(a))
                    throw NotQuadraticEquation;

                double x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), decimalNumber);
                double x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), decimalNumber);

                xFirstTextBox.Text = x1.ToString();
                xSecondTextBox.Text = x2.ToString();
                result[0] = d.ToString();
                result[1] = x1.ToString();
                result[2] = x2.ToString();
            }

            return result;
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            dTextBox.Clear();
            xFirstTextBox.Clear();
            xSecondTextBox.Clear();


            if (string.IsNullOrEmpty(aTextBox.Text) || string.IsNullOrEmpty(bTextBox.Text) || string.IsNullOrEmpty(cTextBox.Text))
            {
                MessageBox.Show(
                    "Empty fields",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            else if (!Double.TryParse(aTextBox.Text, out a)
                || !Double.TryParse(bTextBox.Text, out b)
                || !Double.TryParse(cTextBox.Text, out c))
            {
                MessageBox.Show(
                    "Wrong Input",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (firstMethodRadioButton.Checked)
            {
                try
                {
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        dTextBox.Text = "D < 0";
                    }
                    else if (d < zeroEquality)
                    {
                        if (a < zeroEquality && a == Math.Abs(a))
                            throw NotQuadraticEquation;

                        double x = Math.Round(-b / (2 * a), decimalNumber);

                        dTextBox.Text = d.ToString();
                        xFirstTextBox.Text = xSecondTextBox.Text = x.ToString();
                    }
                    else
                    {
                        if (a < zeroEquality && a == Math.Abs(a))
                            throw NotQuadraticEquation;

                        double x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), decimalNumber);
                        double x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), decimalNumber);

                        dTextBox.Text = d.ToString();
                        xFirstTextBox.Text = x1.ToString();
                        xSecondTextBox.Text = x2.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    dTextBox.Clear();
                    xFirstTextBox.Clear();
                    xSecondTextBox.Clear();
                }
            }
            if (secondMethodRadioButton.Checked)
            {
                try
                {
                    var result = quadraticEquation(a, b, c);
                    dTextBox.Text = result[0];
                    xFirstTextBox.Text = result[1];
                    xSecondTextBox.Text = result[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    dTextBox.Clear();
                    xFirstTextBox.Clear();
                    xSecondTextBox.Clear();
                }
            }
            else if (thirdMethodRadioButton.Checked)
            {
                try
                {
                    QuadraticEquation equation = new QuadraticEquation(a, b, c);
                    equation.Calculate();

                    if (equation.D < 0)
                    {
                        dTextBox.Text = "D < 0";
                    }
                    else
                    {
                        dTextBox.Text = equation.D.ToString();
                        xFirstTextBox.Text = equation.X1.ToString();
                        xSecondTextBox.Text = equation.X2.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    dTextBox.Clear();
                    xFirstTextBox.Clear();
                    xSecondTextBox.Clear();
                }
            }
        }
    }
}
