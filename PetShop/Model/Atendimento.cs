using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    class Atendimento
    {
        private int codAtend;
        private Servico servico;
        private Pet pet;
        private Funcionario funcionario;
        private DateTime dataHora;
        private string situacao;

        public Atendimento()
        {
            Servico = new Servico();
            Pet = new Pet();
            Funcionario = new Funcionario();
        }


        public int CodAtend { get => codAtend; set => codAtend = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        internal Servico Servico { get => servico; set => servico = value; }
        internal Pet Pet { get => pet; set => pet = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}
