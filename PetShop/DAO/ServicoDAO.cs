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
    class ServicoDAO
    {
        public void Insert(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); 
                comando.CommandType = CommandType.Text; 
                comando.CommandText = "Insert into Servico(tipo,porte,valor) values(@tipo,@porte,@valor)";

                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@porte", servico.Porte);
                comando.Parameters.AddWithValue("@valor", servico.Valor);
                ConexaoBanco.CRUD(comando); 
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }

        public void Update(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); 
                comando.CommandType = CommandType.Text; 
                comando.CommandText = "Update servico set tipo=@tipo, porte=@porte, valor=@valor where codServ=@codServ";

                comando.Parameters.AddWithValue("@tipo", servico.Tipo);
                comando.Parameters.AddWithValue("@porte", servico.Porte);
                comando.Parameters.AddWithValue("@valor", servico.Valor);
                comando.Parameters.AddWithValue("@codServ", servico.CodServ);

                ConexaoBanco.CRUD(comando); 
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }

        public void Delete(Servico servico)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from servico where codServ=@codServ";

                comando.Parameters.AddWithValue("@codServ", servico.CodServ);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}
