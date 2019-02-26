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
            var resString = "";

            foreach(KeyValuePair<string,double> element in pb3.bestPolynom)
            {
                resString = resString + element.Key + " : " + element.Value + "\n";
            }
            
            long freq = System.Diagnostics.Stopwatch.Frequency;
            resString = resString + "\n\n\n\n";
            foreach (KeyValuePair<int, long> timer in pb3.timeToRun)
            {
                resString = resString + "Polynom " + timer.Key + " : " + (double)timer.Value / freq * 1000.0 + " ms\n";
                //resString = resString + "Polynom " + timer.Key + ":" + timer.Value + "\n";
            }

            MessageBox.Show(resString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
