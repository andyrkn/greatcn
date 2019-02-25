using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public class Problem3
    {
        private const double c1 = 0.16666666666666666666666666666667;
        private const double c2 = 0.00833333333333333333333333333333;
        private const double c3 = 1.984126984126984126984126984127e-4;
        private const double c4 = 2.7557319223985890652557319223986e-6;
        private const double c5 = 2.5052108385441718775052108385442e-8;
        private const double c6 = 1.6059043836821614599392377170155e-10;
        private const double min = -(Math.PI)/2;
        private const double max = Math.PI/2;
        public List<double> randomNumbers =  new List<double>();
        public List<string> timeToRun = new List<string>();
        // TODO:
        public List<string> bestPolynom = new List<string>();


        public Problem3()
        {
            for (int i = 0; i < 10000; i++)
            {
                randomNumbers.Add(GenerateRandom());
            }
            StartSolutionPoly1();
            StartSolutionPoly2();
            StartSolutionPoly3();
            StartSolutionPoly4();
            StartSolutionPoly5();
            StartSolutionPoly6();
        }

        public void StartSolutionPoly1()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom1(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }

        public void StartSolutionPoly2()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom2(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }

        public void StartSolutionPoly3()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom3(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }
        public void StartSolutionPoly4()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom4(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }
        public void StartSolutionPoly5()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom5(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }
        public void StartSolutionPoly6()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (double d in randomNumbers)
            {
                ResolvePolynom6(d);
            }
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds.ToString();
            timeToRun.Add(elapsed);
        }
        public double GetError(double x, double polyResult)
        {
            return Math.Abs(polyResult - Math.Sin(x));
        }

        public double ResolvePolynom1(double x)
        {
            double y = Math.Pow(x, 2);
            double p1 = x * (1 + y * ( -c1 + y * c2));
            return p1;
        }

        public double ResolvePolynom2(double x)
        {
            double y = Math.Pow(x, 2);
            double p2 = x * (1 + y * (-c1 + y * (c2 + y * (-c3))));
            return p2;
        }
        public double ResolvePolynom3(double x)
        {
            double y = Math.Pow(x, 2);
            double p3 = x * (1 + y * (-c1 + y * (c2 + y *(-c3 + y * c4))));
            return p3;
        }
        public double ResolvePolynom4(double x)
        {
            double y = Math.Pow(x, 2);
            double p4 = x * (1 + y * (-0.166 + y * (0.00833 + y * (-c3 + y * c4))));
            return p4;
        }
        public double ResolvePolynom5(double x)
        {
            double y = Math.Pow(x, 2);
            double p5 = x * (1 + y * (-c1 + y * (c2 + y * (-c3 + y * (c4 + y *(-c5))))));
            return p5;
        }
        public double ResolvePolynom6(double x)
        {
            double y = Math.Pow(x, 2);
            double p6 = x * (1 + y * (-c1 + y * (c2 + y * (-c3 + y * (c4 + y * (-c5 + y * c6))))));
            return p6;
        }

        public double GenerateRandom()
        {
            Random x = new Random();
            return x.NextDouble() * (max - min) + min;
        }
    }
}
