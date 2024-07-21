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
    internal class DALTabStatusDocumento
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public DALTabStatusDocumento(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;        
        }

        public void Insert(TabStatusDocumento tabStatusDocumento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "INSERT INTO [dbdatastore].[dbo].[tabStatusDocumentos]\r\n(DescricaoStatus,indAtivo) VALUES\r\n(@DescricaoStatus, @indAtivo);\r\n SELECT @@IDENTITY; ";
            cmd.Parameters.AddWithValue("@DescricaoStatus", tabStatusDocumento.DescricaoStatus);

            dalConexaoDatabase.Conectar();
            tabStatusDocumento.codigoStatus = Convert.ToInt32(cmd.ExecuteScalar());
            dalConexaoDatabase.Desconectar();
        }

        public void Update(TabStatusDocumento tabStatusDocumento) 
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "UPDATE [dbdatastore].[dbo].[tabStatusDocumentos]\r\nSET DescricaoStatus = @DescricaoStatus, indAtivo = @indAtivo WHERE codigoStatus = @codigoStatus; ";
            cmd.Parameters.AddWithValue("@DescricaoStatus", tabStatusDocumento.DescricaoStatus);
            cmd.Parameters.AddWithValue("@indAtivo", tabStatusDocumento.indAtivo);
            cmd.Parameters.AddWithValue("@codigoStatus", tabStatusDocumento.codigoStatus);

            dalConexaoDatabase.Conectar();
            cmd.ExecuteNonQuery();
            dalConexaoDatabase.Desconectar();
        }

        public void Delete(TabStatusDocumento tabStatusDocumento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "UPDATE [dbdatastore].[dbo].[tabStatusDocumentos]\r\nSET indAtivo = 0 WHERE codigoStatus = @codigoStatus; ";
            cmd.Parameters.AddWithValue("@codigoStatus", tabStatusDocumento.codigoStatus);

            dalConexaoDatabase.Conectar();
            cmd.ExecuteNonQuery();
            dalConexaoDatabase.Desconectar();
        }

        public DataTable SelectByCod(int codigo)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [dbdatastore].[dbo].[tabStatusDocumentos] tsd WITH (NOLOCK) WHERE tsd.codigoStatus = " + Convert.ToString(codigo) + ";", dalConexaoDatabase.ObjetoConexao);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public TabStatusDocumento SelectAll()
        {
            TabStatusDocumento tabstatusDocumento = new TabStatusDocumento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dalConexaoDatabase.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM [dbdatastore].[dbo].[tabStatusDocumentos] tsd WITH (NOLOCK) WHERE tsd.indAtivo = 1;";
            dalConexaoDatabase.Conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tabstatusDocumento.codigoStatus = Convert.ToInt32(reader["codigoStatus"]);
                tabstatusDocumento.DescricaoStatus = Convert.ToString(reader["DescricaoStatus"]);
                tabstatusDocumento.indAtivo = Convert.ToInt32(reader["indAtivo"]);
            }
            dalConexaoDatabase.Desconectar();
            return tabstatusDocumento;
        }
    }
}
