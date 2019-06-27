namespace PetShop
{
    partial class frmAtendimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscarPet = new System.Windows.Forms.Button();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mskDataHora = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarAtendimento = new System.Windows.Forms.Button();
            this.btnBuscarPeriodo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarPet
            // 
            this.btnBuscarPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPet.Location = new System.Drawing.Point(339, 136);
            this.btnBuscarPet.Name = "btnBuscarPet";
            this.btnBuscarPet.Size = new System.Drawing.Size(110, 30);
            this.btnBuscarPet.TabIndex = 118;
            this.btnBuscarPet.Text = "Buscar";
            this.btnBuscarPet.UseVisualStyleBackColor = true;
            this.btnBuscarPet.Click += new System.EventHandler(this.btnBuscarPet_Click);
            // 
            // txtCodPet
            // 
            this.txtCodPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPet.Location = new System.Drawing.Point(181, 136);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(98, 26);
            this.txtCodPet.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Código Pet";
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncionario.Location = new System.Drawing.Point(181, 179);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(98, 26);
            this.txtCodFuncionario.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 125;
            this.label2.Text = "Código Funcionário";
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(339, 179);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(110, 30);
            this.btnBuscarFuncionario.TabIndex = 126;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 129;
            this.label3.Text = "Código Serviço";
            // 
            // txtCodServico
            // 
            this.txtCodServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServico.Location = new System.Drawing.Point(181, 98);
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(98, 26);
            this.txtCodServico.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 131;
            this.label4.Text = "Dia/Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 132;
            this.label5.Text = "Situação";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(181, 281);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(98, 26);
            this.txtSituacao.TabIndex = 133;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(198, 388);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 30);
            this.btnVoltar.TabIndex = 137;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(11, 352);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 30);
            this.btnNovo.TabIndex = 135;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(133, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 30);
            this.btnSalvar.TabIndex = 136;
            this.btnSalvar.Text = "Gravar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mskDataHora
            // 
            this.mskDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataHora.Location = new System.Drawing.Point(181, 232);
            this.mskDataHora.Mask = "00/00/0000 00:00";
            this.mskDataHora.Name = "mskDataHora";
            this.mskDataHora.Size = new System.Drawing.Size(143, 26);
            this.mskDataHora.TabIndex = 138;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(181, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(98, 26);
            this.txtCodigo.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 139;
            this.label6.Text = "Código Atendimento";
            // 
            // btnBuscarAtendimento
            // 
            this.btnBuscarAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAtendimento.Location = new System.Drawing.Point(339, 56);
            this.btnBuscarAtendimento.Name = "btnBuscarAtendimento";
            this.btnBuscarAtendimento.Size = new System.Drawing.Size(110, 30);
            this.btnBuscarAtendimento.TabIndex = 141;
            this.btnBuscarAtendimento.Text = "Buscar";
            this.btnBuscarAtendimento.UseVisualStyleBackColor = true;
            this.btnBuscarAtendimento.Click += new System.EventHandler(this.btnBuscarAtendimento_Click);
            // 
            // btnBuscarPeriodo
            // 
            this.btnBuscarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPeriodo.Location = new System.Drawing.Point(339, 230);
            this.btnBuscarPeriodo.Name = "btnBuscarPeriodo";
            this.btnBuscarPeriodo.Size = new System.Drawing.Size(110, 30);
            this.btnBuscarPeriodo.TabIndex = 142;
            this.btnBuscarPeriodo.Text = "Buscar";
            this.btnBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarPeriodo.Click += new System.EventHandler(this.btnBuscarPeriodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(255, 352);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 30);
            this.btnBuscar.TabIndex = 143;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(377, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 30);
            this.btnLimpar.TabIndex = 144;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBuscarPeriodo);
            this.Controls.Add(this.btnBuscarAtendimento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskDataHora);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPet);
            this.Controls.Add(this.txtCodPet);
            this.Controls.Add(this.label1);
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtendimento";
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarPet;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mskDataHora;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarAtendimento;
        private System.Windows.Forms.Button btnBuscarPeriodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
    }
}