using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            int R = Int32.Parse(Console.ReadLine());
            int V = Int32.Parse(Console.ReadLine());
            int somador = R;
            int G = R;
            while(R >= V)
            {
                V = Int32.Parse(Console.ReadLine());
            }
            while(R <= V)
            {
                somador++;
                R = G + somador;
                G = R;
                N++;
            }
            Console.WriteLine(N);
        }
    }
}