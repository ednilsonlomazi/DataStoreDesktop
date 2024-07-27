using DAL;
using Microsoft.Data.SqlClient;
using MODEL;
using System.Data;

namespace BLL
{
    public class BLLTabDocumento
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public BLLTabDocumento(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;
        }

        public void Insert(TabDocumento tabDocumento)
        {
            DALTabDocumento dalTabDocumento = new DALTabDocumento(dalConexaoDatabase);
            dalTabDocumento.Insert(tabDocumento);
        }

        public void Update(TabDocumento tabDocumento)
        {

            if (tabDocumento.codigoStatusDocumento == 6) 
            {
                throw new Exception("Documentos Cancelados nao podem ser atualizados");
            }
            DALTabDocumento dalTabDocumento = new DALTabDocumento(dalConexaoDatabase);
            dalTabDocumento.Update(tabDocumento);

        }

        public void Cancelar(TabDocumento tabDocumento)
        {
            DALTabDocumento dalTabDocumento = new DALTabDocumento(dalConexaoDatabase);
            dalTabDocumento.Cancelar(tabDocumento);
        }

        public DataTable SelectByCod(int codigo)
        {
            DALTabDocumento dalTabDocumento = new DALTabDocumento(dalConexaoDatabase);
            return dalTabDocumento.SelectByCod(codigo);
        }

        public List<TabDocumento> SelectAll()
        {
            DALTabDocumento dalTabDocumento = new DALTabDocumento(dalConexaoDatabase);
            return dalTabDocumento.SelectAll();
        }
    }
}
