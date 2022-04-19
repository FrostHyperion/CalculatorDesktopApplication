namespace CalculatorDesktopApplication
{
    public partial class Calculator : Form
    {
        double resValue = 0;

        string operationPerformed = "";
        string operand = "";
        bool operationPerformedIs = false;
        public Calculator()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            CalcDisplay.Clear();
        }


        private void CalcDisplay_TextChanged(object sender, EventArgs e)
        {
        }



        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (CalcDisplay.Text == "0" || (operationPerformedIs))
                CalcDisplay.Clear();

            operationPerformedIs = false;
            
            if (button.Text == ".") {
                if (!CalcDisplay.Text.Contains("."))
                    CalcDisplay.Text += button.Text;
            } else
                CalcDisplay.Text += button.Text;
        }

        private void oper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resValue != 0)
            {

                operationPerformed = button.Text;

                btnEquals.PerformClick();
                resValue = double.Parse(CalcDisplay.Text);
                //CalcDisplay.Clear();

                operationPerformedIs = true;
            } else {
                operationPerformed = button.Text;
                resValue = double.Parse(CalcDisplay.Text);
                operand = resValue + " " + operationPerformed;
                labelOper.Text = operand;

                operationPerformedIs = true;
            }
            CalcDisplay.Text = "0";
        }

        private void btn_Convert(object sender, EventArgs e)
        {
            
        }




        private void btn_equals(object sender, EventArgs e)
        {
            operationPerformedIs = false;

            if (CalcDisplay.Text != "")
            {
                switch (operationPerformed)
                {
                    case "+":
                        CalcDisplay.Text = (resValue + double.Parse(CalcDisplay.Text)).ToString();
                        labelOper.Text = CalcDisplay.Text + " " + operationPerformed;
                        break;
                    case "-":
                        CalcDisplay.Text = (resValue - double.Parse(CalcDisplay.Text)).ToString();
                        labelOper.Text = CalcDisplay.Text + " " + operationPerformed;
                        break;
                    case "/":
                        CalcDisplay.Text = (resValue / double.Parse(CalcDisplay.Text)).ToString();
                        labelOper.Text = CalcDisplay.Text + " " + operationPerformed;
                        break;
                    case "*":
                        CalcDisplay.Text = (resValue * double.Parse(CalcDisplay.Text)).ToString();
                        labelOper.Text = CalcDisplay.Text + " " + operationPerformed;
                        break;
                    default:
                        break;
                }

            }
        }

        private void labeloper(object sender, EventArgs e)
        {

        }

        private void labelOper_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            CalcDisplay.Text = "";
            resValue = 0;
            operand = "";
            labelOper.Text = "";
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 46) {
                if (CalcDisplay.Text == "0" && (int)e.KeyChar == 46)
                {
                    CalcDisplay.Text = "0.";
                }
                else
                {
                    if ((int)e.KeyChar == 46 && !CalcDisplay.Text.Contains("."))
                    {
                        CalcDisplay.Text += e.KeyChar;
                    }
                    else if ((int)e.KeyChar != 46)
                    {
                        if (CalcDisplay.Text == "0")
                        {
                            CalcDisplay.Text = e.KeyChar.ToString();
                        }
                        else
                        {
                            CalcDisplay.Text += e.KeyChar;
                        }
                    }
                }
            }

            if ((int)e.KeyChar == 42 ||
                 (int)e.KeyChar == 43 ||
                 (int)e.KeyChar == 45 ||
                 (int)e.KeyChar == 46
                ) {
                if (e.KeyChar.ToString() != operationPerformed && operationPerformed != "")
                {
                    operationPerformed = e.KeyChar.ToString();
                }

                if (operationPerformed != "" && operand != "" && CalcDisplay.Text != "0")
                {
                }

                operand = CalcDisplay.Text;
                operationPerformed = e.KeyChar.ToString();

                label1.Text = $"{operand} {operationPerformed}";

                CalcDisplay.Text = "0";
            }
       
    }

        private void btn_Convert_Dec(object sender, EventArgs e) {
            CalcDisplay.Text = Convert.ToInt32(CalcDisplay.Text, 2).ToString();
        }

        private void btn_Convert_Bin(object sender, EventArgs e) {
            try
            {
                string sum = "";
                int n, i;
                int[] a = new int[100];

                n = int.Parse(CalcDisplay.Text);
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }

                for (i = i - 1; i >= 0; i--)
                {
                    sum = sum + a[i].ToString();
                }
                CalcDisplay.Text = sum;
            }
            catch
            {
                CalcDisplay.Text = "Error";
            }
        }
    }
}
