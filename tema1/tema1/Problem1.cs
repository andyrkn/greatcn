using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public class Problem1
    {
        public List<double> returnMachinePrecision()
        {
            double u = 1.0;
            int m = 0;
            List<double> values = new List<double>(); 
            while (1.0 + u != 1.0)
            {
                u /= 10;
                m++;
            }

            values.Add(u*10);
            values.Add(m - 1);
            return values;
        }
    }
}
