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
    public partial class frmPet : Form
    {
        public frmPet()
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

        private void frmPet_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodCli.Enabled = false;
            txtNome.Enabled = false;
            txtEspecie.Enabled = false;
            txtRaca.Enabled = false;
            txtPorte.Enabled = false;
            txtSexo.Enabled = false;
            txtCor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarPet.Visible = false;
            btnBuscarCli.Visible = false;
            btnBuscarPorNome.Visible = false;

            txtNomeCli.Visible = false;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            pet.Cliente.Cod = Convert.ToInt16(txtCodCli.Text);
            pet.Nome = txtNome.Text;
            pet.Especie = txtEspecie.Text;
            pet.Raca = txtRaca.Text;
            pet.Porte = txtPorte.Text;
            pet.Sexo = txtSexo.Text;
            pet.Cor = txtCor.Text;

            petBO.Gravar(pet);
            MessageBox.Show("Pet cadastrado com sucesso");
            
            txtCodigo.Clear();
            txtCodCli.Clear();
            txtNome.Clear();
            txtEspecie.Clear();
            txtRaca.Clear();
            txtPorte.Clear();
            txtSexo.Clear();
            txtCor.Clear();

            txtCodigo.Enabled = false;
            txtCodCli.Enabled = false;
            txtNome.Enabled = false;
            txtEspecie.Enabled = false;
            txtRaca.Enabled = false;
            txtPorte.Enabled = false;
            txtSexo.Enabled = false;
            txtCor.Enabled = false;

            btnSalvar.Enabled = false;
            btnBuscar.Enabled = true;

            txtNomeCli.Clear();
            txtNomeCli.Visible = false;
            btnBuscarCli.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            btnBuscarPet.Visible = true;
            btnNovo.Enabled = false;
            btnBuscarPorNome.Visible = true;

        }

        private void btnBuscarPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            try
            {
                pet.CodPet = Convert.ToInt16(txtCodigo.Text);
                petBO.Buscar(pet);


                if (pet.Nome == "")
                {
                    MessageBox.Show("Pet não encontrado");
                    txtCodigo.Clear();
                    txtCodigo.Enabled = false;
                    txtCodCli.Enabled = false;
                    txtNome.Enabled = false;
                    txtEspecie.Enabled = false;
                    txtRaca.Enabled = false;
                    txtPorte.Enabled = false;
                    txtSexo.Enabled = false;
                    txtCor.Enabled = false;

                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnBuscarPet.Visible = false;
                    btnBuscarCli.Visible = false;

                    btnNovo.Enabled = true;
                    btnBuscar.Enabled = true;
                }
                else
                {
                    txtCodigo.Text = Convert.ToString(pet.CodPet);
                    txtCodCli.Text = Convert.ToString(pet.Cliente.Cod);
                    txtNome.Text = pet.Nome;
                    txtEspecie.Text = pet.Especie;
                    txtRaca.Text = pet.Raca;
                    txtPorte.Text = pet.Porte;
                    txtSexo.Text = pet.Sexo;
                    txtCor.Text = pet.Cor;

                    txtCodigo.Enabled = false;
                    txtCodCli.Enabled = true;
                    txtNome.Enabled = true;
                    txtEspecie.Enabled = true;
                    txtRaca.Enabled = true;
                    txtPorte.Enabled = true;
                    txtSexo.Enabled = true;
                    txtCor.Enabled = true;

                    btnExcluir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnBuscarCli.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            pet.CodPet = Convert.ToInt16(txtCodigo.Text);
            pet.Cliente.Cod = Convert.ToInt16(txtCodCli.Text);
            pet.Nome = txtNome.Text;
            pet.Especie = txtEspecie.Text;
            pet.Raca = txtRaca.Text;
            pet.Sexo = txtSexo.Text;
            pet.Porte = txtPorte.Text;
            pet.Cor = txtCor.Text;

            petBO.Editar(pet);
            MessageBox.Show("Pet editado com sucesso");



            txtCodigo.Enabled = false;
            txtCodCli.Enabled = false;
            txtNome.Enabled = false;
            txtEspecie.Enabled = false;
            txtRaca.Enabled = false;
            txtPorte.Enabled = false;
            txtSexo.Enabled = false;
            txtCor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarPet.Visible = false;
            btnBuscarCli.Visible = false;

            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtCodigo.Clear();
            txtCodCli.Clear();
            txtNome.Clear();
            txtEspecie.Clear();
            txtRaca.Clear();
            txtPorte.Clear();
            txtSexo.Clear();
            txtCor.Clear();

            txtNomeCli.Clear();
            txtNomeCli.Visible = false;
            btnBuscarCli.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            try
            {
                pet.CodPet = Convert.ToInt16(txtCodigo.Text);
                petBO.Deletar(pet);

                MessageBox.Show("Pet excluído com sucesso");
            }
            catch
            {
                MessageBox.Show("Preencha corretamente os campos e/ou verifique se esses dados não estão sendo usados");
            }


            txtCodigo.Enabled = false;
            txtCodCli.Enabled = false;
            txtNome.Enabled = false;
            txtEspecie.Enabled = false;
            txtRaca.Enabled = false;
            txtPorte.Enabled = false;
            txtSexo.Enabled = false;
            txtCor.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscarPet.Visible = false;


            btnNovo.Enabled = true;
            btnBuscar.Enabled = true;

            txtCodigo.Clear();
            txtCodCli.Clear();
            txtNome.Clear();
            txtEspecie.Clear();
            txtRaca.Clear();
            txtPorte.Clear();
            txtSexo.Clear();
            txtCor.Clear();

            txtNomeCli.Clear();
            txtNomeCli.Visible = false;
            btnBuscarCli.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodCli.Enabled = true;
            txtNome.Enabled = true;
            txtEspecie.Enabled = true;
            txtRaca.Enabled = true;
            txtPorte.Enabled = true;
            txtSexo.Enabled = true;
            txtCor.Enabled = true;


            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnBuscar.Enabled = false;
            btnBuscarCli.Visible = true;
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteBO clienteBO = new ClienteBO();

            try
            {
                cliente.Cod = Convert.ToInt16(txtCodCli.Text);
                clienteBO.Buscar(cliente);

                if (cliente.Nome == "")
                {
                    MessageBox.Show("Cliente não encontrado");
                    txtCodCli.Clear();
                    txtCodCli.Enabled = true;

                }
                else
                {
                    txtNomeCli.Visible = true;
                    txtNomeCli.Text = cliente.Nome;
                }
            }

            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada;
            linhaSelecionada = dataGridView1.CurrentRow;

            txtCodigo.Text = linhaSelecionada.Cells[0].Value.ToString();
           // txtCodCli.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtNome.Text = linhaSelecionada.Cells[1].Value.ToString();
            txtEspecie.Text = linhaSelecionada.Cells[2].Value.ToString();
            txtRaca.Text = linhaSelecionada.Cells[3].Value.ToString();
            txtPorte.Text = linhaSelecionada.Cells[4].Value.ToString();
            txtSexo.Text = linhaSelecionada.Cells[5].Value.ToString();
            txtCor.Text = linhaSelecionada.Cells[6].Value.ToString();


            txtCodigo.Enabled = false;
            txtCodCli.Enabled = true;
            txtNome.Enabled = true;
            txtEspecie.Enabled = true;
            txtRaca.Enabled = true;
            txtPorte.Enabled = true;
            txtSexo.Enabled = true;
            txtCor.Enabled = true;

            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnBuscar.Enabled = false;
            btnBuscarCli.Visible = true;
        }

        private void btnBuscarPorNome_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            try
            {
                pet.Nome = txtNome.Text;

                dataGridView1.DataSource = petBO.BuscarPorPet(pet);
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
        }
    }   
}
