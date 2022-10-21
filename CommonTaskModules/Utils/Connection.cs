using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTaskModules.Utils
{
    public class Connection
    {

        public static OracleConnection GetConnection()
        {
            return new OracleConnection("Data Source = 222.237.134.74:1522/Ora7;User id=edu;Password=edu1234");
        }
        public static void ExecuteNonQuery(string sql, List<OracleParameter> parameters = null)
        {
            using (OracleConnection connection = new OracleConnection("Data Source = 222.237.134.74:1522/Ora7;User id=edu;Password=edu1234"))
            {
                try
                {
                    connection.Open();
                    SetCommand(connection, sql, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        private static void SetCommand(OracleConnection connection, string sql, List<OracleParameter> parameters)
        {
            using (OracleCommand command = new OracleCommand())
            {
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;

                if (!(parameters is null))
                {
                    command.Prepare();
                    parameters.ForEach(parameter => command.Parameters.Add(parameter));
                }
                command.ExecuteNonQuery();
            }
        }

        public static OracleDataReader Query(string sql, List<OracleParameter> parameters = null)
        {
            using (OracleConnection connection = new OracleConnection("Data Source = 222.237.134.74:1522/Ora7;User id=edu;Password=edu1234"))
            {
                try
                {
                    connection.Open();
                    return SetQuery(connection, sql, parameters);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return null;
                }
            }
        }

        public static OracleDataReader SetQuery(OracleConnection connection, string sql, List<OracleParameter> parameters)
        {
            using (OracleCommand command = new OracleCommand())
            {
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;

                if (!(parameters is null))
                {
                    command.Prepare();
                    parameters.ForEach(parameter => command.Parameters.Add(parameter));
                }
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
        }

        public static void ExecuteNonQuery(object dELETE_GRPCD, List<OracleParameter> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
