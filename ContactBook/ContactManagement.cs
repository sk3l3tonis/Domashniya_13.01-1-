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
            command.CommandText = "SELECT * FROM �������� ORDER BY �����";

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
            command.CommandText = String.Format("INSERT INTO ��������(���_��������, �����_��������) VALUES ('{0}', '{1}')",
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

                MessageBox.Show("���� ������ ��� �������� ������!");
                return;
            
                }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("UPDATE �������� SET ���_�������� = '{0}', �����_�������� = '{1}' WHERE ����� = '{2}'",
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

                MessageBox.Show("���� ������ ��� �������� ������!");
                return;

            }
            else
            {

                MessageBox.Show("������� ������� �����!");

            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("DELETE FROM �������� WHERE ����� = '{0}'", Convert.ToInt32(textBox3.Text));

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

                MessageBox.Show("���� ������ ��� �������� ������!");
                return;

            }
            else 
            {

                MessageBox.Show("������� ������� ������!");

            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("SELECT * FROM �������� WHERE ���_�������� = '{0}'", (textBox1.Text));

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
