using Npgsql;
using System.Data;

namespace ContactBook
{
    public partial class ContactManagement : Form
    {
        string connectionString = "Server=localhost; port=5432; Database=contacts; User Id=postgres; Password=1212321;";

        public ContactManagement()
        {
            InitializeComponent();

            SqlConnectionReader();

        }

        private void SqlConnectionReader()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Контакты ORDER BY Номер";

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("INSERT INTO Контакты(ФИО_Контакта, Номер_контакта) VALUES ('{0}', '{1}')",
                textBox1.Text, textBox2.Text);

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();
            SqlConnectionReader();

        }

        private void updatebutton_Click(object sender, EventArgs e)

        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            if (string.IsNullOrEmpty(textBox3.Text)) 
                {

                MessageBox.Show("Поле пустое или неверные данные!");
                return;
            
                }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("UPDATE Контакты SET ФИО_Контакта = '{0}', Номер_контакта = '{1}' WHERE Номер = '{2}'",
                textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();
            SqlConnectionReader();
        }

        private void deletebutton_Click(object sender, EventArgs e)                 
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Поле пустое или неверные данные!");
                return;

            }
            else
            {

                MessageBox.Show("Контакт успешно удалён!");

            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("DELETE FROM Контакты WHERE Номер = '{0}'", Convert.ToInt32(textBox3.Text));

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();
            SqlConnectionReader();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            
            if (string.IsNullOrEmpty(textBox1.Text)) 
            {

                MessageBox.Show("Поле пустое или неверные данные!");
                return;

            }
            else 
            {

                MessageBox.Show("Контакт успешно найден!");

            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM Контакты WHERE ФИО_Контакта = '{0}'", (textBox1.Text));

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }

            command.Dispose();
            sqlConnection.Close();

        }

        private void updatebutton_Click_1(object sender, EventArgs e)
        {
            SqlConnectionReader();
        }
    }
}
