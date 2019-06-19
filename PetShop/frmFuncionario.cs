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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarCod.Visible = false;
            btnBuscarCep.Visible = false;
            btnValidarCpf.Visible = false;

            txtCartTrab.Enabled = false;
            txtSalario.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            mskCep.Enabled = true;
            txtNumero.Enabled = true;
            mskTelefone.Enabled = true;

            txtCartTrab.Enabled = true;
            txtSalario.Enabled = true;

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
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            try
            {
                funcionario.Cod = Convert.ToInt16(txtCodigo.Text);
                funcionarioBO.Buscar(funcionario);

                if (funcionario.Nome == "")
                {
                    MessageBox.Show("Funcionário não encontrado");
                    txtCodigo.Clear();
                }
                else
                {
                    txtNome.Text = funcionario.Nome;
                    txtCpf.Text = Convert.ToString(funcionario.Cpf);
                    mskCep.Text = funcionario.Cep;
                    txtEndereco.Text = funcionario.Endereco;
                    txtCidade.Text = funcionario.Cidade;
                    txtNumero.Text = funcionario.Numero;
                    mskTelefone.Text = funcionario.Telefone;
                    txtCartTrab.Text = funcionario.Carttrab;
                    txtSalario.Text = Convert.ToString(funcionario.Salario);
                }
            }

            catch
            {
                MessageBox.Show("Preencha corretamente as informações");

            }

            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnBuscar.Enabled = false;



            /*********************** PARA TESTES *************** DEPOIS APAGAR ********************/


            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            mskCep.Enabled = true;
            txtNumero.Enabled = true;
            mskTelefone.Enabled = true;
            txtSalario.Enabled = true;
            txtCartTrab.Enabled = true;


            btnValidarCpf.Visible = true;
            btnBuscarCep.Visible = true;
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
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = Convert.ToInt64(txtCpf.Text);
            funcionario.Cep = mskCep.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Carttrab = txtCartTrab.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);


            funcionarioBO.Gravar(funcionario);
            MessageBox.Show("Funcionário cadastrado com sucesso");



            txtNome.Clear();
            txtCpf.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskTelefone.Clear();
            txtCartTrab.Clear();
            txtSalario.Clear();

            txtNome.Enabled = false;
            txtCpf.Enabled = false; ;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtCartTrab.Enabled = false;
            txtSalario.Enabled = false;

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
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            try
            {
                funcionario.Cod = Convert.ToInt16(txtCodigo.Text);
                funcionarioBO.Deletar(funcionario);

                MessageBox.Show("Funcionário excluído com sucesso");
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
            txtCartTrab.Enabled=false;
            txtSalario.Enabled=false;

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
            txtCodigo.Clear();
            txtSalario.Clear();
            txtCartTrab.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioBO funcionarioBO = new FuncionarioBO();

            funcionario.Cod = Convert.ToInt16(txtCodigo.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = Convert.ToInt64(txtCpf.Text);
            funcionario.Cep = mskCep.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Carttrab = txtCartTrab.Text;
            funcionario.Salario = Convert.ToDecimal(txtSalario.Text);

            funcionarioBO.Editar(funcionario);
            MessageBox.Show("Funcionário editado com sucesso");



            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            mskCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskTelefone.Enabled = false;
            txtCartTrab.Enabled = false;
            txtSalario.Enabled = false;

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
            txtCodigo.Clear();
            txtSalario.Clear();
            txtCartTrab.Clear();
        }
    }
}
