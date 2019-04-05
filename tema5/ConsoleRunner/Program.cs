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
                var (eigenValue, eigenVector) = m.ComputeEigenPair(100);
                Console.WriteLine(eigenValue);

            }
        }
        
        public static void RunOwnTestCase()
        {
            SparseMatrix M = SparseMatrix.RandomSparseSymmetricalMatrix(10, 9);
            //Console.WriteLine(string.Format("{0}\n",M.GetString()));
            M.CheckSymmetricalMatrixRules();
            Console.WriteLine("Symmetrical matrix : {0} {1}", M.InvalidMatrix.valid, M.InvalidMatrix.message);

            var (eigenValue,eigenVector) = M.ComputeEigenPair(1000);

            Console.WriteLine(string.Format("Eigen Value : {0}", eigenValue));
            Console.WriteLine(eigenVector.GetString());
        }

        static void Main(string[] args)
        {
            //RunTestCases();
            RunOwnTestCase();
        }
    }
}
