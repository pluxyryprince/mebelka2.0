using System;
using System.Windows.Forms;

namespace mebelka2._0
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();

        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }
        private void general_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_storeDataSet.client". При необходимости она может быть перемещена или удалена.
                this.clientTableAdapter.Fill(this.furniture_storeDataSet.client);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_storeDataSet.furnture_model". При необходимости она может быть перемещена или удалена.
                this.furnture_modelTableAdapter.Fill(this.furniture_storeDataSet.furnture_model);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "furniture_storeDataSet.sell_contract". При необходимости она может быть перемещена или удалена.
                this.sell_contractTableAdapter.Fill(this.furniture_storeDataSet.sell_contract);
            }
            catch (Exception) {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private void add_client_Click(object sender, EventArgs e)//добавить клиента
        {
            try
            {
                add_client add_client = new add_client();
                add_client.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_client_Click(object sender, EventArgs e)//сохранить изменения в таблице клиент
        {
            try
            {
                this.clientTableAdapter.Update(this.furniture_storeDataSet.client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_furniture_Click(object sender, EventArgs e)//добавить мебель
        {
            try
            {
                add_furniture add_furniture = new add_furniture();
                add_furniture.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_contract_Click(object sender, EventArgs e)
        {
            try
            {
                add_contract add_cont = new add_contract();
                add_cont.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_client_Click(object sender, EventArgs e)//удалить строку из таблицы клиент
        {
            int del = dataGridView_clients.SelectedCells[0].RowIndex;
            dataGridView_clients.Rows.RemoveAt(del);
        }

        private void save_furniture_Click(object sender, EventArgs e)//сохранить изменения в таблице мебель
        {
            this.furnture_modelTableAdapter.Update(this.furniture_storeDataSet.furnture_model);
        }

        private void delete_furniture_Click(object sender, EventArgs e)//удалить строку из таблицы мебель
        {
            int del_2 = dataGridView_furniture.SelectedCells[0].RowIndex;
            dataGridView_furniture.Rows.RemoveAt(del_2);
        }

        private void save_sell_Click(object sender, EventArgs e)//сохранить изменения в таблице договоры
        {
            try
            {
                this.sell_contractTableAdapter.Update(this.furniture_storeDataSet.sell_contract);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_contract_Click(object sender, EventArgs e)//удалить строку из таблицы договоры
        {
            int del_3 = dataGridView_contracts.SelectedCells[0].RowIndex;
            dataGridView_contracts.Rows.RemoveAt(del_3);
        }

        private void add_contract_Click_1(object sender, EventArgs e)//открыть форму добавления договора
        {
            try
            {
                add_contract add_cont = new add_contract();
                add_cont.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
