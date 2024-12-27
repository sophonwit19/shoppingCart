using System;
using System.Diagnostics;

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

        private void tbGreenteaQuantity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            double coffeePrice = GetDoubleFromMaskedTextBox(tbCoffeePrice);
            double coffeeQuantity = GetDoubleFromMaskedTextBox(tbCoffeeQuantity);
            double greenTeaPrice = GetDoubleFromMaskedTextBox(tbGreenteaPrice);
            double greenTeaQuantity = GetDoubleFromMaskedTextBox(tbGreenteaQuantity);

            double totalCoffee = chbCoffee.Checked ? coffeePrice * coffeeQuantity : 0;
            double totalGreenTea = chbgreentea.Checked ? greenTeaPrice * greenTeaQuantity : 0;

            double total = totalCoffee + totalGreenTea;

            tbtotal.Text = total.ToString();
        }

        private double GetDoubleFromMaskedTextBox(MaskedTextBox textBox)
        {
            double value;
            if (double.TryParse(textBox.Text, out value))
            {
                return value;
            }
            return 0;
        }

        private void tbCash_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            int cash = GetIntFromMaskedTextBox(tbCash);
            int total = GetIntFromMaskedTextBox(tbtotal);

            int change = cash - total;
            tbChange.Text = change.ToString();

            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] changeCount = new int[denominations.Length];

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = change / denominations[i];
                change %= denominations[i];
            }

            tb1000.Text = changeCount[0].ToString();
            tb500.Text = changeCount[1].ToString();
            tb100.Text = changeCount[2].ToString();
            tb50.Text = changeCount[3].ToString();
            tb20.Text = changeCount[4].ToString();
            tb10.Text = changeCount[5].ToString();
            tb5.Text = changeCount[6].ToString();
            tb1.Text = changeCount[7].ToString();
        }

        private int GetIntFromMaskedTextBox(MaskedTextBox textBox)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                return value;
            }
            return 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}