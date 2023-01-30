namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void n_click(object sender, EventArgs e)
        {
            if ((ResultBox.Text == "0") || isOpPerformed)
                ResultBox.Clear();

            isOpPerformed = false;
            Button n = (Button) sender;
            if(n.Text == ".")
            {
                if(!ResultBox.Text.Contains("."))
                    ResultBox.Text = ResultBox.Text + n.Text;
            }else
                ResultBox.Text = ResultBox.Text + n.Text;

        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button) sender;
            if (resultValue != 0)
            {
                nequal.PerformClick();
                opPerformed = n.Text;
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            } else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(ResultBox.Text);
                lcurrentOp.Text = resultValue + " " + opPerformed;
                isOpPerformed = true;
            } 
        }

        private void nce_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void nc_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch(opPerformed) {
                case "+":
                    ResultBox.Text = (resultValue + Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "-":
                    ResultBox.Text = (resultValue - Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "*":
                    ResultBox.Text = (resultValue * Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "/":
                    ResultBox.Text = (resultValue / Double.Parse(ResultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(ResultBox.Text);
            lcurrentOp.Text = "";
        }
    }
}