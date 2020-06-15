using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MonitoresCondicaoCorrida
{
    class Program
    {
        static double saldo, saque, pex;
        static object sessao_critica = new object();
        public static void Main(string[] args)
        {

            Console.Write("Saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor de saque: ");
            saque = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor de depósito: ");
            pex = Convert.ToDouble(Console.ReadLine());
            Thread t1 = CriarThread("Depositar");
            t1.Start();
            Thread t2 = CriarThread("Sacar");
            t2.Start();
            Console.ReadKey();
        }
        static Thread CriarThread(string nome)
        {
            ThreadStart trabalho = new ThreadStart(Mostrar);
            Thread Trabalho = new Thread(trabalho);
            Trabalho.Name = nome;
            return Trabalho;
        }
        static void Mostrar()
        {
            Thread estaThread = Thread.CurrentThread;
            string nome = estaThread.Name;

            Console.WriteLine("Iniciando Thread " + nome);
            Console.WriteLine();
            double saldo_atualizado = saldo;
            Monitor.Enter(sessao_critica); // está em uso exclusivo // região crítica
            Console.WriteLine($"Entrou na sessao critica: {nome}." ); 
            if (nome == "Sacar")
            {
                //  Thread.Sleep(2000); 
                saldo = saldo_atualizado - saque;
                //   saldo = saldo_atualizado;
                Console.WriteLine($"Atualizou saque = {saldo}.");
            }

            if (nome == "Depositar")
            {
                Thread.Sleep(2000);
                saldo = saldo_atualizado + pex;
                //   saldo = saldo_atualizado;
                Console.WriteLine($"Atualizou Deposito = {saldo}.");
            }
            Monitor.Exit(sessao_critica);
            Console.WriteLine($"Saiu da sessao critica: {nome}.");
        }
    }
}
