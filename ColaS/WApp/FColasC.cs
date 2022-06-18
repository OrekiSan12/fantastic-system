using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CApp;

namespace WApp
{
    public partial class FColasC : Form
    {
        public FColasC()
        {
            InitializeComponent();
        }
        clsColasC C = new clsColasC();

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int ele = int.Parse(textBox2.Text);
            C.Add(n - 1, ele);
            label1.Text = C.Mostrar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            C.Delete(n - 1);
            label1.Text = C.Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            label2.Text = C.From(n-1).ToString();

        }
    }
}
