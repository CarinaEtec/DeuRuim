using PetShop.DAO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BO
{
    class ServicoBO
    {
        public void Gravar(Servico servico)
        {
            ServicoDAO servicoDao = new ServicoDAO();
            if ((servico.Tipo != "") && (servico.Porte != "") && (servico.Valor != 0))
            {
                servicoDao.Insert(servico);
            }
        }

        public void Editar(Servico serv)
        {
            ServicoDAO servDao = new ServicoDAO();
            if (serv.Tipo != "")
            {
                servDao.Update(serv);
            }
        }




        public void Deletar(Servico servico)
        {
            ServicoDAO servicoDao = new ServicoDAO();

            if (servico.CodServ > 0)
            {
                servicoDao.Delete(servico);
            }
        }






    }
}
