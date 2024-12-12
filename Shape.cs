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
        public float area;

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
