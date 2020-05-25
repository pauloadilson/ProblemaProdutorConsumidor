using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProblemaProdutorConsumidor
{
    public partial class ProblemaProdutorConsumidor : Form
    {
        public ProblemaProdutorConsumidor()
        {
            InitializeComponent();
            pilha.vetor = new int[17];
            pilha.topo = -1;
        }

        static SemaphoreSlim _mutex = new SemaphoreSlim(1);    // Capacity of 3
        static SemaphoreSlim _semEmpty = new SemaphoreSlim(2);
        static SemaphoreSlim _semFull = new SemaphoreSlim(0);


        struct tp_pilha
        {
            public int topo;
            public int[] vetor;
        }
        tp_pilha pilha;
        bool EstaVazia(tp_pilha p)
        {
            return (p.topo == -1);
        }
        bool EstaCheia(tp_pilha p)
        {  //verificar se esta cheia
            return (p.topo == 16);
        }
        // Insere um elemento
        int BuscaValor(ref tp_pilha p)
        {
            return (p.vetor[++p.topo]);
        }
        void Empilha(ref tp_pilha p, int valor)
        {
            p.vetor[++p.topo] = valor;
            lbBuffer.Items.Add(valor);

        }
        // Remove um elemento
        int Desempilha(ref tp_pilha p)
        {
            int valor = p.vetor[p.topo--];
            lbBuffer.Items.RemoveAt(p.topo +1);
            return valor;
        }



        private void btProduzir_Click(object sender, EventArgs e)
        {
            while (!EstaCheia(pilha))
            {
                int item;
                item = Convert.ToInt32(tbItemProduzido.Text);
                _semEmpty.Wait();
                _mutex.Wait();
                Empilha(ref pilha, item);
                //Thread.Sleep(5000);
                _mutex.Release();
                _semFull.Release();

            }
        }

        private void btConsumir_Click(object sender, EventArgs e)
        {
            while (!EstaVazia(pilha))
            {
                int item;
                _semFull.Wait();
                _mutex.Wait();
                Desempilha(ref pilha);
               // Thread.Sleep(5000);
                _mutex.Release();
                _semEmpty.Release();

            }
        }



        /*
        int N = 7;

        mutex buffer_mutex; // similar to "semaphore buffer_mutex = 1", but different (see notes below)
        semaphore fillCount = 0;
        semaphore emptyCount = BUFFER_SIZE;

        procedure producer()
        {
            while (true)
            {
                item = produceItem();
                down(emptyCount);
                down(buffer_mutex);
                putItemIntoBuffer(item);
                up(buffer_mutex);
                up(fillCount);
            }
        }

        procedure consumer()
        {
            while (true)
            {
                down(fillCount);
                down(buffer_mutex);
                item = removeItemFromBuffer();
                up(buffer_mutex);
                up(emptyCount);
                consumeItem(item);
            }
        }
        */

    }
}
