using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    class Funcionario : Pessoa
    {
        private string carttrab;
        private double salario;

        public string Carttrab { get => carttrab; set => carttrab = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
