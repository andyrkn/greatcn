﻿using System;
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


        public List<double> randomNumbers = new List<double>();
        public List<KeyValuePair<int,long>> timeToRun = new List<KeyValuePair<int, long>>();
        public List<KeyValuePair<string,double>> bestPolynom = new List<KeyValuePair<string, double>>();

        public Problem3()
        {
            GenerateRandomNumbers();
  
            var res = Solve();
            for (int i = 1; i < res.Length; i++)
            {
                var polyName = "Polynom " + i;
                bestPolynom.Add(new KeyValuePair<string, double>(polyName, res[i]));
            }
            bestPolynom.Sort((x, y) => x.Value.CompareTo(y.Value));
        }

        private double GetError(double x, double polyResult)
        {
            return Math.Abs(polyResult - Math.Sin(x));
        }

        private double[] Solve()
        {
            double[] averagePositions = new double[7];
            long[] polynomTicks = new long[7];

            for (int i = 0; i < 7; i++)
            {
                averagePositions[i] = 0;
            }

            for (int j = 0; j < randomNumbers.Count; j++)
            {
                double number = randomNumbers[j];

                List<KeyValuePair<int, double>> errors = new List<KeyValuePair<int, double>>();

                for (int i = 1; i <= 6; i++)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    errors.Add(new KeyValuePair<int, double>(i, calculatePolynom(i, number)));
                    watch.Stop();
                    polynomTicks[i] += watch.ElapsedTicks;
                }

                errors.Sort((x,y) => x.Value.CompareTo(y.Value));

                for (int i = 0; i < errors.Count; i++)
                {
                    averagePositions[errors[i].Key] = 
                        ((i + 1) - averagePositions[errors[i].Key]) / (j + 1) + averagePositions[errors[i].Key];
                }
            }

            for(int i = 1; i < polynomTicks.Length; i++)
            {
                timeToRun.Add(new KeyValuePair<int, long>(i, polynomTicks[i]));
            }
            timeToRun.Sort((x, y) => x.Value.CompareTo(y.Value));
      
            return averagePositions;
        }

        private double calculatePolynom(int poly, double x)
        {
            double polyValue = 0;
            double error = double.MaxValue;

            if (poly == 1)
            {
                polyValue = ResolvePolynom1(x);
            }
            if (poly == 2)
            {
                polyValue = ResolvePolynom1(x);
            }
            if (poly == 3)
            {
                polyValue = ResolvePolynom3(x);
            }
            if (poly == 4)
            {
                polyValue = ResolvePolynom4(x);
            }
            if (poly == 5)
            {
                polyValue = ResolvePolynom5(x);
            }
            if (poly == 6)
            {
                polyValue = ResolvePolynom6(x);
            }

            error = GetError(x, polyValue);
            return error;
        }

        private double ResolvePolynom1(double x)
        {
            double y = Math.Pow(x, 2);
            double p1 = x * (1 + y * (-c1 + y * c2));
            return p1;
        }

        private double ResolvePolynom2(double x)
        {
            double y = Math.Pow(x, 2);
            double p2 = x * (1 + y * (-c1 + y * (c2 + y * (-c3))));
            return p2;
        }
        private double ResolvePolynom3(double x)
        {
            double y = Math.Pow(x, 2);
            double p3 = x * (1 + y * (-c1 + y * (c2 + y * (-c3 + y * c4))));
            return p3;
        }
        private double ResolvePolynom4(double x)
        {
            double y = Math.Pow(x, 2);
            double p4 = x * (1 + y * (-0.166 + y * (0.00833 + y * (-c3 + y * c4))));
            return p4;
        }
        private double ResolvePolynom5(double x)
        {
            double y = Math.Pow(x, 2);
            double p5 = x * (1 + y * (-c1 + y * (c2 + y * (-c3 + y * (c4 + y * (-c5))))));
            return p5;
        }
        private double ResolvePolynom6(double x)
        {
            double y = Math.Pow(x, 2);
            double p6 = x * (1 + y * (-c1 + y * (c2 + y * (-c3 + y * (c4 + y * (-c5 + y * c6))))));
            return p6;
        }

        public void GenerateRandomNumbers()
        {

            double min = -(Math.PI) / 2;
            double max = Math.PI / 2;

            Random x = new Random();

            for (int i = 0; i < 100000; i++)
            {
                randomNumbers.Add(x.NextDouble() * (max - min) + min);
            }
        }

    }
}
