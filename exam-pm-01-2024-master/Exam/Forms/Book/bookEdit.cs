namespace Exam.Forms.Product
{
    public partial class ProductEdit : Form
    {
        private DB.Products currentProduct;
        public ProductEdit(object dataGridViewRow)
        {
            InitializeComponent();
            this.currentProduct = (DB.Products)dataGridViewRow;
            loadFormData(this.currentProduct);
        }

        public ProductEdit()
        {
            InitializeComponent();
        }

        private void loadFormData(DB.Products Product)
        {
            this.tbProductName.Text = Product.title.ToString();
            this.tbProductAuthor.Text = Product.category.ToString();
            this.tbProductIsbn.Text = Product.price.ToString();
            this.tbProductCountPages.Text = Product.amount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.formValidate())
            {
                using (var db = new DB.ApplicationContext())
                {
                    try
                    {
                        db.Products.Update(this.currentProduct);
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
            var errorColor = Color.RosyBrown;
            bool valid = true;
            if (this.tbProductAuthor.Text != string.Empty)
            {
                this.tbProductAuthor.BackColor = SystemColors.Window;
                this.currentProduct.category = this.tbProductAuthor.Text;
            }
            else
            {
                this.tbProductAuthor.BackColor = Color.IndianRed;
                valid = false;
            }
            if (this.tbProductIsbn.Text != string.Empty)
            {
                this.tbProductIsbn.BackColor = SystemColors.Window;
                this.currentProduct.price = decimal.Parse(this.tbProductIsbn.Text);

            }
            else
            {
                this.tbProductIsbn.BackColor = Color.IndianRed;
                valid = false;
            }
            if (this.tbProductName.Text != string.Empty)
            {
                this.tbProductName.BackColor = SystemColors.Window;
                this.currentProduct.title = this.tbProductName.Text;
            }
            else
            {
                this.tbProductName.BackColor = Color.IndianRed;
                valid = false;
            }
            if (int.TryParse(this.tbProductCountPages.Text, out var countPages))
            {
                this.tbProductCountPages.BackColor = SystemColors.Window;
                this.currentProduct.amount = countPages;
            }
            else
            {
                this.tbProductCountPages.BackColor = Color.IndianRed;
                valid = false;
            }
            
            return valid;
        }

        private void gbProductISBN_Enter(object sender, EventArgs e)
        {

        }
    }
}
