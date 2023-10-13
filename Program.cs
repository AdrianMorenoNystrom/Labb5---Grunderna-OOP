namespace LABB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här skapar jag 2 nya instanser av Circle som jag döper till circle1 och circle2. 
            //konstruktorn tar 5 och 6 som argument och sparar sifforna till uträkningen.
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            //Här används metoden där uträkningen sker samt utskrift. Med argumenten som skickades med när jag skapade instanserna.
            circle1.getArea();
            circle2.getArea();
        }
    }
}