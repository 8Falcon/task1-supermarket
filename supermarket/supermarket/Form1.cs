using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class Form1 : Form
    {
        private object otal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string name, ProductName, city;
            short quantity, discount, delivery;
            int total, totalafter, nettotal, discountval, Price;
       


            name = txtname.Text;
            ProductName = txtproduct.Text;
            quantity = short.Parse(numquant.Value.ToString());
            Price = int.Parse(maskprice.Text);
            city = combcitiy.SelectedItem.ToString();

            total = quantity * Price;
            if (total < 1000)
                discount = 0;
            else if (total < 3000)
                discount = 10;
            else if (total < 6000)
                discount = 15;
            else
                discount = 20;


            discountval = total * discount;
            totalafter = total - discountval;


            switch (city)
            {
                case "القاهرة":
                    delivery = 35;
                    break;
                case "الجيزه":
                    delivery = 55;
                    break;
                default:
                    delivery = 60;
                    break;
            }
            nettotal = totalafter + delivery;
            txttotal.Text = total.ToString();
            txtdiscval.Text = discount.ToString();
            txtafter.Text = totalafter.ToString();
            txtdilv.Text = delivery.ToString();
            txtnet.Text = nettotal.ToString();
        }
    }
}
