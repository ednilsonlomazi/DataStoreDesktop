using Microsoft.Data.SqlClient;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTabDocumento
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public DALTabDocumento(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;
        }

        public void Insert(TabDocumento tabDocumento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "INSERT INTO [dbdatastore].[dbo].[tabDocumento]\r\n  (idCliente, idAvaliador, codigoStatusDocumento, dataSolicitacao, dataFinalizacaoAvaliacao) VALUES\r\n  (@idCliente, @idAvaliador, @codigoStatusDocumento, @dataSolicitacao, @dataFinalizacaoAvaliacao); " +
                              "SELECT @@IDENTITY; ";
                
            cmd.Parameters.AddWithValue("@idCliente", tabDocumento.idCliente);
            cmd.Parameters.AddWithValue("@idAvaliador", tabDocumento.idAvaliador);
            cmd.Parameters.AddWithValue("@codigoStatusDocumento", tabDocumento.codigoStatusDocumento);
            cmd.Parameters.AddWithValue("@dataSolicitacao", tabDocumento.dataSolicitacao);
            cmd.Parameters.AddWithValue("@dataFinalizacaoAvaliacao", tabDocumento.dataFinalizacaoAvaliacao);

            dalConexaoDatabase.Conectar();
            tabDocumento.codigoDocumento = Convert.ToInt32(cmd.ExecuteScalar());
            dalConexaoDatabase.Desconectar();
        }

        public void Update(TabDocumento tabDocumento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "UPDATE [dbdatastore].[dbo].[tabDocumento]\r\n  SET idCliente = @idCliente, idAvaliador = @idAvaliador, codigoStatusDocumento = @codigoStatusDocumento, dataSolicitacao = @dataSolicitacao, dataFinalizacaoAvaliacao = @dataFinalizacaoAvaliacao) WHERE codigoDocumento = @codigoDocumento; ";
            cmd.Parameters.AddWithValue("@idCliente", tabDocumento.idCliente);
            cmd.Parameters.AddWithValue("@idAvaliador", tabDocumento.idAvaliador);
            cmd.Parameters.AddWithValue("@codigoStatusDocumento", tabDocumento.codigoStatusDocumento);
            cmd.Parameters.AddWithValue("@dataSolicitacao", tabDocumento.dataSolicitacao);
            cmd.Parameters.AddWithValue("@dataFinalizacaoAvaliacao", tabDocumento.dataFinalizacaoAvaliacao);

            dalConexaoDatabase.Conectar();
            cmd.ExecuteNonQuery();
            dalConexaoDatabase.Desconectar();
        }

        public void Cancelar(TabDocumento tabStatusDocumento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "UPDATE [dbdatastore].[dbo].[tabStatusDocumentos]\r\nSET codigoStatusDocumento = 6 WHERE codigoDocumento = @codigoDocumento; ";
            cmd.Parameters.AddWithValue("@codigoDocumento", tabStatusDocumento.codigoDocumento);

            dalConexaoDatabase.Conectar();
            cmd.ExecuteNonQuery();
            dalConexaoDatabase.Desconectar();
        }

        public DataTable SelectByCod(int codigo)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [dbdatastore].[dbo].[tabDocumento] td WITH (NOLOCK) WHERE td.codigoDocumento = " + Convert.ToString(codigo) + ";", dalConexaoDatabase.ObjetoConexao);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public List<TabDocumento> SelectAll()
        {
            TabDocumento tabDocumento = new TabDocumento();
            List<TabDocumento> listTabDocumento = new List<TabDocumento>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dalConexaoDatabase.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM [dbdatastore].[dbo].[tabDocumento] td WITH (NOLOCK) WHERE td.codigoDocumento <> 6;";
                dalConexaoDatabase.Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabDocumento = new TabDocumento();
                        tabDocumento.idCliente = Convert.ToString(reader["idCliente"]);
                        tabDocumento.idAvaliador = Convert.ToString(reader["idAvaliador"]);
                        

                        listTabDocumento.Add(tabDocumento);

                    }
                }
                reader.Close();
            }
            catch (Exception ex) 
            {
                throw new Exception("Algo de errado na camada DAL\n" + ex.Message);
            }
            finally
            {
                dalConexaoDatabase.Desconectar();
            }

            return listTabDocumento;
        }
    }
}
