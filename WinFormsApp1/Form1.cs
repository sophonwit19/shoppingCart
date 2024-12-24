namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbCoffeeQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbGreentaeQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get amount
            string strCoffeePrice = tbCoffeePrice.Text;
            //get print
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            string strGreenteaPrice = tbGreenteaPrice.Text;
            string strGreenteaQuantity = tbGreenteaQuantity.Text;

            int  iCoffeePrice = 0, iCoffeeQuantity = 0, iGreenteaPrice = 0, iGreenteaQuantity =0,

            try
            { 
                 if (chbCoffee.Checked)
                 {
                }
            }


            //convert string to int


            //calculate total
            //int iTotal = iCoffeePrice * iCoffeeQuantity;
            //display total
            tbtotal.Text = iTotal.ToString();


        }
    }
}
