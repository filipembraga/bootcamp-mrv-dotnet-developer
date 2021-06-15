using System;


namespace _2_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if((Math.Abs(b - c) < a && a < b + c) && 
                (Math.Abs(a - c) < b && b < a + c ) && 
                (Math.Abs(b - a) < c && c < b + a   ))
            {
                Console.WriteLine("Perimetro = {0:0.0}", a + b + c);
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}", ((a + b) * c) / 2);
            }
        }
    }
}
