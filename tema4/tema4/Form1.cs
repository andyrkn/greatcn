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
            TextBox[] Det = {DetM1Output, DetM2Output, DetM3Output, DetM4Output, DetM5Output};
            TextBox[] SOR = {SorM1Output, SorM2Output, SorM3Output, SorM4Output, SorM5Output};

            uint MaxIterations;
            uint.TryParse(MaxIterInput.Text, out MaxIterations);
            double omega = Double.Parse(omegaInput.Text);

            for (int i = 1; i <= 5; i++)
            {
                var (vector, iterations) = M[i - 1].Solve(omega, MaxIterations, M[i - 1].Vector);

                Det[i-1].Text = M[i - 1].ComputeNormAgainst(vector, M[i - 1].Vector).ToString();
                SOR[i-1].Text = iterations.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
