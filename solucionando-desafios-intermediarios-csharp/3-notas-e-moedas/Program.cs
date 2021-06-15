using System;

namespace _3_notas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int auxNotas, auxMoedas;            
            valor = Convert.ToDouble(Console.ReadLine());

            auxNotas = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;
            int[] notas = {100,50,20,10,5,2}; 
            int[] moedas = {50,25,10,05,01};
            String[] rotuloMoedas = {"0.50","0.25","0.10","0.05","0.01"};

            Console.WriteLine("NOTAS:");
            for(int x=0; x<6; x++){
                Console.WriteLine("{0} nota(s) de R$ {1}.00", auxNotas/notas[x], notas[x]);
                auxNotas = (auxNotas % notas[x]);
            }
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;
            for(int x=0; x<5; x++){
                Console.WriteLine("{0} moeda(s) de R$ {1}", auxMoedas/moedas[x], rotuloMoedas[x]);
                auxMoedas = (auxMoedas % moedas[x]);
            }
            
            
            //complete o codigo
        }
    }
}
