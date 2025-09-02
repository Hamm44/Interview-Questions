using System.ComponentModel.DataAnnotations;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numbers number = new numbers(12, 13);
           
            Console.WriteLine(number.getArea());
            Console.WriteLine(number.getPerimeter());
        }
    }

    interface IShape
    {
        public decimal getArea();
        public decimal getPerimeter();

    }

    class numbers : IShape 
    {
        int Width { get; set; }
        int Lenght { get; set; }
        public numbers(int width, int lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        public decimal getArea() => Width * Lenght;
        public decimal getPerimeter() => Width + Lenght;
        

    }
}
