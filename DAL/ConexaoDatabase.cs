using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    
    internal class ConexaoDatabase
    {
        private String _stringConexao;
        private SqlConnection _sqlConnection;

        public ConexaoDatabase(String stringConexao)
        {
            this._sqlConnection = new SqlConnection(stringConexao);
            this._stringConexao = stringConexao; 
        }

    }
}
