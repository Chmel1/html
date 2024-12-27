using Exam.DB;

namespace Exam.Forms.Order
{
    public partial class ordersAdd : Form
    {
        private DB.Orders currentOrders = new();

        public ordersAdd()
        {
            InitializeComponent();
        }





        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (this.formValidate())
            {
                if (!int.TryParse(tbOrderName.Text, out var orderId) ||
                    !int.TryParse(tbOrderAuthor.Text, out var clientId))
                {
                    MessageBox.Show("Некорректные данные для ID заказа или клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentOrders.id = orderId;
                currentOrders.idClients = clientId;
                currentOrders.dateOrder = DateTime.UtcNow;

                if (!Enum.TryParse<OrderStatus>(tbOrderCountPages.Text, out var status))
                {
                    MessageBox.Show("Недопустимый статус. Введите корректное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentOrders.Status = status;

                using (var db = new DB.ApplicationContext())
                {
                    try
                    {
                        db.Orders.Add(currentOrders);
                        db.SaveChanges();
                        MessageBox.Show("Запись успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\n{ex.InnerException?.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка данных на форме", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool formValidate()
        {
            bool valid = true;

            

            if (!string.IsNullOrWhiteSpace(tbOrderAuthor.Text))
            {
                tbOrderAuthor.BackColor = SystemColors.Window;
            }
            else
            {
                tbOrderAuthor.BackColor = Color.IndianRed;
                valid = false;
            }





            return valid;
        }
    }
}
