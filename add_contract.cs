using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mebelka2._0
{
    public partial class add_contract : Form
    {
        public add_contract()
        {
            InitializeComponent();
        }
        private string connect = "server=127.0.0.1;userid=root;password=;database=furniture_store;port=3306";

        private void add_contract_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_storeDataSet.furnture_model". При необходимости она может быть перемещена или удалена.
                this.furnture_modelTableAdapter.Fill(this.furniture_storeDataSet.furnture_model);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_storeDataSet.client". При необходимости она может быть перемещена или удалена.
                this.clientTableAdapter.Fill(this.furniture_storeDataSet.client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_contract_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connect);
                connection.Open();//соединение с бд    
                MySqlCommand command = new MySqlCommand($"INSERT INTO `sell_contract` (`num_contract`, `id_client`, `id_furniture`, `name_furniture`, `model_furniture`, `count`, `registration_date`, `achievement_date`, `sum`) VALUES (NULL, '{enter_id_client.Text}', '{enter_id_furniture.Text}', '{enter_name_furniture.Text}', '{enter_model_furniture.Text}', '{count.Text}', '{reg_date.Text}', '{release_date.Text}', '{sum.Text}');")
                {
                    Connection = connection//команда для заполнения
                };
                command.ExecuteNonQuery();//выполнение команды
                MessageBox.Show("Данные успешно добавлены");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Проверьте правильность введенных данных");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void enter_id_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox enter_id_client = (ComboBox)sender;
        }

        private void enter_id_furniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox enter_id_furniture = (ComboBox)sender;
        }

        private void enter_name_furniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox enter_name_furniture = (ComboBox)sender;
        }

        private void enter_model_furniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox enter_model_furniture = (ComboBox)sender;
        }

        private void registration_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            reg_date.Text = String.Format("{0}", e.Start.ToLongDateString());
        }

        private void realization_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            release_date.Text = String.Format("{0}", e.Start.ToLongDateString());
        }
    }
}
