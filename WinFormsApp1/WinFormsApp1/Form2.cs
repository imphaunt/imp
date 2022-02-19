using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public string name;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string name)
        {
            InitializeComponent();
            textBox1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
        }
    }
}
