using PetShop.DAO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BO
{
    class PetBO
    {
        public void Gravar(Pet pet)
        {
            PetDAO petDao = new PetDAO();
            if ((pet.Nome != "")) //&& (cliente.Telefone != ""))
            {
                petDao.Insert(pet);
            }
        }

        public void Editar(Pet pet)
        {
            PetDAO petDao = new PetDAO();
            if ((pet.Nome != ""))
            {
                petDao.Update(pet);
            }
        }

        public void Buscar(Pet pet)
        {
            PetDAO petDao = new PetDAO();

            if (pet.CodPet > 0)
            {
                var petTemp = petDao.BuscaPorCod(pet.CodPet);

                pet.CodPet = petTemp.CodPet;
                pet.Cliente = petTemp.Cliente;
                pet.Nome = petTemp.Nome;
                pet.Especie = petTemp.Especie;
                pet.Raca = petTemp.Raca;
                pet.Porte = petTemp.Porte;
                pet.Sexo = petTemp.Sexo;
                pet.Cor = petTemp.Cor;


            }
        }

        public void Deletar(Pet pet)
        {
            PetDAO petDao = new PetDAO();

            if (pet.CodPet > 0)
            {
                petDao.Delete(pet);
            }
        }

    }
}