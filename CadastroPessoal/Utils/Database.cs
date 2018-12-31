using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.Utils
{
    public class Database : IDisposable
    {
        SQLiteConnection conn = null;

        public void Dispose()
        {
            conn.Close();
        }

        public void executarComandoSQL(string sql)
        {
            
            string strConn = @"Data Source=pessoal_db.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public SQLiteDataReader executarReader(string sql)
        {
            
            SQLiteDataReader reader;

            string strConn = @"Data Source=pessoal_db.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }
    }
}
