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
            if (cliente.Nome != "")// && (cliente.Cpf != ""))
            {
                clienteDao.Insert(cliente);
            }
        }

        public void Editar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            if ((cliente.Nome != "") )//&& (autor.Nacionalidade != ""))
            {
                clienteDao.Update(cliente);
            }
        }

        public void Buscar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            if (cliente.CodCli > 0)
            {
                var clienteTemp = clienteDao.BuscaPorId(cliente.CodCli);

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

        public void Deletar(Cliente cliente)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            if (cliente.CodCli > 0)
            {
                clienteDao.Delete(cliente);
            }
        }

        //public IList<Cliente> BuscarPorNome(Cliente cliente)
        //{
        //    ClienteDAO clienteDAO = new ClienteDAO();

        //    if (cliente.Nome != "")
        //    {
        //        IList<Cliente> clienteTemp = clienteDAO.BuscaPorCliente(cliente.Nome);
        //        return clienteTemp;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
