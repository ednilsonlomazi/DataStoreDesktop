using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    
    internal class DALConexaoDatabase
    {
        private String _stringConexao;
        private SqlConnection _sqlConnection;

        public DALConexaoDatabase(String stringConexao)
        {
            this._sqlConnection = new SqlConnection(stringConexao);
            this._stringConexao = stringConexao; 
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._sqlConnection; }
            set { this._sqlConnection = value; }
        }

        public void Conectar()
        {
            this._sqlConnection.Open();
        }

        public void Desconectar()
        {
            this._sqlConnection.Close();
        }

    }
}
