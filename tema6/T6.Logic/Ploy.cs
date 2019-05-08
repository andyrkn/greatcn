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
        private Dictionary<int, double> coefficients;
        public Dictionary<int, double> Coefficients
        {
            get { return coefficients; }
        }
        public Dictionary<int, double> roots;
        public Tuple<double, double> interval;
        public string poly;
        public int degree;
        public double epsilon = 1E-10;

        public Poly()
        {
            //epsilon = ComputeMachinePrecision();
            coefficients = new Dictionary<int, double>();
            roots = new Dictionary<int, double>();
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
                    coefficients.Add(int.Parse(power), double.Parse(coeff));
                }
            }

            degree = coefficients.Aggregate((l, r) => l.Key > r.Key ? l : r).Key;
        }

        public void FindInterval()
        {
            double A = coefficients.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            double a0 = coefficients.First().Value;
            double R = (Math.Abs(a0) + A)/Math.Abs(a0);

            interval = Tuple.Create(-R, R);
            //Console.WriteLine(" [" + interval.Item1 + " , " + interval.Item2 + "]");
        }

        private double GetRandom()
        {
            Random random = new Random();
            return random.NextDouble() * (interval.Item2 - interval.Item1) + interval.Item1;
        }

        public double ComputeHalley()
        {
            double x0 = GetRandom();
            double x = GetRandom();
            int k = 1;
            double fd = ComputeHorner(ComputeDerivative(coefficients), x);
            double sd = ComputeHorner(ComputeDerivative(ComputeDerivative(coefficients)), x);
            double xk = ComputeHorner(coefficients, x0);
            double delta = 0;
            do
            {
                //Console.WriteLine(k);
                double A = 2 * ((double)Math.Pow(fd, 2)) - xk * sd;
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
            {

                //System.Console.WriteLine(x);
                if (ValidateRoots(x))
                {
                    //System.Console.WriteLine(x);
                    roots.Add(roots.Count, x);
                }
                return x;
            }
            else
            {
                return ComputeHalley();
            }
        }

        public Dictionary<int, double> ComputeDerivative(Dictionary<int, double> p)
        {
            Dictionary<int, double> derivative = new Dictionary<int, double>();
            foreach (var c in p)
            {
                if(c.Key != 0)
                    derivative.Add(c.Key-1, (c.Value * c.Key));
            }

            return derivative;
        }

        public double ComputeHorner(Dictionary<int, double> polyDictionary, double x)
        {
            double result = 0;
            foreach (var p in polyDictionary)
            {
                result += p.Value;
                result *= x;
            }

            return result;
        }

        public bool ValidateRoots(double x)
        {
            foreach (var r in roots)
            {
                if (Math.Abs(x - r.Value) < 0.1)
                    return false;
            }

            return true;
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
