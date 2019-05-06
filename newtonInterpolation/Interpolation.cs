using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newtonInterpolation
{
    public partial class Interpolation : Form
    {
        public Interpolation()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            float a_1 = int.Parse(textBox1.Text);
            float a_2 = int.Parse(textBox3.Text);
            float a_3 = int.Parse(textBox5.Text);
            float a_4 = int.Parse(textBox7.Text);
            float f_1 = int.Parse(textBox2.Text);
            float f_2 = int.Parse(textBox4.Text);
            float f_3 = int.Parse(textBox6.Text);
            float f_4 = int.Parse(textBox8.Text);
            
            float target = int.Parse(textBox9.Text);


            CountingTest countingTest = new CountingTest(a_1, a_2, a_3, a_4, f_1, f_2, f_3, f_4, target);
            textBox10.Text = countingTest.fx.ToString();
        }
    }
}
