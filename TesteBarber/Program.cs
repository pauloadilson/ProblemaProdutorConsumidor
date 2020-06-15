using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TesteBarber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCortes = 0;
            int espera = 0;
            const int Cadeiras = 5;
            Semaphore CadeirasClientes = new Semaphore(0, Cadeiras);
            Semaphore CadeiraBabeiro = new Semaphore(0, 1);
            Semaphore mutex = new Semaphore(1, 1);
            Thread p = new Thread(new ThreadStart(Babeiro));
            Thread c = new Thread(new ThreadStart(Clientes));
            p.Start();
            c.Start();

            void Babeiro()
            {
                while (true)
                {
                    CadeirasClientes.WaitOne(); //down
                    Console.WriteLine($"O barbeiro está dormindo!");
                    mutex.WaitOne();
                    espera--;
                    Console.WriteLine($"Uma cadeira está livre");
                    Console.WriteLine($"Em espera: {espera}.");
                    CadeiraBabeiro.Release(1);
                    Console.WriteLine($"o cliente {numeroCortes + 1} se senta para cortar o cabelo.");
                    mutex.Release(1);
                    Console.WriteLine($"Barbeiro cortou o cabelo de {numeroCortes + 1}!");
                }
            }

            void Clientes()
            {
                while (numeroCortes < 10) {
                    Console.WriteLine($"O cliente {numeroCortes + 1} vai ao cabelereiro!");
                    mutex.WaitOne();
                    if (espera < Cadeiras)
                    {
                        Thread.Sleep(5000);
                        espera++;
                        Console.WriteLine($"Em espera: {espera}.");
                        CadeirasClientes.Release(1);
                        Console.WriteLine($"O cliente {numeroCortes + 1} acorda o barbeiro.");
                        mutex.Release(1);
                        CadeiraBabeiro.WaitOne();
                        Console.WriteLine($" O cliente {numeroCortes + 1} teve o cabelo cortado!");
                    }
                    else {
                        mutex.Release(1);
                        Console.WriteLine($"O cliente {numeroCortes + 1} vai embora!");
                    }
                    numeroCortes++;
                }
            }
            Console.ReadLine();
         }    
    }
}

