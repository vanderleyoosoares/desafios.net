using System;

namespace desafio1
{
    internal class desafio
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            if(1 < n || n < 1000)
            {
                for(var a = 1; a <= n; a++)
                {
                    int x = a; int s; int t;
                    s = x * x; t = s * x;
                    Console.WriteLine(x+" " + s +" " + t);
                }
            }
        }
    }
}
