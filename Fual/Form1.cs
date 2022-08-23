using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDrivername.Clear();
            txtVehicalno.Clear();
            txtNoliter.Clear();
            lblLiter.Text = "";
            lblAmount.Text = "";
            rdPetrol92.Checked = false;
            rdPetrol95.Checked = false;
            rdDiesel.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double P95, P92, Die, Price, Amount, Liter;

            Liter = double.Parse(txtNoliter.Text);


            {

                if (rdPetrol92.Checked)
                {
                    P92 = 420;
                    lblLiter.Text = "420";
                    Amount = P92 * Liter;

                    lblAmount.Text = Amount.ToString();
                }


                else if (rdPetrol95.Checked)
                {
                    P95 = 440;
                    lblLiter.Text = "440";
                    Amount = P95 * Liter;

                    lblAmount.Text = Amount.ToString();
                }


                else if (rdDiesel.Checked)
                {
                    Die = 400;
                    lblLiter.Text = "400";
                    Amount = Die * Liter;

                    lblAmount.Text = Amount.ToString();
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        

