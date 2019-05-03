using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Complex;
using MathNet.Numerics.Random;
using MathNet.Symbolics;

namespace T6.Logic
{
    public class Poly
    {
        //                       power , coeff
        private Dictionary<int, long> coefficients;
        public Dictionary<int, long> Coefficients
        {
            get { return coefficients; }
        }

        private Dictionary<int, long> roots;
        private Tuple<long, long> interval;
        private string poly;
        private int degree;
        private double epsilon = 1E-8;


        public Poly()
        {
            //epsilon = ComputeMachinePrecision();
            coefficients = new Dictionary<int, long>();
        }

        public void ParsePoly(string poly)
        {
            this.poly = poly;
            var items = poly.Split().ToArray();
            coefficients.Clear();

            foreach (var i in items)
            {
                if (i.Contains("^"))
                {
                    var subItems = i.Split('x');
                    string power = subItems[1].Split('^')[1] != "" ? subItems[1].Split('^')[1] : "1";
                    string coeff = subItems[0] != "" ? subItems[0] : "1" ;
                    coefficients.Add(int.Parse(power), long.Parse(coeff));
                }
            }

            degree = coefficients.Aggregate((l, r) => l.Key > r.Key ? l : r).Key;
        }

        public void FindInterval()
        {
            long A = coefficients.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            long a0 = coefficients.First().Value;
            long R = (Math.Abs(a0) + A)/Math.Abs(a0);

            interval = Tuple.Create(-R, R);
            Console.WriteLine(" [" + interval.Item1 + " , " + interval.Item2 + "]");
        }

        private long GetRandom()
        {
            Random random = new Random();
            return random.Next((int)interval.Item1, (int)interval.Item2);
        }

        public long ComputeHalley()
        {
            long x0 = GetRandom();
            long x = GetRandom();
            int k = 1;
            long fd = ComputeHorner(ComputeDerivative(coefficients), x);
            long sd = ComputeHorner(ComputeDerivative(ComputeDerivative(coefficients)), x);
            long xk = ComputeHorner(coefficients, x0);
            long delta = 0;
            do
            {
                //Console.WriteLine(k);
                long A = 2 * ((long)Math.Pow(fd, 2)) - xk * sd;
                if (Math.Abs(A) > epsilon || A != 0)
                {
                    delta = (ComputeHorner(coefficients, x) * ComputeHorner(ComputeDerivative(coefficients), x)) / A;
                    x = x - delta;
                    k++;
                }
                else
                {
                    break;
                }
            } while (Math.Abs(delta) >= epsilon && k <= 30000 && Math.Abs(delta) <= Math.Pow(10, 8));

            if (Math.Abs(delta) < epsilon)
                return x;
            else
            {
                return ComputeHalley();
            }
        }

        public Dictionary<int, long> ComputeDerivative(Dictionary<int, long> p)
        {
            Dictionary<int, long> derivative = new Dictionary<int, long>();

            foreach (var c in p)
            {
                if(c.Key != 0)
                    derivative.Add(c.Key-1, (c.Value * c.Key));
            }

            //foreach (var d in derivative)
            //{
            //    Console.WriteLine(d.Key + " :: " + d.Value);
            //}
            return derivative;
        }

        public long ComputeHorner(Dictionary<int, long> polyDictionary, long x)
        {
            long result = 0;
            foreach (var p in polyDictionary)
            {
                result += p.Value * x;
            }

            //for (int i = 1; i < (p.Count - 1); i++)
            //{
            //    result += p[i];
            //    result *= x;
            //}
            //result += p[p.Count - 1];

            return result;
        }

        public void ValidateRoots()
        {

        }

        public void WriteSolutionInFile(string fileName)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"../../../resources /" + fileName + ".txt", true))
            {
                file.WriteLine("Polinomial: " + poly + "\n");

                foreach (var c in coefficients)
                {
                    file.WriteLine(c.Key + " :: " + c.Value);
                }
            }
        }

        private double ComputeMachinePrecision()
        {
            double u = 1.0;
            while (1.0 + u != 1.0)
            {
                u /= 10;
            }
            return u;
        }
    }
}
