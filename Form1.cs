using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            num = Convert.ToInt32(textBox1.Text);
            label4.Text = n1 + " " + n2 + " ";

            for(i=2;i<num;i++)
            {
                n3 = n1 + n2;
                label4.Text = label4.Text + n3 + "";
                n1 = n2;
                n2 = n3;
            }
 
                        


        

        
        
           
        }
    }
}
