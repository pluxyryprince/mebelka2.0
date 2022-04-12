using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mebelka2._0
{
    public partial class add_furniture : Form
    {
        public add_furniture()
        {
            InitializeComponent();
        }
        private string connect = "server=127.0.0.1;userid=root;password=;database=furniture_store;port=3306";

        private void add_furniture_button_Click(object sender, EventArgs e)//кнопка добавления данных
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connect);
                connection.Open();//соединение с бд    
                MySqlCommand command = new MySqlCommand($"INSERT INTO `furnture_model` (`id`, `name`, `model`, `item`, `price`) VALUES (NULL, '{name_furniture.Text}', '{model_furniture.Text}', '{item.Text}', '{price.Text}');")
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

        private void add_furniture_Load(object sender, EventArgs e)
        {

        }
    }
}
