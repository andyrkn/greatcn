using System;
using System.Windows.Forms;
using T3.Logic;

namespace T3
{
    public partial class Form1 : Form
    {
        SparseMatrix a = new SparseMatrix("../../../resources/a.txt");
        SparseMatrix b = new SparseMatrix("../../../resources/b.txt");
        SparseMatrix sumResult = new SparseMatrix("../../../resources/aplusb.txt");
        SparseMatrix multyResult = new SparseMatrix("../../../resources/aorib.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector sumResultB = new Vector(sumResult.Vector);
            Vector XVector = new Vector(sumResult.Size);

            if (a.InvalidMatrix.valid && b.InvalidMatrix.valid)
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText((a + b).GetString());
                originalSumResult.ResetText();
                originalSumResult.AppendText(sumResult.GetString());

                originalBOutput.ResetText();
                originalBOutput.AppendText(sumResultB.GetString());
                vectorBOutput.ResetText();

                Vector result = new Vector(sumResult * XVector);
                vectorBOutput.AppendText(result.GetString());
                NLabel.Text = "n =" + a.Size;
                XLabel.Text = "x =(" + a.Size + ", " + (a.Size - 1) + " ... , 2, 1)";  
            }
            else
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(a.InvalidMatrix.message);
                matrixSumOutput.AppendText(b.InvalidMatrix.message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector multyResultB = new Vector(multyResult.Vector);
            Vector XVector = new Vector(multyResult.Size);

            if (a.InvalidMatrix.valid && b.InvalidMatrix.valid)
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText((a * b).GetString());
                originalSumResult.ResetText();
                originalSumResult.AppendText(multyResult.GetString());

                originalBOutput.ResetText();
                originalBOutput.AppendText(multyResultB.GetString());
                vectorBOutput.ResetText();

                Vector result = new Vector(multyResult * XVector);
                vectorBOutput.AppendText(result.GetString());
                NLabel.Text = "n =" + a.Size;
                XLabel.Text = "x =(" + a.Size + ", " + (a.Size - 1) + " ... , 2, 1)";
            }
            else
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(a.InvalidMatrix.message);
                matrixSumOutput.AppendText(b.InvalidMatrix.message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vector aResultB = new Vector(a.Vector);
            Vector XVector = new Vector(a.Size);

            if (a.InvalidMatrix.valid)
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(a.GetString());
                originalSumResult.ResetText();
                originalSumResult.AppendText(a.GetString());

                originalBOutput.ResetText();
                originalBOutput.AppendText(aResultB.GetString());
                vectorBOutput.ResetText();

                Vector result = new Vector(a * XVector);
                vectorBOutput.AppendText(result.GetString());
                NLabel.Text = "n =" + a.Size;
                XLabel.Text = "x =(" + a.Size + ", " + (a.Size - 1) + " ... , 2, 1)";
            }
            else
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(a.InvalidMatrix.message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vector bResultB = new Vector(b.Vector);
            Vector XVector = new Vector(b.Size);

            if (b.InvalidMatrix.valid)
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(b.GetString());
                originalSumResult.ResetText();
                originalSumResult.AppendText(b.GetString());

                originalBOutput.ResetText();
                originalBOutput.AppendText(bResultB.GetString());
                vectorBOutput.ResetText();

                Vector result = new Vector(b * XVector);
                vectorBOutput.AppendText(result.GetString());
                NLabel.Text = "n =" + b.Size;
                XLabel.Text = "x =(" + b.Size + ", " + (b.Size - 1) + " ... , 2, 1)";
            }
            else
            {
                matrixSumOutput.ResetText();
                matrixSumOutput.AppendText(b.InvalidMatrix.message);
            }
        }
    }
}
