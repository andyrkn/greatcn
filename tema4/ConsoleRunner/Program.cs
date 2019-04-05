using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3.Logic;

namespace ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            const uint MaxIterations = 500;
            const double omega = 0.8;

            for (int i = 1; i <= 5; i++)
            {
                SparseMatrix M = new SparseMatrix("../../../resources/m_rar_2019_" + i + ".txt");
                var (vector, iterations) = M.Solve(omega, MaxIterations, M.Vector);

                Console.WriteLine("-----File m_rar_2019_{0}.txt-----", i);
                Console.WriteLine("||Ax - b||: {0}", M.ComputeNormAgainst(vector, M.Vector));
                Console.WriteLine("SOR iterations: {0}\n", iterations);
            }
        }
    }
}
