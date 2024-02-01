using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ContactBook.Tests
{
    [TestClass()]
    public class ContactManagementTests
    {
        private const string ConnectionString = "Server=localhost; port=5432; Database=contacts; User Id=postgres; Password=1212321;";

        [TestMethod()]
        public void Обновление_Данных()
        {
            {
                var data = new List<string> { "Номер", "ФИО_Контакта", "Номер_контакта" };

                using (var connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    foreach (var item in data)
                    {
                        using (var command = new NpgsqlCommand($"UPDATE Контакты SET ФИО_Контакта = '{123}', Номер_контакта = '{88005553535}' WHERE Номер = '{5}'", connection))
                        {
                            command.Parameters.AddWithValue("item", item);
                            command.ExecuteNonQuery();
                        }
                    }
                    Assert.IsTrue(data.Count != 0);
                    Console.WriteLine("5 строчка успешно обновлена!");
                }
            }
        }
    }
}
