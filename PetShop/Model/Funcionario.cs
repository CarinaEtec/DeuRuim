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
        private decimal salario;

        public string Carttrab { get => carttrab; set => carttrab = value; }
        public decimal Salario { get => salario; set => salario = value; }
    }
}
