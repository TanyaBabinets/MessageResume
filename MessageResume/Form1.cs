using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageResume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string text1 = "It's my Resume:";
            MessageBox.Show(text1);
            string text2 = "I'm Tatiana Babinets";

            MessageBox.Show(text2);
            string text3 = "I apply for vacancy of programmer";
            MessageBox.Show(text3);

            int qty=text1.Length+text2.Length+text3.Length;
            int aver = qty / 3;
            MessageBox.Show(aver.ToString()," Average symbols: ", MessageBoxButtons.OK);

        }

        
    }
}
