namespace LABB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            circle1.getArea();
            Circle circle2 = new Circle(6);
            circle2.getArea();
        }
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
}