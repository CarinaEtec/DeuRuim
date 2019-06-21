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





        public Servico BuscaPorCod(int CodServ)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from servico where CodServ=@CodServ";

            comando.Parameters.AddWithValue("@CodServ", CodServ);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Servico servico = new Servico();
            if (dr.HasRows)
            {
                dr.Read();
                servico.CodServ = (int)dr["CodServ"];
                servico.Tipo = (string)dr["Tipo"];
                servico.Porte = (string)dr["Porte"];
                servico.Valor = (Decimal)dr["Valor"];


            }
            else
            {
                servico.CodServ = 0;
                servico.Tipo = "";
                servico.Porte = "";
                servico.Valor = 0;

            }
            return servico;
        }
    }
}
