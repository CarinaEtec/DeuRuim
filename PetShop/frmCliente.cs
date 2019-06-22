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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtEmail.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;
            btnBuscarCep.Visible = false;
            btnValidarCpf.Visible = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            mskCep.Enabled = true;
            txtNumero.Enabled = true;
            mskTelefone.Enabled = true;
            txtEmail.Enabled = true;

            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;
            btnBuscarCep.Visible = true;
            btnValidarCpf.Visible = true;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Closed += (s, args) => this.Close();
            voltar.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            btnBuscarCod.Visible = true;
            btnNovo.Enabled = false;
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            try
            {
                cliente.Cod = Convert.ToInt16(txtCodigo.Text);
                clienteBO.Buscar(cliente);

                if (cliente.Nome == "")
                {
                    MessageBox.Show("Cliente não encontrado");
                    txtCodigo.Clear();
                    txtCodigo.Enabled = false;
                    txtNome.Enabled = false;
                    txtCpf.Enabled = false;
                    mskCep.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtCidade.Enabled = false;
                    txtNumero.Enabled = false;
                    mskTelefone.Enabled = false;
                    txtEmail.Enabled = false;

                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnBuscarCod.Visible = false;
                    btnBuscarCep.Visible = false;
                    btnValidarCpf.Visible = false;
                    btnNovo.Enabled = true;
                    btnBuscar.Enabled = true;

                }
                else
                {
                    txtNome.Text = cliente.Nome;
                    txtCpf.Text = Convert.ToString(cliente.Cpf);
                    mskCep.Text = cliente.Cep;
                    txtEndereco.Text = cliente.Endereco;
                    txtCidade.Text = cliente.Cidade;
                    txtNumero.Text = cliente.Numero;
                    mskTelefone.Text = cliente.Telefone;
                    txtEmail.Text = cliente.Email;


                    txtCodigo.Enabled = false;
                    txtNome.Enabled = true;
                    txtCpf.Enabled = true;
                    mskCep.Enabled = true;
                    txtNumero.Enabled = true;
                    mskTelefone.Enabled = true;
                    txtEmail.Enabled = true;

                    btnExcluir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnBuscar.Enabled = false;

                    btnValidarCpf.Visible = true;
                    btnBuscarCep.Visible = true;
                }

            }

            catch
            {
                MessageBox.Show("Preencha corretamente as informações");

            }
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                var webService = new WSCorreios.AtendeClienteClient();
                var resposta = webService.consultaCEP(mskCep.Text);

                txtEndereco.Text = resposta.end;
                txtCidade.Text = resposta.cidade;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mskCep.Clear();
                txtEndereco.Clear();
                txtCidade.Clear();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt64(txtCpf.Text);
            cliente.Cep = mskCep.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Telefone = mskTelefone.Text;
            cliente.Email = txtEmail.Text;

            clienteBO.Gravar(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso");



            txtNome.Clear();
            txtCpf.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();

            txtNome.Enabled = false;
            txtCpf.Enabled = false; ;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtEmail.Enabled = false;
            btnSalvar.Enabled = false;
            btnBuscar.Enabled = true;

            btnValidarCpf.Visible = false;
            btnBuscarCep.Visible = false;
        }

        private void btnValidarCpf_Click(object sender, EventArgs e)
        {
            string valor = txtCpf.Text;

            if (ValidacaoCPF.IsCpf(valor))
            {
                MessageBox.Show(" CPF Válido !");
            }
            else
            {
                MessageBox.Show(" CPF Inválido !");
                txtCpf.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            try
            {
                cliente.Cod = Convert.ToInt16(txtCodigo.Text);
                clienteBO.Deletar(cliente);

                MessageBox.Show("Cliente excluído com sucesso");
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }

            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtEmail.Enabled = false;


            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;
            btnBuscarCep.Visible = false;
            btnValidarCpf.Visible = false;

            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtNome.Clear();
            txtCpf.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtCodigo.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            cliente.Cod = Convert.ToInt16(txtCodigo.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = Convert.ToInt64(txtCpf.Text);
            cliente.Cep = mskCep.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Telefone = mskTelefone.Text;
            cliente.Email = txtEmail.Text;

            clienteBO.Editar(cliente);
            MessageBox.Show("Cliente editado com sucesso");


            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtEmail.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;
            btnBuscarCep.Visible = false;
            btnValidarCpf.Visible = false;

            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtNome.Clear();
            txtCpf.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtCodigo.Clear();
        }
    }
}
