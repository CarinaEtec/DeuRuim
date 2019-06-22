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
    class PetDAO
    {

        public void Insert(Pet pet)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Pet(codcli,nome,especie,raca,porte,sexo,cor) values(@codcli,@nome,@especie,@raca,@porte,@sexo,@cor)";

                comando.Parameters.AddWithValue("@codCli", pet.Cliente.Cod);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Update(Pet pet)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Update pet set codCli=@codCli, nome=@nome, especie=@especie, raca=@raca, porte=@porte, " +
                    " sexo=@sexo, cor=@cor where codPet=@codPet";

                comando.Parameters.AddWithValue("@codCli", pet.Cliente.Cod);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);
                comando.Parameters.AddWithValue("@codPet", pet.CodPet);

                ConexaoBanco.CRUD(comando); // Está sendo enviado p/ o método CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public void Delete(Pet pet)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from pet where codpet=@codpet";

                comando.Parameters.AddWithValue("@codpet", pet.CodPet);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }

        public Pet BuscaPorCod(int CodPet)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Pet where CodPet=@CodPet";

            comando.Parameters.AddWithValue("@CodPet", CodPet);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Pet pet = new Pet();
            if (dr.HasRows)
            {
                dr.Read();
                pet.Cliente.Cod = (int)dr["CodCli"];
                pet.Nome = (string)dr["nome"];
                pet.Especie = (string)dr["especie"];
                pet.Raca = (string)dr["raca"];
                pet.Porte = (string)dr["porte"];
                pet.Sexo = (string)dr["sexo"];
                pet.Cor = (string)dr["cor"];
            }
            else
            {
                pet.CodPet = 0;
                pet.Cliente.Cod = 0;
                pet.Nome = "";
                pet.Especie = "";
                pet.Raca = "";
                pet.Porte = "";
                pet.Sexo = "";
                pet.Cor = "";
            }
            return pet;
        }



        public Cliente BuscaPorTutor(int CodCli)
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

            }
            else
            {
                cliente.Cod = 0;
            }
            return cliente;
        }
    }
}   






   