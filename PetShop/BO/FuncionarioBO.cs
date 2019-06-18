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

                var funcionarioTemp = funcionarioDAO.BuscaPorCod(funcionario.Cod);

                funcionario.Nome = funcionario.Nome;
                funcionario.Cpf = funcionario.Cpf;
                funcionario.Cep = funcionario.Cep;
                funcionario.Endereco = funcionario.Endereco;
                funcionario.Cidade = funcionario.Cidade;
                funcionario.Numero = funcionario.Numero;
                funcionario.Telefone = funcionario.Telefone;

                funcionario.Carttrab = funcionario.Carttrab;
                funcionario.Salario = funcionario.Salario;



            }
        }
    }
}
