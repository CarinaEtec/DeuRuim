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
    public partial class frmServico : Form
    {
        public frmServico()
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

        private void frmServico_Load(object sender, EventArgs e)
        {
            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtPorte.Enabled = false;
            txtValor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCod.Enabled = false;
            txtTipo.Enabled = true;
            txtPorte.Enabled = true;
            txtValor.Enabled = true;

            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            servico.Tipo = txtTipo.Text;
            servico.Porte = txtPorte.Text;
            servico.Valor = Convert.ToDecimal(txtValor.Text);

            servicoBO.Gravar(servico);
            MessageBox.Show("Serviço cadastrado com sucesso");

            txtCod.Clear();
            txtTipo.Clear();
            txtPorte.Clear();
            txtValor.Clear();

            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtPorte.Enabled = false;
            txtValor.Enabled = false; 
            btnSalvar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCod.Enabled = true;
            btnNovo.Enabled = false;
            btnBuscarCod.Visible = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            servico.CodServ = Convert.ToInt16(txtCod.Text);
            servico.Tipo = txtTipo.Text;
            servico.Porte = txtPorte.Text;
            servico.Valor = Convert.ToDecimal(txtValor.Text);

            servicoBO.Editar(servico);
            MessageBox.Show("Serviço editado com sucesso");


            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtPorte.Enabled = false;
            txtValor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;

            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtCod.Clear();
            txtTipo.Clear();
            txtPorte.Clear();
            txtValor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            ServicoBO servicoBO = new ServicoBO();

            try
            {
                servico.CodServ = Convert.ToInt16(txtCod.Text);
                servicoBO.Deletar(servico);

                MessageBox.Show("Serviço excluído com sucesso");
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }

            txtCod.Enabled = false;
            txtTipo.Enabled = false;
            txtPorte.Enabled = false;
            txtValor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;

            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtCod.Clear();
            txtTipo.Clear();
            txtPorte.Clear();
            txtValor.Clear();
        }





        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            Servico cliente = new Servico();
            ServicoBO clienteBO = new ServicoBO();

            try
            {
                cliente.CodServ = Convert.ToInt16(txtCod.Text);
                clienteBO.Buscar(cliente);

                if (cliente.Tipo == "")
                {
                    MessageBox.Show("Serviço não encontrado");
                    txtCod.Clear();
                    txtCod.Enabled = false;
                    txtTipo.Enabled = false;
                    txtPorte.Enabled = false;
                    txtValor.Enabled = false;

                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnBuscarCod.Visible = false;
                    btnNovo.Enabled = true;
                    btnBuscar.Enabled = true;

                }
                else
                {
                    txtTipo.Text = cliente.Tipo;
                    txtPorte.Text = cliente.Porte;
                    txtValor.Text = Convert.ToString(cliente.Valor);

                    txtCod.Enabled = false;
                    txtTipo.Enabled = true;
                    txtPorte.Enabled = true;
                    txtValor.Enabled = true;

                    btnExcluir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnBuscar.Enabled = false;
                }

            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }



        }
    }
}
