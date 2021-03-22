using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conv_Click(object sender, EventArgs e)
        {
            double i = double.Parse(txt_amount.Text);

            if (combofrom1.SelectedItem == "Rupiah" && comboto1.SelectedItem == "Dollar")
            {
                double conver = i / 14393;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Dollar";
            }

            if (combofrom1.SelectedItem == "Rupiah" && comboto1.SelectedItem == "Euro")
            {
                double conver = i / 17172;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Euro";
            }

            if (combofrom1.SelectedItem == "Rupiah" && comboto1.SelectedItem == "Rupiah")
            {
                double conver = i;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Rupiah";
            }

            if (combofrom1.SelectedItem == "Dollar" && comboto1.SelectedItem == "Rupiah")
            {
                double conver = i * 14393;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Rupiah";
            }

            if (combofrom1.SelectedItem == "Dollar" && comboto1.SelectedItem == "Dollar")
            {
                double conver = i;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Dollar";
            }

            if (combofrom1.SelectedItem == "Dollar" && comboto1.SelectedItem == "Euro")
            {
                double conver = i * 0.84;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Euro";
            }

            if (combofrom1.SelectedItem == "Euro" && comboto1.SelectedItem == "Rupiah")
            {
                double conver = i * 17172;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Rupiah";
            }

            if (combofrom1.SelectedItem == "Euro" && comboto1.SelectedItem == "Dollar")
            {
                double conver = i * 1.19;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Dollar";
            }

            if (combofrom1.SelectedItem == "Euro" && comboto1.SelectedItem == "Euro")
            {
                double conver = i;
                double result = Math.Round(conver, 2);
                txt_display.Text = "Converted Amount : " + result + "\t Euro";
            }

        }
    }
}
