using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void cmdgcd_Click(object sender, EventArgs e)
        {
            int a, b;
            if (txtGcd1.Text != "" & txtGcd2.Text != "") {
                a = Convert.ToInt32(txtGcd1.Text);
                b = Convert.ToInt32(txtGcd2.Text);
                txtGcdR.Text = Convert.ToString(gcdfun(a, b));
            }
        }

        //---------GCD------------------------------------------
        public int gcdfun(int a,int b)
        {
            int temp;
        while (b > 0){
                temp = b;
            b = a % b;
            a = temp;
        }
            return a;
    }
        private void Reset_Click(object sender, EventArgs e)
        {
            txtGcd1.Clear();
            txtGcd2.Clear();
            txtGcdR.Clear();

        }

    }
}
