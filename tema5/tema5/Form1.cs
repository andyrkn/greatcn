using System;
using System.Collections.Generic;
using System.Windows.Forms;
using T3.Logic;
using CenterSpace.NMath.Core;

namespace tema5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadOfficialTestCases_Click(object sender, EventArgs e)
        {
            List<RichTextBox> textBoxes = new List<RichTextBox> { EnemyTestCase1, EnemyTestCase2, EnemyTestCase3, EnemyTestCase4 };
            textBoxes.ForEach(box => box.ResetText());

            const string name = "../../../resources/m_rar_sim_2019_";
            string[] files = { name + "500.txt", name + "1000.txt", name + "1500.txt", name + "2019.txt" };
            SparseMatrix[] M = new SparseMatrix[4];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = new SparseMatrix(files[i]);
            }

            for (int i = 0; i < M.Length; i++)
            {
                M[i].CheckSymmetricalMatrixRules();
                textBoxes[i].AppendText(string.Format("{0} {1} \n\n", M[i].InvalidMatrix.valid, M[i].InvalidMatrix.message));

                var (eigenValue, eigenVector) = M[i].ComputeEigenPair(100);

                textBoxes[i].AppendText(string.Format("Eigen Value : {0} \n\n", eigenValue));
                textBoxes[i].AppendText("\n");
                textBoxes[i].AppendText(eigenVector.GetString());
                textBoxes[i].AppendText("\n");
            }
        }

        private void LoadOwnTestCaseButton_Click(object sender, EventArgs e)
        {
            OwnTestCase.ResetText();

            SparseMatrix M = SparseMatrix.RandomSparseSymmetricalMatrix(10, 9);
            M.CheckSymmetricalMatrixRules();
            OwnTestCase.AppendText(string.Format("Symmetrical matrix : {0} {1}\n\n", M.InvalidMatrix.valid, M.InvalidMatrix.message));

            var (eigenValue, eigenVector) = M.ComputeEigenPair(1000);

            OwnTestCase.AppendText(string.Format("Eigen Value : {0} \n\n", eigenValue));
            OwnTestCase.AppendText(eigenVector.GetString());
            OwnTestCase.AppendText("\n");
        }

        private void DenseMatrixCase_Click(object sender, EventArgs e)
        {
            List<RichTextBox> textBoxes = new List<RichTextBox> { EnemyTestCase1, EnemyTestCase2, EnemyTestCase3, EnemyTestCase4 };
            List<RichTextBox> PMItextBoxes = new List<RichTextBox> { PMISVD1, PMISVD2, PMISVD3, PMISVD4 };
            textBoxes.ForEach(box => box.ResetText());
            PMItextBoxes.ForEach(box => box.ResetText());

            const string name = "../../../resources/m_rar_sim_2019_";
            string[] files = { name + "500.txt", name + "1000.txt", name + "1500.txt", name + "2019.txt" };
            DenseMatrix[] M = new DenseMatrix[4];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = new DenseMatrix(files[i]);
            }


            for (int i = 0; i < M.Length; i++)
            {
                var decomp = M[i].SVDecomp();
                var singularValues = decomp.SingularValues;

                // alternative
                // var rangFromSVs = DenseMatrix.Rank(singularValues);
                var rankFromSV = M[i].Rank();
                var rankFromLib = decomp.Rank;
                // alternative
                // var conditionalNumber = DenseMatrix.ConditionalNumber(singularValues);
                var conditionalNumber = M[i].ConditionalNumberFromSV();
                var libraryConditionalNumber = M[i].LibaryConditinalNumber();

                //Console.WriteLine(singularValues);
                textBoxes[i].AppendText(string.Format("Matrix Rank: {0}\n\n", rankFromSV));
                textBoxes[i].AppendText(string.Format("Matrix Rank From Library: {0}\n\n", rankFromLib));
                textBoxes[i].AppendText(string.Format("Conditional Number: {0}\n\n", conditionalNumber));
                textBoxes[i].AppendText(string.Format("Conditional Number From Library: {0}\n\n", libraryConditionalNumber));
                //Singular Values Vector
                //Console.WriteLine(singularValues);

                //PseudoMooreInverse
                var PMI = M[i].PseudoMooreInverse();
                var v = new DoubleVector(new Vector(M[i].Size).GetItems().ToArray());

                // var xI = NMathFunctions.Product(PMI, v);
                // var xRes = NMathFunctions.Solve(PMI, v);
                // Console.WriteLine(NMathFunctions.Product(PMI, xRes));

                var xREs = M[i].Solve(v);
                var norm = M[i].ComputeNormAgainst(v, xREs);
                textBoxes[i].AppendText(string.Format("Ax - b Norm : {0} \n\n", norm));

                PMItextBoxes[i].AppendText(string.Format("{0} \n\n", PMI.ToString()));
                PMItextBoxes[i].AppendText(string.Format("{0} \n\n", singularValues.ToString()));
            }
        }
    }
}
