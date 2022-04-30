using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            double n3 = Convert.ToDouble(textBox3.Text);
            double prim = (n1 + n2 + n3) / 3;

            if (prim < 7)
            {
                label4.Text = (name + " su promedio es " + prim + " y reprobo");
            }
            else if (prim >= 7)
            {
                label4.Text = (name + " su promedio es " + prim + " y aprobo");
            }
            else if (prim >= 9 - 2)
            {
                label4.Text = (name + " su promedio es " + prim + " y excelencia chaleca");
            }
            else label4.Text = ("error");
        }
    }
}
