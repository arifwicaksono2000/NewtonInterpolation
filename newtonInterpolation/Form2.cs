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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            float Input1 = float.Parse(Inter1_1.Text);
            float Input2 = float.Parse(Inter1_2.Text);
            float Input3 = float.Parse(Inter1_3.Text);
            float Input4 = float.Parse(Inter1_4.Text);
            //Input1 = Input1 + Input2 + Input3 + Input4;
            //string Input = Input1.ToString();
            CountingTest counting = new CountingTest(Input1, Input2, Input3, Input4);
            //bool test = counting.loadScenarioNumberExecuted;
            //if (test)
            //{ MessageBox.Show("Lol"); }
            Inter2_1.Text = counting.inter2_1.ToString();
            Inter2_2.Text = counting.inter2_2.ToString();
            Inter2_3.Text = counting.inter2_3.ToString();
            Inter3_1.Text = counting.inter3_1.ToString();
            Inter3_2.Text = counting.inter3_2.ToString();
            Inter4_1.Text = counting.inter4_1.ToString();
            //Inter4_1.Text = Input;

        }
    }
}
