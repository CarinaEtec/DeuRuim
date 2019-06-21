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
    class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Cliente(nome,cpf,cep,endereco,cidade,numero,telefone,email) " +
                    "values(@nome,@cpf,@cep,@endereco,@cidade,@numero,@telefone,@email)";

                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }


        public void Delete(Cliente cliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from cliente where codcli=@codcli";

                comando.Parameters.AddWithValue("@codcli", cliente.Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }



        public void Update(Cliente cliente)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update cliente set nome=@nome, cpf=@cpf, cep=@cep, endereco=@endereco, cidade=@cidade, " +
                    "numero=@numero, telefone=@telefone, email=@email where codcli=@codcli";

                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@cep", cliente.Cep);
                comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                comando.Parameters.AddWithValue("@numero", cliente.Numero);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@codcli", cliente.Cod);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }


        public Cliente BuscaPorCod(int CodCli) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from cliente where codcli=@codcli";

            comando.Parameters.AddWithValue("@codcli", CodCli);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Cliente cliente = new Cliente();
            if (dr.HasRows)
            {
                dr.Read();
                cliente.Cod = (int)dr["CodCli"];
                cliente.Nome = (string)dr["nome"];
                cliente.Cpf = (long)dr["cpf"];
                cliente.Cep = (string)dr["cep"];
                cliente.Endereco = (string)dr["endereco"];
                cliente.Cidade = (string)dr["cidade"];
                cliente.Numero = (string)dr["numero"];
                cliente.Telefone = (string)dr["telefone"];
                cliente.Email = (string)dr["email"];
            }
            else
            {
                cliente.Cod = 0;
                cliente.Nome = "";
                cliente.Cpf = 0;
                cliente.Cep = "";
                cliente.Endereco = "";
                cliente.Cidade = "";
                cliente.Numero = "";
                cliente.Telefone = "";
                cliente.Email = "";
            }
            return cliente;
        }
    }
}
