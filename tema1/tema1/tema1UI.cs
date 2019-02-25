using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema1
{
    public partial class tema1UI : Form
    {
        double u;
        public tema1UI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pb1 = new Problem1();
            var pb1List = pb1.returnMachinePrecision();
            u = pb1List[0];
            MessageBox.Show("Machine Precision: " + pb1List[0] + " = 10^-" + pb1List[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (u == default(double))
            {
                MessageBox.Show("Press 1st problem!");
            }
            else
            {
                var pb2 = new Problem2();
                var response1 = pb2.checkSumAssociativity(1.0, u, u);
                var response2 = pb2.checkMultiplicityAssociativity(5.0, 5.0, u);
                MessageBox.Show("Sum Associativity: " + response1 + "\n\t for values: " + 1.0 + ", " + u + ", " + u
                    +'\n' + "Mult. Associativity: " + response2 + "\n\t for values: " + 5.0 + ", " + 5.0 + ", " + u);
                //  2: false for every pozitive number: nr, nr, u

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Problem3 pb3 = new Problem3();
            MessageBox.Show("poly 1: " + pb3.timeToRun[0] + '\n'+
                             "poly 2: " + pb3.timeToRun[1] + '\n' +
                             "poly 3: " + pb3.timeToRun[2] + '\n' +
                             "poly 4: " + pb3.timeToRun[3] + '\n' +
                             "poly 5: " + pb3.timeToRun[4] + '\n' +
                             "poly 6: " + pb3.timeToRun[5]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
