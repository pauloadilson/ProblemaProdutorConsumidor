using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaPCSemaforoSinc
{
    class Program
    {
        const int tamanhoDoBuffer = 10;
        static int[] buffer = new int[tamanhoDoBuffer];
        static int valoresAProduzir = 20;

        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Program.produce));
            Thread c = new Thread(new ThreadStart(Program.consume));
            p.Start();
            c.Start();

            Console.ReadLine();
        }
        private static Semaphore estaCheio = new Semaphore(tamanhoDoBuffer, tamanhoDoBuffer);
        private static Semaphore estaVazio = new Semaphore(0, tamanhoDoBuffer);

        static void produce()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                estaCheio.WaitOne(); //down
                buffer[i % tamanhoDoBuffer] = i % 95;
                Console.WriteLine("Produzido: {0}", buffer[i % tamanhoDoBuffer]);
                estaVazio.Release(1); //up
            }
        }

        static void consume()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                estaVazio.WaitOne();
                int c = buffer[i % tamanhoDoBuffer];
                Console.WriteLine("                Consumido: {0}", c);
                estaCheio.Release(1);
            }
        }
    }
}
