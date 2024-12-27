using System;
using System.Linq;
using System.Windows.Forms;

namespace Exam.DB
{
    internal class DataFixtures
    {
        public static void loadFixtures()
        {
            string message = "Выполнить загрузку тестовых данных в базу данных?\nВнимание! Все данные из БД будут удалены!";
            string caption = "Загрузка данных в БД";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Random r = new Random(); // Один объект Random для всех циклов

                using (DB.ApplicationContext db = new DB.ApplicationContext())
                {
                    try
                    {
                        db.Database.EnsureDeleted();
                        db.Database.EnsureCreated();

                        // Добавление пользователей
                        DB.User admin = new DB.User { login = "admin", password = "654321", email = "admin@example.com", name = "Administrator", group = 1 };
                        DB.User user1 = new DB.User { login = "user1", password = "123456", email = "user@example.com", name = "User", group = 2 };
                        db.Users.AddRange(admin, user1);

                        // Добавление клиентов
                        var clients = new List<DB.Clients>();
                        for (int i = 0; i < 23; i++)
                        {
                            var client = new DB.Clients
                            {
                                firstName = $"Ilia{1}",
                                lastName = $"{i}",
                                middleName = " test",
                                email = $"reader{i}@example.com",
                                address = $"some address for reader {i}",
                                phone = "+7123" + r.Next(1000000, 9999999).ToString()
                            };
                            clients.Add(client);
                        }
                        db.Clients.AddRange(clients);

                        // Добавление продуктов
                        var products = new List<DB.Products>();
                        for (int i = 0; i < 65; i++)
                        {
                            for (int j = 0; j < r.Next(1, 5); j++)
                            {
                                var product = new DB.Products
                                {
                                    title = $"someProduct {i}",
                                    category = $"Category {i}",
                                    price = r.Next(0, 14880),
                                    amount = r.Next(100, 2000)
                                };
                                products.Add(product);
                            }
                        }
                        db.Products.AddRange(products);

                        // Добавление деталей заказов
                        var orderDetails = new List<DB.OrdersDetails>();
                        for (int i = 0; i < 53; i++)
                        {
                            var orderDetail = new DB.OrdersDetails
                            {
                                
                                idOrder = r.Next(1, 50),
                                idProduction = r.Next(1, 63),
                                amount = r.Next(1, 5)
                            };
                            orderDetails.Add(orderDetail);
                        }
                        db.OrdersDetails.AddRange(orderDetails);

                        // Добавление заказов
                        var orders = new List<DB.Orders>();
                        for (int i = 0; i < 50; i++)
                        {
                            var client = r.Next(1, 23);
                            var day = r.Next(1, 23);
                            var month = r.Next(1, 10);
                            var year = r.Next(1990, 2024);

                            var order = new DB.Orders
                            {
                                
                                idClients = client,
                                dateOrder = DateTime.Parse($"{day}.{month}.{year}").ToUniversalTime(), // Преобразуем время в UTC
                                Status = (OrderStatus)r.Next(0, 4) // Преобразуем число в OrderStatus
                            };

                            orders.Add(order);
                        }
                        db.Orders.AddRange(orders);

                        // Сохраняем изменения в базе данных за один раз
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = ex.Message;
                        if (ex.InnerException != null)
                        {
                            errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                        }

                        DialogResult dbexept = MessageBox.Show(errorMessage + "\nПриложение будет закрыто", "Ошибка БД", MessageBoxButtons.OK);
                        if (dbexept == System.Windows.Forms.DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
