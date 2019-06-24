namespace PetShop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnAtendimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(33, 39);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(248, 80);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPets
            // 
            this.btnPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.Image = ((System.Drawing.Image)(resources.GetObject("btnPets.Image")));
            this.btnPets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.Location = new System.Drawing.Point(33, 267);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(248, 80);
            this.btnPets.TabIndex = 1;
            this.btnPets.Text = "Pet";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(331, 39);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(248, 80);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "     Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnServico
            // 
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.Image = ((System.Drawing.Image)(resources.GetObject("btnServico.Image")));
            this.btnServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico.Location = new System.Drawing.Point(331, 267);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(248, 80);
            this.btnServico.TabIndex = 3;
            this.btnServico.Text = "Serviço";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendimento.Image")));
            this.btnAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimento.Location = new System.Drawing.Point(181, 155);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(248, 80);
            this.btnAtendimento.TabIndex = 4;
            this.btnAtendimento.Text = "       Atendimento";
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 391);
            this.Controls.Add(this.btnAtendimento);
            this.Controls.Add(this.btnServico);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnCliente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnAtendimento;
    }
}

