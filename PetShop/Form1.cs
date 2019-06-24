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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente clientes = new frmCliente();
            clientes.Closed += (s, args) => this.Close();
            clientes.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFuncionario funcionarios = new frmFuncionario();
            funcionarios.Closed += (s, args) => this.Close();
            funcionarios.Show();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPet pet = new frmPet();
            pet.Closed += (s, args) => this.Close();
            pet.Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServico servico = new frmServico();
            servico.Closed += (s, args) => this.Close();
            servico.Show();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAtendimento atendimento = new frmAtendimento();
            atendimento.Closed += (s, args) => this.Close();
            atendimento.Show();
        }
    }
}
