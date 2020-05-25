using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaPCCMutex
{
    class Program
    {
        static int saldo = 1000;
        const int incremento = 200;
        const int decremento = 100;

        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Program.deposito));
            Thread c = new Thread(new ThreadStart(Program.saque));
            p.Start();
            c.Start();
            Console.ReadLine();
        }
        private static Semaphore mutex = new Semaphore(1, 1);

        static void deposito()
        {
            for (int i = 0; i < 5; i++)
            {
                mutex.WaitOne();
                saldo += incremento;
                Console.WriteLine("Saldo após depósito: {0}", saldo);
                mutex.Release(1);
            }
        }

        static void saque()
        {
            for (int i = 0; i < 5; i++)
            {
                mutex.WaitOne();
                saldo -= decremento;
                Console.WriteLine("Saldo após saque: {0}", saldo);
                mutex.Release(1);
            }
        }
    }
}
