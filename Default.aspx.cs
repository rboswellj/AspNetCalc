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
        public static string num1 = String.Empty;
        public static string num2 = String.Empty;
        public static char operation;
        public static double result;
        public static bool needClear = false;

        public void EnterNumber(string num)
        {
            if (needClear)
            {
                calcDisplay.Text = String.Empty;
                input = String.Empty;
                needClear = false;
            }
            string value = num;
            input += value;
            calcDisplay.Text += value;
            errorAlert.Text = String.Empty;
        }

        public void GetEquals(string number1, string number2, char op)
        {
            // Switch statement on operation dicates which operation to perform
            switch (op)
            {
                case '+':
                    result = double.Parse(number1) + double.Parse(number2);
                    break;
                case '-':
                    result = double.Parse(number1) - double.Parse(number2);
                    break;
                case '*':
                    result = double.Parse(number1) * double.Parse(number2);
                    break;
                case '/':
                    if(number2 != "0")
                    {
                        result = double.Parse(number1) / double.Parse(number2);
                        break;
                    }
                    else
                    {
                        result = double.Parse(number1);
                        errorAlert.Text = "Cannot divide by zero.";
                        errorAlert.Visible = true;
                        break;
                    }
                default:
                    result = double.Parse(num1);
                    break;
            }
            // Assigns result to calculator display. Also assigns it to input, so operation can continue on result.
            calcDisplay.Text = Convert.ToString(result);
            input = String.Empty;
            num1 = Convert.ToString(result);
            num2 = String.Empty;
        }

        public void SetOperation(char op)
        {
            if(calcDisplay.Text != String.Empty)
            {
                if (num1 == String.Empty)
                {
                    num1 = input;
                    input = String.Empty;
                    calcDisplay.Text = String.Empty;
                    operation = op;
                }
                else
                {
                    num2 = input;
                    GetEquals(num1, num2, op);
                    needClear = true;
                }
            
                errorAlert.Text = String.Empty;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            errorAlert.Text = String.Empty;
            calcDisplay.Attributes.Add("readonly", "readonly");
        }

        #region Number Buttons

        protected void OneBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        protected void TwoBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        protected void ThreeBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        protected void FourBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        protected void FiveBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        protected void SixBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        protected void SevenBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        protected void EightBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        protected void NineBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }

        protected void ZeroBtn_Click(object sender, EventArgs e)
        {
            EnterNumber("0");
        }

        protected void DotBtn_Click(object sender, EventArgs e)
        {
            EnterNumber(".");
        }
        #endregion

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            string value = String.Empty;
            input = value;
            calcDisplay.Text = value;
            errorAlert.Text = String.Empty;
            num1 = value;
            num2 = value;
        }

        #region operator buttons
        protected void PlusBtn_Click(object sender, EventArgs e)
        {
            SetOperation('+');
        }
        protected void MinusBtn_Click(object sender, EventArgs e)
        {
            SetOperation('-');
        }

        protected void TimesBtn_Click(object sender, EventArgs e)
        {
            SetOperation('*');
        }

        protected void DivideBtn_Click(object sender, EventArgs e)
        {
            SetOperation('/');
        }

        protected void EqBtn_Click(object sender, EventArgs e)
        {
            if(num2 == String.Empty)
            {
                num2 = input;
            }
            // Insure that equals operation will only proceed if 2 values assigned
            if(num1 != String.Empty && num2 != String.Empty)
            {
                GetEquals(num1, num2, operation);
            }
        }

        #endregion
    }
}