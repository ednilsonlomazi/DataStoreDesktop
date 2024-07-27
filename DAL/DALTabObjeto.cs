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
    public class DALTabObjeto
    {
        private DALConexaoDatabase dalConexaoDatabase;
        public DALTabObjeto(DALConexaoDatabase dalConexao)
        {
            this.dalConexaoDatabase = dalConexao;
        }

 
        public List<TabObjetoDTO> SelectAll(TabObjetoDTO dto)
        {
            TabObjetoDTO tabObjeto = new TabObjetoDTO();
            List<TabObjetoDTO> listTabDocumento = new List<TabObjetoDTO>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = dalConexaoDatabase.ObjetoConexao;


                cmd.CommandText = "  SELECT tobj.serverName,\r\n\t     tobj.DatabaseName,\r\n\t\t tobj.desc_schema,\r\n\t\t tobj.ObjectName,\r\n\t\t UPPER(tobj.descricaoTipoObjeto) descricaoTipoObjeto,\r\n\t\t tco.DescricaoClasse\r\n\t\t \r\n  FROM [dbdatastore].dbo.tabObjeto tobj WITH (NOLOCK)\r\n\tINNER JOIN [dbdatastore].dbo.tabClasseObjeto tco WITH (NOLOCK)\r\n\t\tON tobj.idClasseObjeto = tco.IdClasse";
                                  //"WHERE 1 = 1\r\n\tAND tobj.serverName = ISNULL(@serverName, tobj.serverName)\r\n\tAND tobj.DatabaseName = ISNULL(@DatabaseName, tobj.DatabaseName)\r\n\tAND tobj.desc_schema = ISNULL(@desc_schema, tobj.desc_schema) \r\n    AND tobj.ObjectName = ISNULL(@ObjectName, tobj.ObjectName)\r\n    AND tobj.descricaoTipoObjeto = ISNULL(@descricaoTipoObjeto, tobj.descricaoTipoObjeto)\r\n    AND tco.DescricaoClasse = ISNULL(@DescricaoClasse, tco.DescricaoClasse)";
                //cmd.Parameters.AddWithValue("@serverName", dto.serverName);
                //cmd.Parameters.AddWithValue("@DatabaseName", dto.DatabaseName);
                //cmd.Parameters.AddWithValue("@desc_schema", dto.desc_schema);
                //cmd.Parameters.AddWithValue("@ObjectName", dto.ObjectName);
                //cmd.Parameters.AddWithValue("@descricaoTipoObjeto", dto.descricaoTipoObjeto);
                //cmd.Parameters.AddWithValue("@DescricaoClasse", dto.classeObjeto);

                dalConexaoDatabase.Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabObjeto = new TabObjetoDTO();
                        
                        tabObjeto.serverName = Convert.ToString(reader["serverName"]);
                        tabObjeto.DatabaseName = Convert.ToString(reader["DatabaseName"]);
                        tabObjeto.desc_schema = Convert.ToString(reader["desc_schema"]);
                        tabObjeto.ObjectName = Convert.ToString(reader["ObjectName"]);
                        tabObjeto.descricaoTipoObjeto = Convert.ToString(reader["descricaoTipoObjeto"]);
                        tabObjeto.classeObjeto = Convert.ToString(reader["DescricaoClasse"]);

                        listTabDocumento.Add(tabObjeto);

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
