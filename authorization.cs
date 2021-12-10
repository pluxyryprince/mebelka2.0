using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mebelka2._0
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        static public string role;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Login = login.Text;
                string Password = password.Text;
                connector db = new connector();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login` = @login AND `password` = @password", db.GetConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MySqlDataAdapter users = new MySqlDataAdapter($"Select role From user", db.GetConnection());
                role = Convert.ToString(table.Rows[0][5]);
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    general general = new general();
                    general.Show();
                }
                else
                    MessageBox.Show("Пользователя не существует. Проверьте правильность введенных данных");
            }
            catch (Exception) 
            {
                MessageBox.Show("Ошибка при авторизации. Проверьте правильность введенных данных");
            }

           
        }
        private void authorization_Load(object sender, EventArgs e)
        {
        
        }
    }
}
