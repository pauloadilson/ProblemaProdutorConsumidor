using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaBarbeiro
{
    class Program
    {
        const int cadeiras = 5;
        static int espera = 0;

        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(Program.Babeiro));
            Thread c = new Thread(new ThreadStart(Program.Clientes));
            p.Start();
            c.Start();

            Console.ReadLine();
        }
        private static Semaphore CadeirasClientes = new Semaphore(0, 3);
        private static Semaphore CadeiraBabeiro = new Semaphore(0, 1);
        private static Semaphore mutex = new Semaphore(1, 1);

        static void Babeiro()
        {
            for (int i = 0; i < 10; i++)
            {
                CadeirasClientes.WaitOne(); //down
                mutex.WaitOne();
                espera -= 1;
                Console.WriteLine($"Em espera: {espera}.");
                CadeiraBabeiro.Release(1);
                mutex.Release(1);
                Console.WriteLine("Cortou cabelo!");
            }
        }

        static void Clientes()
        {
            mutex.WaitOne();
            if (espera < cadeiras)
            {
                espera += 1;
                Console.WriteLine($"Em espera: {espera}.");
                CadeirasClientes.Release(1);
                mutex.Release(1);
                CadeiraBabeiro.WaitOne();
                Console.WriteLine("Teve o cabelo cortado!");
            }
            else
                mutex.Release(1);
            
        }
    }
}
