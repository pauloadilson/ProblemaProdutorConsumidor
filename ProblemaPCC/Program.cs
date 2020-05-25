using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaPCC
{
    class Program
    {

        const int tamanhoDoBuffer = 10;
        static int[] buffer = new int[tamanhoDoBuffer];
        static int valoresAProduzir = 20;

        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Program.produzir));
            Thread c = new Thread(new ThreadStart(Program.consumir));
            p.Start();
            c.Start();

            Console.ReadLine();
        }

        static void produzir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                buffer[i % tamanhoDoBuffer] = i % 95;
                Console.WriteLine("Produzido: {0}", buffer[i % tamanhoDoBuffer]);
            }
        }

        static void consumir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                int c = buffer[i % tamanhoDoBuffer];
                Console.WriteLine("                Consumido: {0}", c);
            }
        }

    }
}