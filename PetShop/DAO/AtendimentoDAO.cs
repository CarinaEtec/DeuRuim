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
    class AtendimentoDAO
    {

        public void Insert(Atendimento atendimento)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into Atendimento(Codserv,CodPet,CodFunc,DataHora,Situacao) " +
                    "values(@Codserv,@CodPet,@CodFunc,@DataHora,@Situacao)";

                comando.Parameters.AddWithValue("@Codserv", atendimento.Servico.CodServ);
                comando.Parameters.AddWithValue("@CodPet", atendimento.Pet.CodPet);
                comando.Parameters.AddWithValue("@CodFunc", atendimento.Funcionario.Cod);
                comando.Parameters.AddWithValue("@DataHora", atendimento.DataHora);
                comando.Parameters.AddWithValue("@Situacao", atendimento.Situacao);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }
        }
    }
}
