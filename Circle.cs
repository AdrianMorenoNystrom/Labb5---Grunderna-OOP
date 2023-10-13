using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB5
{
    public class Circle
    {
        //Fält-Variabler. här sätter jag _pi till 3.141 och _Radius till 0, radius kommer att ändras senare.
        float _pi = 3.141f;
        int _Radius = 0;

        //Konstruktor med Radius
        public Circle(int radius)
        {
            _Radius = radius;
        }

        //Metod som skapar variabeln area och räknar ut arean.
        //samt skriver ut svaret i konsolen och retunerar area.
        public float getArea()
        {
            float area = _Radius * _Radius * _pi;
            Console.WriteLine($"Arean för cirkel med {_Radius} i radie är: {area}");
            return area;

        }
    }
}
