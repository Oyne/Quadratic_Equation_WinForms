using System.Globalization;
using QuadraticEquation;

namespace QuadraticEquationForm
{
    public partial class Form1 : Form
    {
        // Number of digits after decimal point
        private int decimalNumber = 15;

        // Value for checking double zero
        private double zeroEquality = 0.0000000001;

        // Exception for calculating non quadratic equation
        private Exception NotQuadraticEquation = new Exception("You entered not a quadratic equation");

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Input limiter
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Button pressed</param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checking in input is digit or , and .
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Swaping . to ,
                if (e.KeyChar == '.')
                    e.KeyChar = ',';
                // Restricting input of ,
                if (e.KeyChar == ',')
                {
                    if (((TextBox)sender).Text.Contains(",") || ((TextBox)sender).Text.Length == 0)
                        e.KeyChar = (char)Keys.None;
                }
                // Restricting input of -
                if (e.KeyChar == '-')
                {

                    if (((TextBox)sender).Text.Length > 0)
                        e.KeyChar = (char)Keys.None;
                }
                // Restricting input of digits after 0 and -0
                if (Char.IsDigit(e.KeyChar))
                {

                    if ((((TextBox)sender).Text == "0" || ((TextBox)sender).Text == "-0"))
                        e.KeyChar = (char)Keys.None;
                }
            }
            // Input is not digit or , and .
            else
                e.KeyChar = (char)Keys.None;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            aTextBox.Clear();
            bTextBox.Clear();
            cTextBox.Clear();
            dTextBox.Clear();
            xFirstTextBox.Clear();
            xSecondTextBox.Clear();
        }

        /// <summary>
        /// Calculates quadratic equation
        /// </summary>
        /// <param name="a">a value</param>
        /// <param name="b">b value</param>
        /// <param name="c">c value</param>
        /// <returns>String array of D, x1 and x2</returns>
        private string[] quadraticEquation(double a, double b, double c)
        {
            // Array with results of calculation
            string[] result = new string[3];
            // D
            double d = b * b - 4 * a * c;

            // Checking D for calculation
            if (d < 0)
            {
                result[0] = "D < 0";
            }
            else if (d < zeroEquality)
            {
                // Checking for non quadratic equation
                if (a < zeroEquality && a == Math.Abs(a))
                    throw NotQuadraticEquation;

                double x = Math.Round(-b / (2 * a), decimalNumber);

                result[0] = d.ToString();
                result[1] = result[2] = x.ToString();

            }
            else
            {
                // Checking for non quadratic equation
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
                    // D
                    double d = b * b - 4 * a * c;

                    // Checking D for calculation
                    if (d < 0)
                    {
                        dTextBox.Text = "D < 0";
                    }
                    else if (d < zeroEquality)
                    {
                        // Checking for non quadratic equation
                        if (a < zeroEquality && a == Math.Abs(a))
                            throw NotQuadraticEquation;

                        double x = Math.Round(-b / (2 * a), decimalNumber);

                        dTextBox.Text = d.ToString();
                        xFirstTextBox.Text = xSecondTextBox.Text = x.ToString();
                    }
                    else
                    {
                        // Checking for non quadratic equation
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
                    QuadEq equation = new QuadEq(a, b, c);
                    equation.Calculate();

                    // Checking for roots
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