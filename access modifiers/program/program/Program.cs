using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class MyCar
    {
        public string model;
        public string color;
        public int price;
        public void car()
        {
            Console.WriteLine("Model : "+model);
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Price : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCar car = new MyCar();
            Console.Write("enter car model : ");
            car.model = Console.ReadLine();
            Console.Write("enter car color : ");
            car.color = Console.ReadLine();
            Console.Write("enter car price : ");
            car.price = Convert.ToInt32(Console.ReadLine());
            car.car();

            Console.ReadLine();
        }
    }
}
