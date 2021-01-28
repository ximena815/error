using System;

namespace RetoTutoria1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de la variable X1
            Console.WriteLine("Ingrese X1: ");
            double x1 = double.Parse(Console.ReadLine());

            // Entrada de la variable X2
            Console.WriteLine("Ingrese X2: ");
            double x2 = double.Parse(Console.ReadLine());

            // Entrada de la variable Y1
            Console.WriteLine("Ingrese Y1: ");
            double y1 = double.Parse(Console.ReadLine());

            // Entrada de la variable Y2
            Console.WriteLine("Ingrese Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // Variable m
            double m = (y2 - y1) / (x2 - x1); //Formula
            Console.WriteLine("Ingrese m: " + m);

            //Variable b
            double b = y1 - (m * x1);
            Console.WriteLine("Ingrese b: " + b);

            //Variable b
            double d = Math.Sqrt (((x2-x1)* (x2 - x1))+((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Ingrese d: " + d);

        }
    }
}
