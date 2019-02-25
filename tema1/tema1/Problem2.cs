using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public class Problem2
    {
        public Boolean checkSumAssociativity(double x, double y, double z)
        {
            if ((x + y) + z == x + (y + z))
            {
                return true;
            }
            return false;
        }

        public Boolean checkMultiplicityAssociativity(double x, double y, double z)
        {
            if((x * y) * z == x * (y * z))
            {
                return true;
            }
            return false;
        }

    }
}
