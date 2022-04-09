using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetCalc2
{
    public partial class _Default : Page
    {
        public static string input = String.Empty;
        public static string num1;
        public static string num2;
        public static char operation;
        public static double result;

        protected void Page_Load(object sender, EventArgs e)
        {
            errorAlert.Text = String.Empty;
            calcDisplay.Attributes.Add("readonly", "readonly");
        }

        protected void OneBtn_Click(object sender, EventArgs e)
        {
            string value = "1";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void TwoBtn_Click(object sender, EventArgs e)
        {
            string value = "2";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void ThreeBtn_Click(object sender, EventArgs e)
        {
            string value = "3";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void FourBtn_Click(object sender, EventArgs e)
        {
            string value = "4";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void FiveBtn_Click(object sender, EventArgs e)
        {
            string value = "5";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void SixBtn_Click(object sender, EventArgs e)
        {
            string value = "6";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void SevenBtn_Click(object sender, EventArgs e)
        {
            string value = "7";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void EightBtn_Click(object sender, EventArgs e)
        {
            string value = "8";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void NineBtn_Click(object sender, EventArgs e)
        {
            string value = "9";
            input += value;
            calcDisplay.Text += value; 
            errorAlert.Text = String.Empty;
        }

        protected void ZeroBtn_Click(object sender, EventArgs e)
        {
            string value = "0";
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            string value = String.Empty;
            input = value;
            calcDisplay.Text = value;
            errorAlert.Text = String.Empty;
        }

        protected void PlusBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            operation = '+';
            input = String.Empty;
            calcDisplay.Text = String.Empty;
            errorAlert.Text = String.Empty;
        }
        protected void MinusBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            operation = '-';
            input = String.Empty;
            calcDisplay.Text = String.Empty;
            errorAlert.Text = String.Empty;
        }

        protected void TimesBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            operation = '*';
            input = String.Empty;
            calcDisplay.Text = String.Empty;
            errorAlert.Text = String.Empty;
        }

        protected void DivideBtn_Click(object sender, EventArgs e)
        {
            num1 = input;
            operation = '/';
            input = String.Empty;
            calcDisplay.Text = String.Empty;
            errorAlert.Text = String.Empty;
        }

        protected void EqBtn_Click(object sender, EventArgs e)
        {
            num2 = input;
            switch (operation)
            {
                case '+':
                    result = double.Parse(num1) + double.Parse(num2);
                    break;
                case '-':
                    result = double.Parse(num1) - double.Parse(num2);
                    break;
                case '*':
                    result = double.Parse(num1) * double.Parse(num2);
                    break;
                case '/':
                    try
                    {
                        result = double.Parse(num1) / double.Parse(num2);
                        break;
                    }
                    catch
                    {
                        result = double.Parse(num1);
                        errorAlert.Text = "Cannot divide by zero.";
                        break;
                    }
                default:
                    result = double.Parse(num1);
                    break;
            }   
            calcDisplay.Text = Convert.ToString(result);
            input = Convert.ToString(result);
        }

    }
}