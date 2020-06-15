using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace ProblemaPCConsole
{
    class Program
    {
        const int tamanhoDoBuffer = 5;
        static int[] buffer = new int[tamanhoDoBuffer];
        static int valoresAProduzir = 20;

        private static Semaphore Vazio = new Semaphore(tamanhoDoBuffer, tamanhoDoBuffer);
        private static Semaphore Cheio = new Semaphore(0, tamanhoDoBuffer);
        private static Semaphore mutex = new Semaphore(1, 1);

        static void produzir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                Vazio.WaitOne();
                mutex.WaitOne();
                buffer[i % tamanhoDoBuffer] =  i % 95;
                Console.WriteLine("Produzido: {0}", buffer[i % tamanhoDoBuffer]+1);
                mutex.Release(1);
                Cheio.Release(1);
            }
        }

        static void consumir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                Cheio.WaitOne();
                mutex.WaitOne();
                int c = buffer[i % tamanhoDoBuffer];
                Console.WriteLine("                Consumido: {0}", c+1);
                mutex.Release(1);
                Vazio.Release(1);
                if (i % 2 > 0) Thread.Sleep(2000);
            }
        }
        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Program.produzir));
            Thread c = new Thread(new ThreadStart(Program.consumir));
            p.Start();
            c.Start();

            Console.ReadLine();
        }
    }
}


