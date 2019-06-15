using MySql.Data.MySqlClient;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.DAO
{
    class FuncionarioDAO
    {
        public void Insert(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Funcionario(nome,cpf,cep,endereco,cidade,numero,telefone,carttrab,salario) " +
                    "values(@nome,@cpf,@cep,@endereco,@cidade,@numero,@telefone,@carttrab,@salario)";

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.Carttrab);//
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update funcionario set nome=@nome, cpf=@cpf, cep=@cep, endereco=@endereco, cidade=@cidade, " +
                    " numero=@numero, telefone=@telefone, email=@email, carttrab=@carttrab, salario=@salario where codfunc=@codfunc";

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@cep", funcionario.Cep);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                comando.Parameters.AddWithValue("@numero", funcionario.Numero);//
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@carttrab", funcionario.Carttrab);//
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);
                comando.Parameters.AddWithValue("@codfunc", funcionario.Cod);

                ConexaoBanco.CRUD(comando); 
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public Funcionario BuscaPorCod(int Cod)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from funcionario where codfunc=@codfunc";

            comando.Parameters.AddWithValue("@codfunc", Cod);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Funcionario funcionario = new Funcionario();
            if (dr.HasRows)
            {
                dr.Read();
                funcionario.Cod = (int)dr["CodFunc"];
                funcionario.Nome = (string)dr["nome"];
                funcionario.Cpf = (long)dr["cpf"];
                funcionario.Cep = (string)dr["cep"];
                funcionario.Endereco = (string)dr["endereco"];
                funcionario.Cidade = (string)dr["cidade"];
                funcionario.Numero = (string)dr["numero"];
                funcionario.Telefone = (string)dr["telefone"];

                funcionario.Carttrab = (string)dr["carttrab"];
                funcionario.Salario = (double)dr["salario"];
            }
            else
            {
                funcionario.Cod = 0;
                funcionario.Nome = "";
                funcionario.Cpf = 0;
                funcionario.Cep = "";
                funcionario.Endereco = "";
                funcionario.Cidade = "";
                funcionario.Numero = "";
                funcionario.Telefone = "";
                funcionario.Carttrab = "";
                funcionario.Salario = 0;
            }
            return funcionario;
        }

        public void Delete(Funcionario funcionario)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from funcionario where codfunc=@codFunc";

                comando.Parameters.AddWithValue("@codfunc", funcionario.Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}
