using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaPCMonitor
{
    class Program
    {
        const int tamanhoDoBuffer = 5;
        static int[] buffer = new int[tamanhoDoBuffer];
        static int valoresAProduzir = 20;


        static int avail = 0;
        private static object _buffer = new object();
        private static object isFull = new object();
        private static object isEmpty = new object();

        static void produzir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                while (avail == tamanhoDoBuffer)
                {
                    Monitor.Enter(isFull);
                    Monitor.Wait(isFull);
                    Monitor.Exit(isFull);
                }

                Monitor.Enter(_buffer);
                buffer[i % tamanhoDoBuffer] = (i % 95);
                avail++;
                Console.WriteLine("Produzido: {0}", buffer[i % tamanhoDoBuffer] + 1);
                Monitor.Exit(_buffer);

                Monitor.Enter(isEmpty);
                Monitor.Pulse(isEmpty);
                Monitor.Exit(isEmpty);
            }
            avail++;
        }

        static void consumir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                while (avail < 1)
                {
                    Monitor.Enter(isEmpty);
                    Monitor.Wait(isEmpty);
                    Monitor.Exit(isEmpty);
                }

                Monitor.Enter(_buffer);
                int c = buffer[i % tamanhoDoBuffer];
                avail--;
                Console.WriteLine("                Consumido: {0}", c + 1);
                Monitor.Exit(_buffer);

                Monitor.Enter(isFull);
                Monitor.Pulse(isFull);
                Monitor.Exit(isFull);
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
