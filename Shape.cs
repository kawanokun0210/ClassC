using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    internal class Shape
    {
        //フィールド
        protected float area;

        public float Area()
        {
            return area;
        }

        public virtual void Draw()
        {
            Console.WriteLine("図形");
        }

    }
}
