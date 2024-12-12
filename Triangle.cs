using ShapeTest;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTest
{
    internal class Triangle : Shape
    {
        //フィールド
        private float width;
        private float height;

        public Triangle(float width, float height)
        {
            this.width = width;
            this.height = height;

            area = width * height / 2;

        }

        public override void Draw()
        {
            Console.WriteLine("△");
        }

    }
}
