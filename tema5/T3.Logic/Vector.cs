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
        private List<double> _items;

        //empty vector
        public Vector()
        {
            this._items = new List<double>();
        }

        //vector copy
        public Vector(Vector v)
        {
            Size = v.Size;
            this._items = new List<double>();
            foreach (double el in v._items)
            {
                this._items.Add(el);
            }
        }

        //generates a n, n-1, ..... 0
        public Vector(int n)
        {
            this.Size = n;
            _items = new List<double>();
            Generate_items();
        }
        
        public void InitWith(double value,int size)
        {
            this.Size = size;
            for(int i = 0; i < size; i++)
            {
                _items.Add(value);
            }
        }

        public void InitRandom(int size)
        {
            Size = size;
            Random r = new Random();
            for(int i = 0; i < Size; i++)
            {
                _items.Add(r.NextDouble() * 5);
            }

        }

        public void Normalize()
        {
            double norm = ComputeSelfNorm();

            for(int i = 0; i < Size; i++)
            {
                this[i] /= norm;
            }
        }

        // returns eigenvalue and leaves behind an eigenvector
        public double DivideByDominant()
        {
            double max = double.MinValue;
            foreach(var x in _items)
            {
                if (Math.Abs(x) > max) { max = Math.Abs(x); }
            }
            for(int i = 0; i < Size; i++) { this[i] /= max; }
            return max;
        }

        public void Add(double value)
        {
            this._items.Add(value);
        }

        public void Generate_items()
        {
            for (int i = 0; i < this.Size; i++)
            {
                _items.Add(this.Size - i);
            }
        }

        public string GetString()
        {
            List<string> result = new List<string>();

            foreach (var line in _items)
            {
                result.Add(string.Format("{0}", line));
            }

            result.Add("\n");
            return string.Join("\n", result);
        }

        public double this[int i]
        {
            get => this._items[i];
            set => this._items[i] = value;

        }

        public double ComputeNormAgainst(Vector vector)
        {
            double res = 0;

            for (int i = 0; i < this.Size; i++)
            {
                res += (this[i] - vector[i]) * (this[i] - vector[i]);
            }

            return Math.Sqrt(res);
        }

        public double ComputeSelfNorm()
        {
            double res = 0;

            foreach(var val in _items)
            {
                res += val * val;
            }

            return Math.Sqrt(res);
        }

        public static Vector operator *(Vector vec,double val)
        {
            Vector res = new Vector(vec);

            for(int i = 0; i < res.Size; i++)
            {
                res[i] = res[i] * val;
            }

            return res;
        }

        public List<double> GetItems()
        {
            return this._items;
        }
    }
}
 