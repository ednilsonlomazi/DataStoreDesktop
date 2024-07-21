using DAL;
using Microsoft.Data.SqlClient;
using MODEL;
using System.Data;

namespace BLL
{
    public class BLLTabStatusDocumento
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public BLLTabStatusDocumento(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;
        }

        public void Insert(TabStatusDocumento tabStatusDocumento)
        {
            if (tabStatusDocumento.DescricaoStatus.Trim().Length == 0) 
            {
                throw new Exception("O campo Descricao nao pode estar em branco");
            }

            DALTabStatusDocumento dalTabStatusDocumento = new DALTabStatusDocumento(dalConexaoDatabase);
            dalTabStatusDocumento.Insert(tabStatusDocumento);            
        }

        public void Update(TabStatusDocumento tabStatusDocumento)
        {
            if (tabStatusDocumento.codigoStatus <= 0) 
            {
                throw new Exception("Código de status inválido");
            }

            if (tabStatusDocumento.DescricaoStatus.Trim().Length == 0)
            {
                throw new Exception("O campo Descricao nao pode estar em branco");
            }

            DALTabStatusDocumento dalTabStatusDocumento = new DALTabStatusDocumento(dalConexaoDatabase);
            dalTabStatusDocumento.Update(tabStatusDocumento);

        }

        public void Delete(TabStatusDocumento tabStatusDocumento)
        {
            DALTabStatusDocumento dalTabStatusDocumento = new DALTabStatusDocumento(dalConexaoDatabase);
            dalTabStatusDocumento.Delete(tabStatusDocumento);
        }

        public DataTable SelectByCod(int codigo)
        {
            DALTabStatusDocumento dalTabStatusDocumento = new DALTabStatusDocumento(dalConexaoDatabase);
            return dalTabStatusDocumento.SelectByCod(codigo);
        }

        public TabStatusDocumento SelectAll()
        {
            DALTabStatusDocumento dalTabStatusDocumento = new DALTabStatusDocumento(dalConexaoDatabase);
            return dalTabStatusDocumento.SelectAll();
        }
    }
}
