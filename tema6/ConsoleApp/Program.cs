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
        private const string p1 = "x^3 - 53x^2 + 152x^1 - 100x^0"; // roots 1, 2, 50
        private const string p2 = "x^2 - 13x^1 + 40x^0"; //roots 5, 8
        private const string p3 = "x^5 - 15x^4 + 85x^3 - 225x^2 + 274x - 120"; //roots 1-5 
        private const string p4 = "x^6 - 33x^5 + 439x^4 - 3003x^3 + 11080x^2 - 20724x^1 + 15120x^0"; //2, 4, 6, 9, 5, 7

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
        }
    }
}
