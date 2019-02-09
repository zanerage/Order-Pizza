using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }
        double Small, Medium, Large, XLarge;
        double Basic, Veggie, Chicago, Neapolitian, Sicilian, Greek;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = XLarge;
            total = baseprice + basicsurcharge;

            TxtBasePrice.Text = baseprice.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Basic;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Veggie;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Chicago;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Neapolitian;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Sicilian;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            basicsurcharge = Greek;
            total = baseprice + basicsurcharge;

            TxtItemSurcharge.Text = basicsurcharge.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            subtotal = total * int.Parse(TxtQuantity.Text);
            TxtSubTotal.Text = subtotal.ToString("c");

            tax = subtotal * 0.12;
            TxtTax.Text = tax.ToString("c");

            grandtotal = subtotal + tax;
            TxtTotal.Text = grandtotal.ToString("c");

            MessageBox.Show("Your total price for this order is " + grandtotal + " £" + " Please press Confirm Order to fill out the address form");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = Large;
            total = baseprice + basicsurcharge;

            TxtBasePrice.Text = baseprice.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;

            baseprice = 0;
            basicsurcharge = 0;
            TxtBasePrice.Text = "";
            TxtItemSurcharge.Text = "";
            TxtPrice.Text = "";
            TxtQuantity.Text = "";
            TxtSubTotal.Text = "";
            TxtTax.Text = "";
            TxtTotal.Text = "";
            TxtQuantity.Text = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = Medium;
            total = baseprice + basicsurcharge;

            TxtBasePrice.Text = baseprice.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double baseprice, basicsurcharge, subtotal, tax, total, grandtotal;

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = Small;
            total = baseprice + basicsurcharge;

            TxtBasePrice.Text = baseprice.ToString("c");
            TxtPrice.Text = total.ToString("c");
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            Small = 3.99;
            Medium = 6.99;
            Large = 8.99;
            XLarge = 11.99;
            Basic = 0.79;
            Veggie = 2.39;
            Chicago = 6.07;
            Neapolitian = 6.45;
            Sicilian = 4.75;
            Greek = 6.55;

            baseprice = 0;
            basicsurcharge = 0;

            TxtQuantity.Text = "0";
        }
    }
}
