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


        public Atendimento BuscaPorAtendimento(int CodAtend)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from atendimento where codatend=@codatend";

            comando.Parameters.AddWithValue("@codatend", CodAtend);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Atendimento atendimento = new Atendimento();
            if (dr.HasRows)
            {
                dr.Read();
                atendimento.CodAtend = (int)dr["CodAtend"];
                atendimento.Servico.CodServ = (int)dr["CodServ"];
                atendimento.Pet.CodPet = (int)dr["CodPet"];
                atendimento.Funcionario.Cod = (int)dr["CodFunc"];
                atendimento.DataHora = (DateTime)dr["DataHora"];
                atendimento.Situacao = (string)dr["situacao"];
            }
            else
            {
                atendimento.CodAtend = 0;
                atendimento.Servico.CodServ = 0;
                atendimento.Pet.CodPet = 0;
                atendimento.Funcionario.Cod = 0;
                atendimento.Situacao = "";

            }
            return atendimento;
        }


        public Atendimento BuscaPorFuncionario(int CodFunc)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from atendimento where CodFunc=@CodFunc";

            comando.Parameters.AddWithValue("@CodFunc", CodFunc);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Atendimento atendimento = new Atendimento();
            if (dr.HasRows)
            {
                dr.Read();
                atendimento.CodAtend = (int)dr["CodAtend"];
                atendimento.Servico.CodServ = (int)dr["CodServ"];
                atendimento.Pet.CodPet = (int)dr["CodPet"];
                atendimento.Funcionario.Cod = (int)dr["CodFunc"];
                atendimento.DataHora = (DateTime)dr["DataHora"];
                atendimento.Situacao = (string)dr["situacao"];
            }
            else
            {
                atendimento.CodAtend = 0;
                atendimento.Servico.CodServ = 0;
                atendimento.Pet.CodPet = 0;
                atendimento.Funcionario.Cod = 0;
                atendimento.Situacao = "";

            }
            return atendimento;
        }


    }
}
