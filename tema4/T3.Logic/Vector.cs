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
