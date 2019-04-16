using System;
using System.Windows.Forms;
using T3.Logic;

namespace tema4
{
    public partial class Form1 : Form
    {

        SparseMatrix[] M;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] labels = { LabelM1, LabelM2, LabelM3, LabelM4, LabelM5 };

            M = new SparseMatrix[5];
            for (int i = 1; i < M.Length+1; i++)
            {
                M[i - 1] = new SparseMatrix("../../../resources/m_rar_2019_" + i + ".txt");
            }
            for(int i = 0;i<M.Length;i++)
            {
                M[i].CheckNotNullColumn();
                if (M[i].InvalidMatrix.valid)
                {
                    labels[i].ResetText();
                    labels[i].Text = "M" + i + " valid";
                }
                else
                {
                    labels[i].ResetText();
                    labels[i].Text = "M" + i + " invalid at " + M[i].InvalidMatrix.message;
                }
            }
        }

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            uint MaxIterations;
            uint.TryParse(MaxIterInput.Text, out MaxIterations);
            double omega = Double.Parse(omegaInput.Text);

            for (int i = 1; i <= 5; i++)
            {
                SparseMatrix M = new SparseMatrix("../../../resources/m_rar_2019_" + i + ".txt");
                var (vector, iterations) = M.Solve(omega, MaxIterations, M.Vector);



                //Console.WriteLine("-----File m_rar_2019_{0}.txt-----", i);
                //Console.WriteLine("||Ax - b||: {0}", M.ComputeNormAgainst(vector, M.Vector));
                //Console.WriteLine("SOR iterations: {0}\n", iterations);

            }
        }
    }
}
