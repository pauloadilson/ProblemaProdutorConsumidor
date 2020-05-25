using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ProblemaProdutorConsumidor
{
    public class SemaforoMutexSinc
    {
        public SemaforoMutexSinc()
        {
            
        }

        const int buffSize = 10;
        static int[] buffer = new int[buffSize];
        static int valuesToProduce = 20;

        static void Main(string[] args)
        {
            Thread p = new Thread(new ThreadStart(SemaforoMutexSinc.produce));
            Thread c = new Thread(new ThreadStart(SemaforoMutexSinc.consume));
            p.Start();
            c.Start();

            Console.ReadLine();
        }
        private static Semaphore isFull = new Semaphore(buffSize, buffSize);
        private static Semaphore isEmpty = new Semaphore(0, buffSize);
        private static Semaphore mutex = new Semaphore(1, 1);

        static void produce()
        {
            for (int i = 0; i < valuesToProduce; i++)
            {
                isFull.WaitOne();
                mutex.WaitOne();
                buffer[i % buffSize] = i % 95;
                Console.WriteLine("Produzido: {0}", buffer[i % buffSize]);
                //Thread.Sleep(200);
                mutex.Release(1);
                isEmpty.Release(1);
                //Console.ReadLine();
            }
        }

        static void consume()
        {
            for (int i = 0; i < valuesToProduce; i++)
            {
                isEmpty.WaitOne();
                mutex.WaitOne();
                int c = buffer[i % buffSize];
                Console.WriteLine("                Consumido: {0}", c);
                //Random random = new Random();
                //Thread.Sleep(random.Next(200, 2000));
                mutex.Release(1);
                isFull.Release(1);
                //Console.ReadLine();
            }
        }
    }
}
