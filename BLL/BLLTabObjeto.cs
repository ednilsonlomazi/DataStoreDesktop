using DAL;
using Microsoft.Data.SqlClient;
using MODEL;
using System.Data;

namespace BLL
{
    public class BLLTabObjeto
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public BLLTabObjeto(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;
        }

            

        public List<TabObjetoDTO> SelectAll(TabObjetoDTO dto)
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectAll(dto);
        }

        public DataTable SelectDistinctServername()
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectDistinctServername();
        }

        public DataTable SelectDistinctDatabaseName()
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectDistinctDatabaseName();
        }

        public DataTable SelectDistinctTipoObjeto()
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectDistinctTipoObjeto();
        }

        public DataTable SelectDistinctSchema()
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectDistinctSchema();
        }

        public DataTable SelectDistinctClasse()
        {
            DALTabObjeto dalTabObjeto = new DALTabObjeto(dalConexaoDatabase);
            return dalTabObjeto.SelectDistinctClasse();
        }
    }
}
