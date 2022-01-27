using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerLevel04
{
    public partial class Form1 : Form
    {
        PublisherClass pub = null;
        Sum sum = null;
        Sub sub = null;
        Mul mul = null;
        Div div = null;
        public Form1()
        {
            InitializeComponent();
            sum = new Sum();
            sub = new Sub();
            mul = new Mul();
            div = new Div();

            pub = new PublisherClass();
            pub.NumberCalc += sum.SumOfTwo;
            pub.NumberCalc += sub.SubOfTwo;
            pub.NumberCalc += mul.MulOfTwo;
            pub.NumberCalc += div.DivOfTwo;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            pub?.calcProcess(a, b);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            sum.ShowDialog();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            sub.ShowDialog();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            mul.ShowDialog();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            div.ShowDialog();
        }
    }
}
