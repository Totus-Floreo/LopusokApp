using System;
using System.Linq;
using LopusokApp.Model;
using LopusokApp.ViewModel;
using System.Windows.Forms;
using System.IO;

namespace LopusokApp.Views
{
    public partial class EditDeleteForm : Form
    {
        public Product Product { get; set; } = null;
        private bool imageChanged = false;
        private int randomID = new Random().Next(999999999);

        public EditDeleteForm()
        {
            InitializeComponent();
        }

        private void EditDeleteForm_Load(object sender, EventArgs e)
        {
            productTypeIDComboBox.DataSource = DatabaseContext.database.ProductTypes.Select(pt => pt.Title).ToList();

            productTypeIDComboBox.SelectedIndex = 0;

            if (Product != null)
            {
                this.Text = "Изменение продукта";
                productBindingSource.DataSource = Product;
                productTypeIDComboBox.SelectedIndex = Product.ProductTypeID.Value - 1;
                pictureBox.ImageLocation = $@"{Environment.CurrentDirectory}\Resources\{Product.Image}";
                btnDelete.Visible = true;
                materialBindingSource.DataSource = DatabaseContext.database.Materials.ToList();
                productMaterialBindingSource.DataSource = 
                    DatabaseContext.database.ProductMaterials.Where(product => product.ProductID == Product.ID).ToList();
            }
            else
            {
                this.Text = "Добавление продукта";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действетельно хотите удалить " + Product.Title + "?",
                "Удаление продукта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DatabaseContext.database.Products.Remove(Product);
                DatabaseContext.database.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonImageChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.png; *jpg, *.jpeg)|*.png;*jpg,*.jpeg"
            };

            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    File.Copy(fileDialog.FileName, $@"{Environment.CurrentDirectory}\Resources\{randomID}.png");

                    pictureBox.ImageLocation = fileDialog.FileName;
                    imageChanged = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Изображение уже существует", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Проверьте правильность введённых данных!");
                return;
            }

            if (Product != null)
            {
                ChangeProduct();
            }
            else
            {
                CreateProduct();
            }

            SaveDatabase();

            DialogResult = DialogResult.OK;
        }

        private int article;
        private int employeePersonCount;
        private int workshopNumber;
        private decimal minAgentCost;

        private bool ValidateForm()
        {
            bool minAgentCostValidated = decimal.TryParse(minCostForAgentTextBox.Text, out minAgentCost);
            bool arcticleValidated = int.TryParse(articleNumberTextBox.Text, out article);
            bool employeeValidated = int.TryParse(productionPersonCountTextBox.Text, out employeePersonCount);
            bool workshopNumberValidated = int.TryParse(productionWorkshopNumberTextBox.Text, out workshopNumber);

            if (!(minAgentCostValidated && arcticleValidated && employeeValidated && workshopNumberValidated))
            {
                return false;
            }

            return true;
        }

        private void ChangeProduct()
        {
            Product.Title = titleTextBox.Text;
            Product.ArticleNumber = article.ToString();
            Product.MinCostForAgent = minAgentCost;
            Product.ProductionPersonCount = employeePersonCount;
            Product.ProductionWorkshopNumber = workshopNumber;
            Product.ProductTypeID = productTypeIDComboBox.SelectedIndex + 1;
            Product.Description = descriptionTextBox.Text;

            if (imageChanged)
            {
                Product.Image = $@"{randomID}.png";
            }
        }

        private void CreateProduct()
        {
            Product = new Product
            {
                Title = titleTextBox.Text,
                ArticleNumber = articleNumberTextBox.Text,
                MinCostForAgent = minAgentCost,
                ProductionPersonCount = employeePersonCount,
                ProductionWorkshopNumber = workshopNumber,
                ProductTypeID = productTypeIDComboBox.SelectedIndex + 1,
                Description = descriptionTextBox.Text
            };

            if (imageChanged)
            {
                Product.Image = $@"{randomID}.png";
            }
            else
            {
                Product.Image = "picture.png";
            }

            DatabaseContext.database.Products.Add(Product);
        }
        
        private void SaveDatabase()
        {
            try
            {
                DatabaseContext.database.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
