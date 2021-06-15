using System;

namespace _4_teorema_divisao_euclidiana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

            q = a / b;
            r = a - b * q;
            if (r<0){
                r += Math.Abs(b);
                q = (a - r) /b;
            }
            Console.WriteLine("{0} {1}", q, r);
        }
    }
}
