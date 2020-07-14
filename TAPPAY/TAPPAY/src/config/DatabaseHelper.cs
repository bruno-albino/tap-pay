using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPPAY.src.config
{
    public class DatabaseHelper
    {
        public MySqlConnection mySqlConnection { get; set; }
        public string connectionString { get; set; }


        public DatabaseHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ConexaoMYSQL"].ToString();
            this.mySqlConnection = new MySqlConnection(connectionString);
        }

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
            this.mySqlConnection = new MySqlConnection(connectionString);
        }

        private string GetCorrectParameterName(string parameterName)
        {
            if (parameterName[0] != '@')
            {
                parameterName = "@" + parameterName;
            }
            return parameterName;
        }


        public static DatabaseHelper Create()
        {
            return new DatabaseHelper();
        }

        public static DatabaseHelper Create(string nomeStringConexao)
        {
            return new DatabaseHelper(nomeStringConexao);
        }

        public void OpenConnection()
        {
            if (this.mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                this.mySqlConnection.Open();
            }
        }

        public void CloseConection()
        {
            this.mySqlConnection.Close();
        }

        public MySqlParameter BuildParameter(string nome, object valor, DbType tipo, int size)
        {
            MySqlParameter parametro = new MySqlParameter(this.GetCorrectParameterName(nome), valor);
            parametro.DbType = tipo;
            parametro.Size = size;
            return parametro;
        }

        public void ExecuteNonQuery(MySqlCommand command)
        {
            command.ExecuteNonQuery();
        }


        public void ExecuteNonQuery(MySqlCommand command, bool openConnection)
        {
            if (openConnection)
            {
                this.OpenConnection();
            }
            this.ExecuteNonQuery(command);
            if (openConnection)
            {
                this.CloseConection();
            }
        }

        public void ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            Exception erro = null;
            try
            {
                this.OpenConnection();
                MySqlCommand command = this.mySqlConnection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                this.ExecuteNonQuery(command);
                this.CloseConection();
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                this.CloseConection();
            }

            if (erro != null)
            {
                throw erro;
            }
        }

        ///  MÉTODO COM TRANSACTION
        public void ExecuteCommands(params MySqlCommand[] commands)
        {
            Exception erro = null;
            MySqlTransaction trans = null;
            try
            {
                this.mySqlConnection.Open();
                trans = this.mySqlConnection.BeginTransaction();
                for (int i = 0; i < commands.Length; i++)
                {
                    commands[i].Transaction = trans;
                    this.ExecuteNonQuery(commands[i]);
                }
                trans.Commit();
                this.mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                erro = ex;
            }
            finally
            {
                this.mySqlConnection.Close();
            }

            if (erro != null)
            {
                throw erro;
            }
        }

        public MySqlDataReader ExecuteDataReader(string query, MySqlParameter parameters)
        {
            try
            {
                this.OpenConnection();
                MySqlCommand command = this.mySqlConnection.CreateCommand();
                command.CommandText = query;
                command.Parameters.Add(parameters);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
