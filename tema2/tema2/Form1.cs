using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tema2.logic;

namespace tema2
{
    public partial class Form1 : Form
    {
        RezolvareT2 rt2;
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseMatrix()
        {
            string Ustr = "";
            string Lstr = "";
            string spc = "    ";
            for (int i = 0; i < rt2.N; i++)
            {
                for (int j = 0; j < rt2.N; j++)
                {
                    if (j <= i)
                    {
                        Lstr += rt2.A[i, j] + spc;
                        if (j == i)
                            Ustr += "1" + spc;
                        else
                            Ustr += "0" + spc;
                    }
                    else
                    {
                        Lstr += "0" + spc;
                        Ustr += rt2.A[i, j] + spc;
                    }
                }
                Lstr += "\n";
                Ustr += "\n";
            }
            LMatrixText.AppendText(Lstr);
            UMatrixText.AppendText(Ustr);
        }

        private void matrixCreate_Click(object sender, EventArgs e)
        {
            int n = (int)nInput.Value;
            int precizie = (int)eInput.Value;
            string[] matrix = matrixEntry.Text.Replace("\n", " ").Split(' ');
            rt2 = new RezolvareT2(n, precizie);

            for (int i = 0; i < matrix.Length; i++)
            {
                var val = double.Parse(matrix[i]); ;
                rt2.Ainit[i / n, i % n] = val;
                rt2.A[i / n, i % n] = val;
            }

            rt2.Decompose();
            if (rt2.Decomposable)
            {
                ParseMatrix();
                DeterminantResultLabel.Text = "Δ = " + rt2.Determinant();
            }
            else
            {
                DeterminantResultLabel.Text = "Not a LU matrix/Division by 0";
            }
        }

        private void ComputeAxB_Click(object sender, EventArgs e)
        {
            string[] vectorstring = BVectorInput.Text.Split(' ');
            double[] vectordouble = new double[rt2.N];
            for(int i = 0; i < rt2.N; i++)
            {
                vectordouble[i] = double.Parse(vectorstring[i]);
            }
            rt2.ComputeAxB(vectordouble);
            if (!rt2.DivisionByZeroInSystem)
            {
                string res = "";
                foreach (double d in rt2.ComputeAxB(vectordouble))
                {
                    res += d + " ";
                }
                XVectorResult.AppendText(res);
            }
            else
            {
                XVectorResult.AppendText("Division by 0");
            }
        }

        private void ComputeECNorm_Click(object sender, EventArgs e)
        {
            double res = rt2.EuclideanNorm();
            ECNormOutput.AppendText(res + "");
        }
    }
}