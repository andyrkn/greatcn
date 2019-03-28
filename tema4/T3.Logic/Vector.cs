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
        public List<double> _items { get; private set; }

        public Vector()
        {
            this._items = new List<double>();
        }

        public Vector(Vector v)
        {
            Size = v.Size;
            this._items = new List<double>();
            foreach (double el in v._items)
            {
                this._items.Add(el);
            }
        }

        public Vector(int n)
        {
            this.Size = n;
            Generate_items();
        }

        public void Add(double value)
        {
            this._items.Add(value);
        }

        public void Generate_items()
        {
            _items = new List<double>();
            for (int i = 0; i < this.Size; i++)
            {
                _items.Add(this.Size - i);
            }
        }

        public string GetString()
        {
            List<string> result = new List<string>();

            result.Add("" + this._items.Count);
            result.Add("\n");

            foreach (var line in _items)
            {
                result.Add(String.Format("{0}", line));
            }
            return String.Join("\n", result);
        }
    }
}
