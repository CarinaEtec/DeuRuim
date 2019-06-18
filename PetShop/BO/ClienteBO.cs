using PetShop.DAO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BO
{
    class ClienteBO
    {
        public void Gravar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            if ((cliente.Nome != "") && (cliente.Telefone != ""))
            {
                clienteDao.Insert(cliente);
            }
        }

        public void Deletar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            if (cliente.Cod > 0)
            {
                clienteDao.Delete(cliente);
            }
        }


        public void Editar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            if (cliente.Nome != "") 
            {
                clienteDao.Update(cliente);
            }
        }

        public void Buscar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            if (cliente.Cod > 0)
            {

                var clienteTemp = clienteDao.BuscaPorCod(cliente.Cod);

                cliente.Nome = clienteTemp.Nome;
                cliente.Cpf = clienteTemp.Cpf;
                cliente.Cep = clienteTemp.Cep;
                cliente.Endereco = clienteTemp.Endereco;
                cliente.Cidade = clienteTemp.Cidade;
                cliente.Numero = clienteTemp.Numero;
                cliente.Telefone = clienteTemp.Telefone;
                cliente.Email = clienteTemp.Email;
            }
        }
    }
}
