using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LopusokApp.Model;

namespace LopusokApp.Views
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void GenerateProductCardData(Product product)
        {
            if(product.Image != null)
            {
                pictureBox.ImageLocation = $@"{Environment.CurrentDirectory}\Resources\{product.Image}";
            }
            else
            {
                pictureBox.ImageLocation = $@"{Environment.CurrentDirectory}\Resources\picture.png";
            }
            
            fullNameLabel.Text = product.ProductType.Title + " | " + product.Title;
            articleLabel.Text = product.ArticleNumber;
            double cost = 0;
            string material = "";

            foreach (ProductMaterial productMaterial in product.ProductMaterials)
            {
                if (productMaterial.Count.HasValue)
                {
                    if (material != "")
                    {
                        material += "\n";
                    }

                    material += productMaterial.Material.Title;

                    double count = productMaterial.Count.Value;
                    cost = count * Convert.ToDouble(productMaterial.Material.Cost);
                }
            }

            materialsLabel.Text = material;

            if (cost == 0)
            {
                costLabel.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", product.MinCostForAgent);
            }
            else
            {
                costLabel.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", cost);
            }
        }
    }
}
