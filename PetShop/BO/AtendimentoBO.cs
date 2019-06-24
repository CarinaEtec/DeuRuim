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

        public void BuscarAtendimento(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();

            if (atendimento.CodAtend > 0)
            {
                var atendimentoTemp = atendimentoDAO.BuscaPorAtendimento(atendimento.CodAtend);

                atendimento.Servico.CodServ = atendimentoTemp.Servico.CodServ;
                atendimento.Pet.CodPet = atendimentoTemp.Pet.CodPet;
                atendimento.Funcionario.Cod = atendimentoTemp.Funcionario.Cod;
                atendimento.DataHora = atendimentoTemp.DataHora;
                atendimento.Situacao = atendimentoTemp.Situacao;

            }
        }



        public void BuscaPorFuncionario(Atendimento atendimento)
        {
            AtendimentoDAO atendimentoDAO = new AtendimentoDAO();

            if (atendimento.Funcionario.Cod > 0)
            {
                var atendimentoTemp = atendimentoDAO.BuscaPorAtendimento(atendimento.Funcionario.Cod);

                atendimento.CodAtend = atendimentoTemp.CodAtend;
                atendimento.Servico.CodServ = atendimentoTemp.Servico.CodServ;

                atendimento.Pet.CodPet = atendimentoTemp.Pet.CodPet;
                atendimento.DataHora = atendimentoTemp.DataHora;
                atendimento.Situacao = atendimentoTemp.Situacao;

            }
        }

    }
}
