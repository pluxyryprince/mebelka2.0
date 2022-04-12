using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mebelka2._0
{
    public partial class add_client : Form
    {
        public add_client()
        {
            InitializeComponent();
        }

        private string connect = "server=127.0.0.1;userid=root;password=;database=furniture_store;port=3306";
        private void add_client_Load(object sender, EventArgs e)
        {
           
        }
    
        private void add_client_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connect);
                connection.Open();//соединение с бд   
                MySqlCommand command = new MySqlCommand($"INSERT INTO `client` (`id`, `name`, `adress`, `telephone`) VALUES (NULL, '{name_client.Text}', '{adress.Text}', '{telephone.Text}');")
                {
                    Connection = connection//команда для заполнения
                };
                command.ExecuteNonQuery();//выполнение команды              
                MessageBox.Show("Данные успешно добавлены");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Проверьте введенные данные");
            }
        }
    }
}
