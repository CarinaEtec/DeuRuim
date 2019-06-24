using PetShop.DAO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BO
{
    class AtendimentoBO
    {
        public void Gravar(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDao = new AtendimentoDAO();
            if ((atendimento.Servico.CodServ != 0) && (atendimento.Pet.CodPet != 0) && (atendimento.Funcionario.Cod != 0))
            {
                atendimentoDao.Insert(atendimento);
            }
        }
    }
}
