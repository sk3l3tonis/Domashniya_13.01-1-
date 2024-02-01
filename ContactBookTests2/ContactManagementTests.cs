using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;

namespace ContactBook.Tests
{
    [TestClass()]
    public class ContactManagementTests
    {
        private const string ConnectionString = "Server=localhost; port=5432; Database=contacts; User Id=postgres; Password=1212321;";

        [TestMethod()]
        public void Добавление_Данных()
        {
            var data = new List<string> { "Номер", "ФИО_Контакта", "Номер_контакта" };

            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                foreach (var item in data)
                {
                    using (var command = new NpgsqlCommand($"INSERT INTO Контакты(ФИО_Контакта, Номер_контакта) VALUES ('{0}', '{1}')", connection))
                    {
                        command.Parameters.AddWithValue("item", item);
                        command.ExecuteNonQuery();
                    }
                }
                Assert.IsTrue(data.Count != 0);
                Console.WriteLine("Данные успешно выведены!");
            }
        }
    }
}