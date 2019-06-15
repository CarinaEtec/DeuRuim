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
                comando.CommandText = "Insert into Pet(codCli,nome,especie,raca,porte,sexo,cor) " +
                    "values(@codCli,@nome,@especie,@raca,@porte,@sexo,@cor)";

                comando.Parameters.AddWithValue("@codCli", pet.Cliente);
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

                comando.Parameters.AddWithValue("@codCli", pet.Cliente);
                comando.Parameters.AddWithValue("@nome", pet.Nome);
                comando.Parameters.AddWithValue("@especie", pet.Especie);
                comando.Parameters.AddWithValue("@raca", pet.Raca);
                comando.Parameters.AddWithValue("@porte", pet.Porte);
                comando.Parameters.AddWithValue("@sexo", pet.Sexo);
                comando.Parameters.AddWithValue("@cor", pet.Cor);
                comando.Parameters.AddWithValue("@codcli", pet.CodPet);

                ConexaoBanco.CRUD(comando); // Está sendo enviado p/ o método CRUD
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
            comando.CommandText = "Select * from pet where codPet=@codPet"; //

            comando.Parameters.AddWithValue("@codpet", CodPet);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Pet pet = new Pet();
            if (dr.HasRows)
            {
                dr.Read();
                pet.CodPet = (int)dr["CodPet"];
                pet.Cliente = (Cliente)dr["codcli"];
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
                pet.Cliente = null;
                pet.Nome = "";
                pet.Especie = "";
                pet.Raca = "";
                pet.Porte = "";
                pet.Cor = "";
                pet.Sexo = "";
            }
            return pet;
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
    }
}

