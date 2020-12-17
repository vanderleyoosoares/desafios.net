using System;
using System.Linq;
using System.Collections.Generic;

namespace desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            var J = new List<string>();
            while(true)
            {
                string joia = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(joia))
                    J.Add(joia);
                else
                {
                    break;
                }
            }
            var njoias = J.Distinct().ToList();
            Console.WriteLine(njoias.Count);
        }
    }
}