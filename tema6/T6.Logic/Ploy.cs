using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Symbolics;

namespace T6.Logic
{
    public class Poly
    {
        //                       power , coeff
        private List<KeyValuePair<int, long>> coefficients;

        public List<KeyValuePair<int, long>> Coefficients
        {
            get { return coefficients; }
        }

        private List<KeyValuePair<int, long>> roots;
        private Tuple<long, long> interval;
        private string poly;
        private int n;
        private double epsilon;


        public Poly()
        {
            epsilon = ComputeMachinePrecision();
            coefficients = new List<KeyValuePair<int, long>>();

        }

        public string[] ParsePoly(string poly)
        {
            var items = poly.Split().ToArray();
            coefficients.Clear();

            foreach (var i in items)
            {
                if (i.Contains("^"))
                {
                    var subItems = i.Split('x');
                    string power = subItems[1].Split('^')[1] != "" ? subItems[1].Split('^')[1] : "1";
                    string coeff = subItems[0] != "" ? subItems[0] : "1" ;
                    coefficients.Add(new KeyValuePair<int, long> (int.Parse(power), long.Parse(coeff)));
                }
            }
            return items;
        }

        public void FindInterval()
        {

        }

        public void ComputeHalley()
        {

        }

        public void ComputeHorner()
        {

        }

        public void ValidateRoots()
        {

        }

        public void WriteSolutionInFile(string fileName)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"../../../ resources /" + fileName + ".txt", true))
            {
                file.WriteLine("Polinomial: " + poly + "\n");

                foreach (var r in roots)
                {
                    file.WriteLine(r);
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
