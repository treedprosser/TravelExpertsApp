using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            // Populate the list of suppliers (if needed)
            //LoadSuppliers();
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

        // Get suppliers from the database and set as the list
        //private void LoadSuppliers()
        //{
        //    try
        //    {
        //        using (TravelExpertsContext db = new TravelExpertsContext())
        //        {
        //            var suppliers = (from s in db.Suppliers orderby s.SupName select s).ToList();
        //            cboSuppliers.DataSource = suppliers;
        //            cboSuppliers.DisplayMember = "SupName";
        //            cboSuppliers.ValueMember = "SupplierId";
        //        }
        //    }
        //}

        // Displays the current product
        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                txtProductID.Text = currentProduct.ProductId.ToString();
                txtProductName.Text = currentProduct.ProdName;
                // Add dropdown list for suppliers?
            }
            else
            {
                MessageBox.Show("There is no product", "Modify error");
            }
        }

        // Validate data and set the current product
        private void btn_OK_Click(object sender, EventArgs e)
        {
            // add if statement for validator
            if (isAdd)
            {
                currentProduct = new Product();
            }
            LoadProduct(); // Load new product if add or modify
        }

        // Load current product with data on the form
        private void LoadProduct()
        {
            currentProduct.ProductId = int.Parse(txtProductID.Text);
            currentProduct.ProdName = txtProductName.Text;
            // Add supplier list?
        }
    }
}
