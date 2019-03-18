using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.Logic
{
    public class Vector
    {
        public int Size { get; private set; }
        public List<double> XVector { get; private set; }

        public Vector(List<double> v)
        {
            this.XVector = v;
            Size = v.Count;
        }

        public Vector(int n)
        {
            this.Size = n;
            GenerateXVector();
        }

        public void GenerateXVector()
        {
            XVector = new List<double>();
            for (int i = 0; i < this.Size; i++)
            {
                XVector.Add(this.Size - i);
            }
        }

        public string GetString()
        {
            List<string> result = new List<string>();

            result.Add("" + this.Size);
            result.Add("\n");

            foreach (var line in XVector)
            {
                result.Add(String.Format("{0}", line));
            }
            return String.Join("\n", result);
        }
    }
}
