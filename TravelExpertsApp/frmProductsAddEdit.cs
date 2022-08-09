using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelData;

namespace TravelExpertsApp
{
    public partial class frmProductsAddEdit : Form
    {
        // Public data - set from the main form
        public Product currentProduct;
        public bool isAdd;

        public frmProductsAddEdit()
        {
            InitializeComponent();
        }

        private void frmProductsAddEdit_Load(object sender, EventArgs e)
        {
            // Set the title of the form based on the action
            if (isAdd)
            {
                this.Text = "Add new Product";
            }
            else
            {
                this.Text = "Modify Product";
                DisplayProduct(); // Display current product (if any)
            }
        }

        // Displays the current product
        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                txtProductName.Text = currentProduct.ProdName;
            }
            else
            {
                MessageBox.Show("There is no product", "Modify error");
            }
        }

        // Validate data and set the current product
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName))
            {
                if (isAdd)
                {
                    currentProduct = new Product();
                }
                LoadProduct(); // Load new product if add or modify
                this.DialogResult = DialogResult.OK; // Closes the form 
            }
        }

        // Load current product with data on the form
        private void LoadProduct()
        {
            currentProduct.ProdName = txtProductName.Text;
        }
    }
}
