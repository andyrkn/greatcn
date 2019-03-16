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
            SparseMatrix b = new SparseMatrix("../../../resources/b.txt");
            SparseMatrix sumResult = new SparseMatrix("../../../resources/aplusb.txt");
            if (a.InvalidMatrix.valid && b.InvalidMatrix.valid)
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText((a + b).GetString());
                originalSumResult.ResetText();
                originalSumResult.AppendText(sumResult.GetString());
            }
            else
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(a.InvalidMatrix.message);
                matrixSumOutput.AppendText(b.InvalidMatrix.message);
            }
        }
    }
}
