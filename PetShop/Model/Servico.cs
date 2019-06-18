using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    class Servico
    {
        private int codServ;
        private string tipo;
        private string porte;
        private double valor;

        public int CodServ { get => codServ; set => codServ = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Porte { get => porte; set => porte = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
