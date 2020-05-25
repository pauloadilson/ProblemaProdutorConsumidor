namespace ProblemaProdutorConsumidor
{
    partial class ProblemaProdutorConsumidor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBuffer = new System.Windows.Forms.ListBox();
            this.tbSemaforoVazio = new System.Windows.Forms.TextBox();
            this.tbTamanhoBuffer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btProduzir = new System.Windows.Forms.Button();
            this.tbItemConsumido = new System.Windows.Forms.TextBox();
            this.tbEstadoConsumidor = new System.Windows.Forms.TextBox();
            this.tbItemProduzido = new System.Windows.Forms.TextBox();
            this.tbEstadoProdutor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btConsumir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consumidor";
            // 
            // lbBuffer
            // 
            this.lbBuffer.FormattingEnabled = true;
            this.lbBuffer.Location = new System.Drawing.Point(351, 229);
            this.lbBuffer.Name = "lbBuffer";
            this.lbBuffer.Size = new System.Drawing.Size(120, 95);
            this.lbBuffer.TabIndex = 1;
            // 
            // tbSemaforoVazio
            // 
            this.tbSemaforoVazio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSemaforoVazio.Location = new System.Drawing.Point(361, 88);
            this.tbSemaforoVazio.Name = "tbSemaforoVazio";
            this.tbSemaforoVazio.Size = new System.Drawing.Size(100, 20);
            this.tbSemaforoVazio.TabIndex = 2;
            this.tbSemaforoVazio.Text = this.tbTamanhoBuffer.Text;
            this.tbSemaforoVazio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTamanhoBuffer
            // 
            this.tbTamanhoBuffer.Location = new System.Drawing.Point(139, 395);
            this.tbTamanhoBuffer.Name = "tbTamanhoBuffer";
            this.tbTamanhoBuffer.Size = new System.Drawing.Size(100, 20);
            this.tbTamanhoBuffer.TabIndex = 2;
            this.tbTamanhoBuffer.Text = "5";
            this.tbTamanhoBuffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(361, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buffer";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(361, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Semáforo Mutex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Semáforo Vazio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Semáforo Cheio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tamanho do Buffer:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btConsumir);
            this.panel1.Controls.Add(this.btProduzir);
            this.panel1.Controls.Add(this.tbItemConsumido);
            this.panel1.Controls.Add(this.tbEstadoConsumidor);
            this.panel1.Controls.Add(this.tbItemProduzido);
            this.panel1.Controls.Add(this.tbEstadoProdutor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 4;
            // 
            // btProduzir
            // 
            this.btProduzir.Location = new System.Drawing.Point(48, 98);
            this.btProduzir.Name = "btProduzir";
            this.btProduzir.Size = new System.Drawing.Size(75, 23);
            this.btProduzir.TabIndex = 4;
            this.btProduzir.Text = "Produzir";
            this.btProduzir.UseVisualStyleBackColor = true;
            this.btProduzir.Click += new System.EventHandler(this.btProduzir_Click);
            // 
            // tbItemConsumido
            // 
            this.tbItemConsumido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemConsumido.Location = new System.Drawing.Point(632, 88);
            this.tbItemConsumido.Name = "tbItemConsumido";
            this.tbItemConsumido.Size = new System.Drawing.Size(100, 20);
            this.tbItemConsumido.TabIndex = 3;
            this.tbItemConsumido.Text = "0";
            this.tbItemConsumido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEstadoConsumidor
            // 
            this.tbEstadoConsumidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstadoConsumidor.Location = new System.Drawing.Point(632, 178);
            this.tbEstadoConsumidor.Name = "tbEstadoConsumidor";
            this.tbEstadoConsumidor.Size = new System.Drawing.Size(100, 20);
            this.tbEstadoConsumidor.TabIndex = 3;
            this.tbEstadoConsumidor.Text = "0";
            this.tbEstadoConsumidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbItemProduzido
            // 
            this.tbItemProduzido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemProduzido.Location = new System.Drawing.Point(35, 72);
            this.tbItemProduzido.Name = "tbItemProduzido";
            this.tbItemProduzido.Size = new System.Drawing.Size(100, 20);
            this.tbItemProduzido.TabIndex = 3;
            this.tbItemProduzido.Text = "0";
            this.tbItemProduzido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEstadoProdutor
            // 
            this.tbEstadoProdutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstadoProdutor.Location = new System.Drawing.Point(35, 162);
            this.tbEstadoProdutor.Name = "tbEstadoProdutor";
            this.tbEstadoProdutor.Size = new System.Drawing.Size(100, 20);
            this.tbEstadoProdutor.TabIndex = 3;
            this.tbEstadoProdutor.Text = "0";
            this.tbEstadoProdutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(634, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado do Consumidor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado do Produtor";
            // 
            // btConsumir
            // 
            this.btConsumir.Location = new System.Drawing.Point(645, 62);
            this.btConsumir.Name = "btConsumir";
            this.btConsumir.Size = new System.Drawing.Size(75, 23);
            this.btConsumir.TabIndex = 4;
            this.btConsumir.Text = "Consumir";
            this.btConsumir.UseVisualStyleBackColor = true;
            this.btConsumir.Click += new System.EventHandler(this.btConsumir_Click);
            // 
            // ProblemaProdutorConsumidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbTamanhoBuffer);
            this.Controls.Add(this.tbSemaforoVazio);
            this.Controls.Add(this.lbBuffer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ProblemaProdutorConsumidor";
            this.Text = "Problema Produtor/Consumidor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBuffer;
        private System.Windows.Forms.TextBox tbSemaforoVazio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTamanhoBuffer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btProduzir;
        private System.Windows.Forms.TextBox tbItemConsumido;
        private System.Windows.Forms.TextBox tbEstadoConsumidor;
        private System.Windows.Forms.TextBox tbItemProduzido;
        private System.Windows.Forms.TextBox tbEstadoProdutor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btConsumir;
    }
}

