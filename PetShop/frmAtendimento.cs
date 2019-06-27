using PetShop.BO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Closed += (s, args) => this.Close();
            voltar.Show();
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            //txtCodigo.Enabled = false;
           // txtCodPet.Enabled = false;
            //  txtCodServico.Enabled = false;
         //   txtCodFuncionario.Enabled = false;
            mskDataHora.Enabled = false;
            txtSituacao.Enabled = false;

            btnSalvar.Enabled = false;
            //btnBuscarPet.Visible = false;
            //btnBuscarFuncionario.Visible = false;
            //btnBuscarServico.Visible = false;
            //btnBuscarAtendimento.Visible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodPet.Enabled = true;
            txtCodServico.Enabled = true;
            txtCodFuncionario.Enabled = true;
            mskDataHora.Enabled = true;
            txtSituacao.Enabled = true;

            btnSalvar.Enabled = true;
            btnBuscarPet.Visible = true;
            btnBuscarFuncionario.Visible = true;
            btnBuscarAtendimento.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            atendimento.Servico.CodServ = Convert.ToInt16(txtCodServico.Text);
            atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);
            atendimento.Funcionario.Cod = Convert.ToInt16(txtCodFuncionario.Text);
            atendimento.DataHora =Convert.ToDateTime(mskDataHora.Text);
            atendimento.Situacao = txtSituacao.Text;


            atendimentoBO.Gravar(atendimento);
            MessageBox.Show("Atendimento cadastrado com sucesso");

            txtCodigo.Clear();
            txtCodPet.Clear();
            txtCodServico.Clear();
            txtCodFuncionario.Clear();
            mskDataHora.Clear();
            txtSituacao.Clear();

            txtCodigo.Enabled = false;
            txtCodPet.Enabled = false;
            txtCodServico.Enabled = false;
            txtCodFuncionario.Enabled = false;
            mskDataHora.Enabled = false;
            txtSituacao.Enabled = false;

            btnSalvar.Enabled = false;
            btnBuscarPet.Visible = false;
            btnBuscarFuncionario.Visible = false;
            btnBuscarAtendimento.Visible = false;
        }

        private void btnBuscarAtendimento_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            try
            {
                atendimento.CodAtend = Convert.ToInt16(txtCodigo.Text);
                atendimentoBO.BuscarAtendimento(atendimento);


                if (atendimento.Situacao == "")
                {
                    MessageBox.Show("Atendimento não encontrado");
                    txtCodigo.Clear();
                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = false;
                    txtCodServico.Enabled = false;
                    txtCodFuncionario.Enabled = false;
                    mskDataHora.Enabled = false;
                    txtSituacao.Enabled = false;

                    btnSalvar.Enabled = false;
                  
                    btnBuscarPet.Visible = true;
                    btnBuscarAtendimento.Visible = true;
                    btnBuscarFuncionario.Visible = true;
                    btnNovo.Enabled = true;
                }
                else
                {
                    txtCodigo.Text = Convert.ToString(atendimento.CodAtend);
                    txtCodServico.Text = Convert.ToString(atendimento.Servico.CodServ);
                    txtCodPet.Text = Convert.ToString(atendimento.Pet.CodPet);
                    txtCodFuncionario.Text = Convert.ToString(atendimento.Funcionario.Cod);
                    mskDataHora.Text = Convert.ToString(atendimento.DataHora);
                    txtSituacao.Text = atendimento.Situacao;

                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = true;
                    txtCodServico.Enabled = true;
                    txtCodFuncionario.Enabled = true;
                    mskDataHora.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }

        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            try
            {
                atendimento.Funcionario.Cod = Convert.ToInt16(txtCodFuncionario.Text);
                atendimentoBO.BuscaPorFuncionario(atendimento);


                if (atendimento.Situacao == "")
                {
                    MessageBox.Show("Atendimento não encontrado");
                    txtCodigo.Clear();
                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = false;
                    txtCodServico.Enabled = false;
                    txtCodFuncionario.Enabled = false;
                    mskDataHora.Enabled = false;
                    txtSituacao.Enabled = false;

                    btnSalvar.Enabled = false;

                    btnBuscarPet.Visible = true;
                    btnBuscarAtendimento.Visible = true;
                    btnBuscarFuncionario.Visible = true;
                    btnNovo.Enabled = true;
                }
                else
                {
                    txtCodigo.Text = Convert.ToString(atendimento.CodAtend);
                    txtCodServico.Text = Convert.ToString(atendimento.Servico.CodServ);
                    txtCodPet.Text = Convert.ToString(atendimento.Pet.CodPet);
                    txtCodFuncionario.Text = Convert.ToString(atendimento.Funcionario.Cod);
                    mskDataHora.Text = Convert.ToString(atendimento.DataHora);
                    txtSituacao.Text = atendimento.Situacao;

                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = true;
                    txtCodServico.Enabled = true;
                    txtCodFuncionario.Enabled = true;
                    mskDataHora.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }

        }

        private void btnBuscarPet_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            AtendimentoBO atendimentoBO = new AtendimentoBO();

            try
            {
                atendimento.Pet.CodPet = Convert.ToInt16(txtCodPet.Text);
                atendimentoBO.BuscaPorPet(atendimento);


                if (atendimento.Situacao == "")
                {
                    MessageBox.Show("Atendimento não encontrado");
                    txtCodigo.Clear();
                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = false;
                    txtCodServico.Enabled = false;
                    txtCodFuncionario.Enabled = false;
                    mskDataHora.Enabled = false;
                    txtSituacao.Enabled = false;

                    btnSalvar.Enabled = false;

                    btnBuscarPet.Visible = true;
                    btnBuscarAtendimento.Visible = true;
                    btnBuscarFuncionario.Visible = true;
                    btnNovo.Enabled = true;
                }
                else
                {
                    txtCodigo.Text = Convert.ToString(atendimento.CodAtend);
                    txtCodServico.Text = Convert.ToString(atendimento.Servico.CodServ);
                    txtCodPet.Text = Convert.ToString(atendimento.Pet.CodPet);
                    txtCodFuncionario.Text = Convert.ToString(atendimento.Funcionario.Cod);
                    mskDataHora.Text = Convert.ToString(atendimento.DataHora);
                    txtSituacao.Text = atendimento.Situacao;

                    txtCodigo.Enabled = false;
                    txtCodPet.Enabled = true;
                    txtCodServico.Enabled = true;
                    txtCodFuncionario.Enabled = true;
                    mskDataHora.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }
    }
}
