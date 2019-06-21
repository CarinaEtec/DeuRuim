using PetShop.DAO;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BO
{
    class FuncionarioBO
    {
        public void Gravar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            if ((funcionario.Nome != "") && (funcionario.Telefone != ""))
            {
                funcionarioDao.Insert(funcionario);
            }
        }

        public void Deletar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();

            if (funcionario.Cod > 0)
            {
                funcionarioDao.Delete(funcionario);
            }
        }

        public void Editar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            if (funcionario.Nome != "")
            {
                funcionarioDao.Update(funcionario);
            }
        }







        public void Buscar(Funcionario funcionario)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            if (funcionario.Cod > 0)
            {

                var clienteTemp = funcionarioDAO.BuscaPorCod(funcionario.Cod);

                funcionario.Nome = clienteTemp.Nome;
                funcionario.Cpf = clienteTemp.Cpf;
                funcionario.Cep = clienteTemp.Cep;
                funcionario.Endereco = clienteTemp.Endereco;
                funcionario.Cidade = clienteTemp.Cidade;
                funcionario.Numero = clienteTemp.Numero;
                funcionario.Telefone = clienteTemp.Telefone;
                funcionario.Carttrab = clienteTemp.Carttrab;
                funcionario.Salario = clienteTemp.Salario;

            }
        }
    }
}
