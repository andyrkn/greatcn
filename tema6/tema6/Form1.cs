using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T6.Logic;

namespace tema6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Poly poly;
        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            poly = new Poly();
            try
            {
                poly.ParsePoly(PolyInput.Text);

                poly.FindInterval();
                IntervalOutput.ResetText();
                IntervalOutput.Text = " [ " + poly.interval.Item1 + ", " + poly.interval.Item2 + " ]";

                poly.ComputeHalley();

                RootsOutput.ResetText();
                foreach (var r in poly.roots)
                {
                    RootsOutput.Text += r.Value.ToString() + '\n';
                }
            }
            catch
            {
                MessageBox.Show("Input is not valid!");
            }
        }

        private void Save(object sender, EventArgs e)
        {
            poly.WriteSolutionInFile(SavingInput.Text);
        }
    }
}
