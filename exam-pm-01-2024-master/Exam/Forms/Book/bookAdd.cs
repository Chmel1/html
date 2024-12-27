namespace Exam.Forms.Product
{
    public partial class ProductAdd : Form
    {
        private DB.Products currentProduct = new();

        public ProductAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formValidate())
            {
                // Присваивание значений полям продукта только после валидации
                currentProduct.title = tbProductName.Text;
                currentProduct.category = tbProductAuthor.Text;

                // Преобразование значений с проверкой
                if (decimal.TryParse(tbProductIsbn.Text, out decimal price))
                    currentProduct.price = price;
                else
                    currentProduct.price = 0; // или какое-то дефолтное значение

                if (int.TryParse(tbProductCountPages.Text, out int amount))
                    currentProduct.amount = amount;
                else
                    currentProduct.amount = 0; // дефолтное значение

                using (var db = new DB.ApplicationContext())
                {
                    try
                    {
                        db.Products.Add(this.currentProduct);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

            // Проверка и присваивание значения полю Author
            valid &= ValidateField(tbProductAuthor);

            // Проверка и присваивание значения полю ISBN
            valid &= ValidateField(tbProductIsbn);

            // Проверка и присваивание значения полю Name
            valid &= ValidateField(tbProductName);

            // Проверка количества страниц
            if (int.TryParse(tbProductCountPages.Text, out var countPages))
            {
                tbProductCountPages.BackColor = SystemColors.Window;
                currentProduct.amount = countPages;
            }
            else
            {
                tbProductCountPages.BackColor = Color.IndianRed;
                valid = false;
            }

            return valid;
        }

        // Общий метод для проверки поля
        private bool ValidateField(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = Color.IndianRed;
                return false;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
                return true;
            }
        }
    }
}
