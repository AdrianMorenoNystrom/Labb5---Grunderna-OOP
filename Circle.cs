using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB5
{
    public class Circle
    {
        float _pi = 3.141f;
        int _Radius = 0;

        public Circle(int radius)
        {
            _Radius = radius;
        }
        public float getArea()
        {
            float area = _Radius * _Radius * _pi;
            Console.WriteLine($"Arean för cirkel med {_Radius} i radie är: {area}");
            return area;

        }
    }
}
