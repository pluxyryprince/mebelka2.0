using MySql.Data.MySqlClient;

namespace mebelka2._0
{
    class connector
    {

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=furniture_store;port=3306");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection() => connection;
    }
}
