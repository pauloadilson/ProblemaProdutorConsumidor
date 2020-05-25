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
        private static Semaphore estaCheio = new Semaphore(tamanhoDoBuffer, tamanhoDoBuffer);
        private static Semaphore estaVazio = new Semaphore(0, tamanhoDoBuffer);
        private static Semaphore mutex = new Semaphore(1, 1);

        static void produzir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                estaCheio.WaitOne();
                mutex.WaitOne();
                buffer[i % tamanhoDoBuffer] =  i % 95;
                Console.WriteLine("Produzido: {0}", buffer[i % tamanhoDoBuffer]);
                mutex.Release(1);
                estaVazio.Release(1);
            }
        }

        static void consumir()
        {
            for (int i = 0; i < valoresAProduzir; i++)
            {
                estaVazio.WaitOne();
                mutex.WaitOne();
                int c = buffer[i % tamanhoDoBuffer];
                Console.WriteLine("                Consumido: {0}", c);
                mutex.Release(1);
                estaCheio.Release(1);
            }
        }
        

























        /*static SemaphoreSlim _mutex = new SemaphoreSlim(1);    // Capacity of 3
        static SemaphoreSlim _semEmpty = new SemaphoreSlim(2);
        static SemaphoreSlim _semFull = new SemaphoreSlim(0);
        struct tp_pilha
        {
            public int topo;
            public int[] vetor;
        }
        tp_pilha pilha;
        int i;
        static void Main(string[] args, tp_pilha pilha, int i)
        {

            pilha.vetor = new int[17] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 13, 14, 151, 61, 71, 81 };
            pilha.topo = -1;
            i = 1;
            Producer(pilha, i);
            Consumer(pilha);
            while (!EstaCheia(pilha))
            {
                _semFull.Wait();
                _mutex.Wait();
                Console.WriteLine(Desempilha(ref pilha));
                // Thread.Sleep(5000);
                _mutex.Release();
                _semEmpty.Release();
            }
            while (!EstaCheia(pilha))
            {
                int item;
                item = i++;
                _semEmpty.Wait();
                _mutex.Wait();
                Console.WriteLine(item);
                Empilha(ref pilha, item);
                //Thread.Sleep(5000);
                _mutex.Release();
                _semFull.Release();

            }

            //for (int i = 1; i <= 10; i++) new Thread(Enter).Start(i);
            //Console.ReadLine();

        }

        bool EstaVazia(tp_pilha p)
        {
            return (p.topo == -1);
        }
        static bool EstaCheia(tp_pilha p)
        {  //verificar se esta cheia
            return (p.topo == 16);
        }
        // Insere um elemento
        int BuscaValor(ref tp_pilha p)
        {
            return (p.vetor[++p.topo]);
        }
        static void Empilha(ref tp_pilha p, int valor)
        {
            p.vetor[++p.topo] = valor;
        }
        // Remove um elemento
        static int Desempilha(ref tp_pilha p)
        {
            return (p.vetor[p.topo--]);
        }
         static void Producer(tp_pilha pilha, int i)
        {
            while (!EstaCheia(pilha))
            {
                int item;
                item = i++;
                _semEmpty.Wait();
                _mutex.Wait();
                Console.WriteLine(item);
                Empilha(ref pilha, item);
                //Thread.Sleep(5000);
                _mutex.Release();
                _semFull.Release();

            }
        }
        static void Consumer(tp_pilha pilha)
        {
            while (!EstaCheia(pilha))
            {
                _semFull.Wait();
                _mutex.Wait();
                Console.WriteLine(Desempilha(ref pilha));
                // Thread.Sleep(5000);
                _mutex.Release();
                _semEmpty.Release();

            }
        }
        /*static void Producer(ref tp_pilha pilha)
        {
            while (true)
            {
                int item;
                item = BuscaValor(ref pilha);
                _semEmpty.Wait();
                _mutex.Wait();
                Empilha(item);

            }
        }

        int ProduceItem()
        {
            for (int i = 1; i <= 10; i++) 
            { 
               i; 
            }
        }

        void into */















        /*static void Main()
        {
            for (int i = 1; i <= 10; i++) new Thread(Enter).Start(i);
            Console.ReadLine();
        }

        static void Enter(object id)
        {
            Console.WriteLine(id + " quer entrar no buffer");
            _semEmpty.Wait();
            _mutex.Wait();
            Console.WriteLine(id + " is in!");           // Only three threads
            Thread.Sleep(1000 * (int)id);               // can be here at
            Console.WriteLine(id + " is leaving");       // a time.
            _mutex.Release();
            _semEmpty.Release();
        }

        static void producer()
        {

        }


        /*Semaphore semaphoreObject = new Semaphore(initialCount: 3, maximumCount: 3, name: "PrinterApp");
        Printer printerObject = new Printer();

        for (int i = 0; i < 20; ++i)
        {
            int j = i;
            Task.Factory.StartNew(() =>
            {
                semaphoreObject.WaitOne();
                printerObject.Print(j);
                semaphoreObject.Release();
            });
        }
        Console.ReadLine();
    }
}
class Printer
{
    public void Print(int documentToPrint)
    {
        Console.WriteLine("Printing document: " + documentToPrint);
        //code to print document
        Thread.Sleep(TimeSpan.FromSeconds(5));
    } */


    }
}


