using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    class Pet
    {

        private int codPet;
        private Cliente cliente;
        private string nome;
        private string especie;
        private string raca;
        private string porte;
        private string sexo;
        private string cor;

        public int CodPet { get => codPet; set => codPet = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca { get => raca; set => raca = value; }
        public string Porte { get => porte; set => porte = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cor { get => cor; set => cor = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
