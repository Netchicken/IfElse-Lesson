namespace IfElse_Lesson
{
    public partial class Form1 : Form
    {
        bool isSunny = false;
        bool isRaining = false;
        bool isCold = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            //if isSunny == true and isCold is NOT true, and isRaining is NOT true
            if (isSunny && !isCold && !isRaining)
            {
                //if all the conditions above are true show the message
                MessageBox.Show("Nice and Sunny!");
            }
            else if (isRaining) //if isRaining is True
            {
                MessageBox.Show("I'll take a brolly");
            }
            else if (!isSunny && isCold) //if isSunny is not true, and isCold is true
            {
                MessageBox.Show("I'll take a Jacket");
            }
            else //catch every other condition
            {
                MessageBox.Show("I'll stay at home");
            }
        }

        private void cbxRaining_CheckedChanged(object sender, EventArgs e)
        {
            //if you have put a tick in the Checkbox
            if (cbxRaining.Checked)
            {
                //then set the variable to true
                isRaining = true;
            }
            else
            {//otherwise if you unchecked the Checkbox set it to false
                isRaining = false;
            }
            //show the boolean value on the label
            lblRaining.Text = isRaining.ToString();
        }

        private void cbxCold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCold.Checked)
            {
                isCold = true;
            }
            else
            {
                isCold = false;
            }
            //show the boolean value on the label
            lblCold.Text = isCold.ToString();
        }
        private void cbxSunny_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSunny.Checked)
            { isSunny = true; }
            else
            {
                isSunny = false;
            }
            //show the boolean value on the label
            lblSunny.Text = isSunny.ToString();
        }

    }
}

