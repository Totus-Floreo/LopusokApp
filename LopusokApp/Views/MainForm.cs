using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LopusokApp.Model;
using LopusokApp.ViewModel;

namespace LopusokApp.Views
{
    public partial class MainForm : Form
    {
        private List<Product> products = new List<Product>(DatabaseContext.database.Products);
        private string search = "";
        private string sort = "Наименование";
        private string filter = "Все типы";

        public MainForm()
        {
            InitializeComponent();
            UpdateOrder();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> typeList = DatabaseContext.database.ProductTypes.Select(pt => pt.Title).ToList();
            typeList.Insert(0, "Все типы");
            filteringCB.DataSource = typeList;

            sortingCB.SelectedIndex = 0;
            filteringCB.SelectedIndex = 0;
        }

        private void UpdateOrder()
        {
            products = DatabaseContext.database.Products.ToList();

            if (search != "")
            {
                search = search.ToLower(); 

                products = products.Where(product => product.Title.ToLower().Contains(search)).ToList();
                layoutPanel.Controls.Clear();
            }

            if (filter != "Все типы")
            {
                products = products.Where(product => product.ProductType.Title == filter).ToList();
                layoutPanel.Controls.Clear();
            }

            if (sort == "Наименование")
            {
                if (orderBy.Checked)
                {
                    products = products.OrderBy(product => product.Title).ToList();
                }
                else
                {
                    products = products.OrderByDescending(product => product.Title).ToList();
                }
                layoutPanel.Controls.Clear();
            }

            if (sort == "Мин. стоимость")
            {
                if (orderBy.Checked)
                {
                    products = products.OrderBy(product => product.MinCostForAgent).ToList();
                }
                else
                {
                    products = products.OrderByDescending(product => product.MinCostForAgent).ToList();
                }
                layoutPanel.Controls.Clear();
            }

            GenerateProductCardList(products);
        }

        private void GenerateProductCardList(List<Product> productCards)
        {
            layoutPanel.Controls.Clear();
            foreach (var product in productCards)
            {
                ProductCard productCard = new ProductCard();
                productCard.GenerateProductCardData(product);
                
                layoutPanel.Controls.Add(productCard);
                productCard.Click += new EventHandler(this.ProductCardClick);
            }
        }

        private void ProductCardClick(object sender, EventArgs e)
        {
            ProductCard editProductCard = (ProductCard)sender;

            EditDeleteForm form = new EditDeleteForm()
            {
                Product = (Product)products.First(product => product.ArticleNumber == editProductCard.articleLabel.Text),
            };
            DialogResult = form.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                UpdateOrder();
            }
        }

        private void sortingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = sortingCB.Text;
            UpdateOrder();
        }

        private void orderBy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void filteringCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = filteringCB.Text;
            UpdateOrder();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
            UpdateOrder();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditDeleteForm frm = new EditDeleteForm();
            DialogResult = frm.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                UpdateOrder();
            }
        }
    }
}
