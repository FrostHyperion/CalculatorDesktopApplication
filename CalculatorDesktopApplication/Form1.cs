namespace CalculatorDesktopApplication
{
    public partial class Calculator : Form
    {
        double resValue=0;

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
            }
            else
                CalcDisplay.Text += button.Text;

        }

        private void oper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resValue!=0)
            {
                btnEquals.PerformClick();
                
                operationPerformed = button.Text;

                resValue = double.Parse(CalcDisplay.Text);
                //CalcDisplay.Clear();

                operand = resValue + " " + operationPerformed;
                labelOper.Text = operand;
                operationPerformedIs = true;
            }
            else
            {
                operationPerformed = button.Text;
                resValue = double.Parse(CalcDisplay.Text);
                operand = resValue + " " + operationPerformed;
                labelOper.Text = operand;

                operationPerformedIs = true;
            }
        }

        private void btn_Convert(object sender, EventArgs e)
        {

        }

        private void btn_equals(object sender, EventArgs e)
        {
            operationPerformedIs = false;

            if (CalcDisplay.Text!="")
            {
                switch (operationPerformed)
                {
                    case "+":
                        CalcDisplay.Text = (resValue + double.Parse(CalcDisplay.Text)).ToString();
                        break;
                    case "-":
                        CalcDisplay.Text = (resValue - double.Parse(CalcDisplay.Text)).ToString();
                        break;
                    case "/":
                        CalcDisplay.Text = (resValue / double.Parse(CalcDisplay.Text)).ToString();
                        break;
                    case "*":
                        CalcDisplay.Text = (resValue * double.Parse(CalcDisplay.Text)).ToString();
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

        
    }
}
