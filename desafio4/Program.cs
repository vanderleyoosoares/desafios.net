using System;
using System.Globalization;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int DN = 0;
            int Cont = 2;
            double N = 0;
            double[] Nota = new double[Cont];
            while(DN != 2)
            {

                N = double.Parse(Console.ReadLine());
                Nota[DN] = N;
                if(Nota[DN] < 0 || Nota[DN] > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else if(Nota[DN] >= 0 && Nota[DN] <=10.0)
                {
                    DN++;
                }
            }
            double media = 0;
            media = (Nota[0] + Nota[1]) / 2 ;
            Console.WriteLine("media = " + media.ToString("N2"));
        }
    }
}