using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxYear_TextChanged(object sender, EventArgs e)
        {
            int year = int.Parse(tbxYear.Text);
            if (year % 4 != 0)
                LbLResult.Text = "①平成です";
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        LbLResult.Text = "②うるう年です";
                    else
                        LbLResult.Text = "③平年です";
                }
                else
                    LbLResult.Text = "④うるう年です";
            }
        }
    }
}