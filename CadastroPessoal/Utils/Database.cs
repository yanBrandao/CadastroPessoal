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
        public string strConn = @"Data Source=ROS_DB.db";

        public void Dispose()
        {
            conn.Close();
        }

        public void executeCommandSQL(string sql)
        {
            
            
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

        public long executeSelectScalarSQL(string sql)
        {
            long scalar = -1;
            string strConn = @"Data Source=ROS_DB.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                scalar = (long)command.ExecuteScalar();

            }
            catch (Exception)
            {
                scalar = -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return scalar;
        }

        public long executeScalarSQL(string sql)
        {
            long scalar = -1;
            string strConn = @"Data Source=ROS_DB.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                string lastRowSQL = @"select last_insert_rowid()";
                command = new SQLiteCommand(lastRowSQL, conn);
                scalar = (long) command.ExecuteScalar();
                
            }
            catch (Exception ex)
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
            return scalar;
        }


        public SQLiteDataReader executeReader(string sql)
        {
            
            SQLiteDataReader reader;

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
