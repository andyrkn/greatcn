using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T6.Logic;

namespace ConsoleApp
{
    class Program
    {
        // POly generator
        // https://solvemymath.com/online_math_calculator/algebra_combinatorics/polynomial_calculator/polynomial_generate_from_roots.php
        private const string p1 = "x^3 -53x^2 +152x^1 -100x^0"; // roots 1, 2, 50
        private const string p2 = "x^2 -13x^1 +40x^0"; //roots 5, 8
        static void Main(string[] args)
        {
            TestParsePoly(p2);
            Console.ReadKey();
        }

        public static void TestParsePoly(string p)
        {
            Poly poly = new Poly(); 
            poly.ParsePoly(p);
            Console.WriteLine("Test ParsePoly");
            foreach (var c in poly.Coefficients)
            {
                Console.WriteLine(c.Value + " :: x^" + c.Key);
            }

            poly.FindInterval();
            for (int i = 0; i < 500; i++)
            {
                poly.ComputeHalley();
            }

            foreach (var x in poly.roots)
            {
                System.Console.WriteLine(x.Value);
            }

            //Test write in file 
            //poly.WriteSolutionInFile("test1");
        }
    }
}
