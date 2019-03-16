using System;
using System.Windows.Forms;
using T3.Logic;

namespace T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SparseMatrix a = new SparseMatrix("../../../resources/a.txt");
        }
    }
}
