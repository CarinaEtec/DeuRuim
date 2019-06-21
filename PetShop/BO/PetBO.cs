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
            if ((pet.Nome != "") && (pet.Cliente.Cod != 0))
            {
                petDao.Insert(pet);
            }
        }


        public void Editar(Pet pet)
        {
            PetDAO petDao = new PetDAO();
            if ((pet.Nome != "") && (pet.Cliente.Cod != 0))
            {
                petDao.Update(pet);
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





        public void Buscar(Pet pet)
        {
            PetDAO livroDao = new PetDAO();

            if (pet.CodPet > 0)
            {
                var petTemp = livroDao.BuscaPorCod(pet.CodPet);
                pet.Cliente.Cod = petTemp.Cliente.Cod;
                pet.Nome = petTemp.Nome;
                pet.Especie = petTemp.Especie;
                pet.Raca = petTemp.Raca;
                pet.Porte = petTemp.Porte;
                pet.Sexo = petTemp.Sexo;
                pet.Cor = petTemp.Cor;
            }
        }
    }
}
