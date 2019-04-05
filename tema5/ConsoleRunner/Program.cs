using T3.Logic;
using System;

namespace ConsoleRunner
{
    class Program
    {
        public static void RunTestCases()
        {
            const string name = "../../../resources/m_rar_sim_2019_";
            string[] files = { name + "500.txt", name + "1000.txt", name + "1500.txt", name + "2019.txt" };
            SparseMatrix[] M = new SparseMatrix[4];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = new SparseMatrix(files[i]);
            }

            foreach (var m in M)
            {
                m.CheckSymmetricalMatrixRules();
                Console.WriteLine("{0} {1}", m.InvalidMatrix.valid, m.InvalidMatrix.message);
            }
        }

        public static void RunOwnTestCase()
        {
            SparseMatrix M = SparseMatrix.RandomSparseSymmetricalMatrix(5, 2);
            Console.WriteLine(string.Format("{0}\n",M.GetString()));
            M.CheckSymmetricalMatrixRules();
            Console.WriteLine("Symmetrical matrix : {0} {1}", M.InvalidMatrix.valid, M.InvalidMatrix.message);

            SparseMatrix M0 = SparseMatrix.CopySparseMatrix(M);
            Vector randomVec = new Vector();
            randomVec.InitRandom(M.Size);
            randomVec.Normalize();

            /*
            for(int i = 0; i < 10; i++)
            {
                M = M * M;
                Vector bound = M * randomVec;
                Vector possibleSolution = bound * (1/(bound.ComputeSelfNorm()));
                
                // TODO write vector product
                Console.WriteLine(M0.ComputeNormAgainst(possibleSolution, randomVec * possibleSolution));
            }
            */
        }

        static void Main(string[] args)
        {
            RunOwnTestCase();
        }
    }
}
