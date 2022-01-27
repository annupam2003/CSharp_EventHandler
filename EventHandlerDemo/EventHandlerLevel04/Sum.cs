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
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }
        public void SumOfTwo(int a,int b)
        {
            lbl_val1.Text = a.ToString();
            lbl_val2.Text = b.ToString();
            lbl_Ans.Text = Convert.ToString(a+b);
        }
    }
}
