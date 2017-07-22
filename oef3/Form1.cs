using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef3
{
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            txtResult.Text = (getal1 + getal2).ToString();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            txtResult.Text = (getal1 - getal2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            txtResult.Text = (getal1 * getal2).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtGetal1.Text = "";
            txtGetal2.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            if (getal2==0)
            {
                MessageBox.Show("U kunt niet delen door 0");
                txtResult.Text = "Error";
            }
            else
            {
                txtResult.Text = (getal1 / getal2).ToString();
            }
        }
    }
}
