using System;
using System.Globalization;
//ajuda do colega Cleison Silva
namespace desafio1
{
    class desafio2
    {
        static void Main(string[] args)
        {   // varre 3 vezes 
            for(int teste = 0; teste < 3; teste++)
            {
                    // captura o numero de tartarugas
                    int NumeroTartaruga =  Int32.Parse(Console.ReadLine());
                    // captura as velocidades das tartarugas
                    string[] total = Console.ReadLine().Split(" ");
                    int Vi = 0;
                    // lista a tartaruga mais veloz
                    for(int indiceT = 0; indiceT < NumeroTartaruga; indiceT++ )
                    {
                      string v = total[indiceT].ToString();
                      int velocidade = Convert.ToInt32(v);

                    if(velocidade > Vi)
                    {
                        Vi = velocidade;
                    }
                    }

                    //Informa o Nível da tartaruga mais rapida de acordo com a velocidade 
                    if (Vi < 10)
                    {
                        Console.WriteLine(1);
                    }
                    else if (Vi >= 10 && Vi < 20)
                    {
                        Console.WriteLine(2);
                    }
                    else if (Vi >= 20 && Vi <51)
                    {
                        Console.WriteLine(3);
                    }

            }
        }
    }
}