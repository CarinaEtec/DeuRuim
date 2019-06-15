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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            PetBO petBO = new PetBO();

            pet.Cliente.Cod = Convert.ToInt16(txtCodCli.Text);
            pet.Nome = txtNome.Text;
            pet.Especie = txtEspecie.Text;
            pet.Raca = txtRaca.Text;
            pet.Sexo = txtSexo.Text;
            pet.Porte = txtPorte.Text;
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            btnBuscarPet.Visible = true;
            btnNovo.Enabled = false;
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
                    txtCodCli.Clear();
                    txtNome.Clear();
                    txtEspecie.Clear();
                    txtRaca.Clear();
                    txtPorte.Clear();
                    txtSexo.Clear();
                    txtCor.Clear();
                }
                else
                {
                    pet.CodPet = Convert.ToInt16(txtCodigo.Text);
                    pet.Cliente.Cod = Convert.ToInt16(txtCodCli.Text);
                    pet.Nome = txtNome.Text;
                    pet.Especie = txtEspecie.Text;
                    pet.Raca = txtRaca.Text;
                    pet.Sexo = txtSexo.Text;
                    pet.Porte = txtPorte.Text;
                    pet.Cor = txtCor.Text;
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
            txtCodCli.Enabled = true;
            txtNome.Enabled = true;
            txtEspecie.Enabled = true;
            txtRaca.Enabled = true;
            txtPorte.Enabled = true;
            txtSexo.Enabled = true;
            txtCor.Enabled = true;
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
    }
}
