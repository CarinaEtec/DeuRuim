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
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();

            if (funcionario.Cod > 0)
            {
                var funcionarioTemp = funcionarioDao.BuscaPorCod(funcionario.Cod);

                funcionario.Nome = funcionarioTemp.Nome;
                funcionario.Cpf = funcionarioTemp.Cpf;
                funcionario.Cep = funcionarioTemp.Cep;
                funcionario.Endereco = funcionarioTemp.Endereco;
                funcionario.Cidade = funcionarioTemp.Cidade;
                funcionario.Numero = funcionarioTemp.Numero;
                funcionario.Telefone = funcionarioTemp.Telefone;

                funcionario.Carttrab = funcionarioTemp.Carttrab;
                funcionario.Salario = funcionarioTemp.Salario;

            }
        }
    }
}