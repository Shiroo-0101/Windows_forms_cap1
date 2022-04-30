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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int edad = Convert.ToInt32(textBox2.Text);
            if (edad >= 18)
            {
                label3.Text = nombre;
                label4.Text = "eres mayor de edad";
            }
            else 
            {
                label3.Text = nombre;
                label4.Text = ("no eres menor de edad");
            }
        }
    }
}
