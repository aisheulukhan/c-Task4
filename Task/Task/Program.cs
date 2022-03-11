using System;

namespace Task.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car(4, 60);
            c1.About();
            c1.model = "BMW";
            Console.WriteLine(c1.model);
            bus b1 = new bus(4000, 60);
            b1.Getspeed();
        }
    }
}
