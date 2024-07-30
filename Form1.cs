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
            if (isSunny && !isCold && !isRaining)
            {
                MessageBox.Show("Nice and Sunny!");
            }
            else if (isRaining)
            {
                MessageBox.Show("I'll take a brolly");
            }
            else if (!isSunny && isCold)
            {
                MessageBox.Show("I'll take a Jacket");
            }
            else
            {
                MessageBox.Show("I'll stay at home");
            }
        }

        private void cbxRaining_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRaining.Checked)
            {
                isRaining = true;
            }
            else
            {
                isRaining = false;
            }
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
        }
        private void cbxSunny_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSunny.Checked)
            { isSunny = true; }
            else { isSunny = false; }

        }
    }
}

