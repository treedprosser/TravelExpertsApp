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
        public Product product;
        public bool isAdd;
        private TravelExpertsContext db;

        public frmProductsAddEdit()
        {
            InitializeComponent();
        }
        private void frmProductsAddEdit_Load(object sender, EventArgs e)
        {
            try
            {
                db = new TravelExpertsContext();
            }
            catch
            {
                MessageBox.Show("Error Connecting to the Database", "Database Error");
                this.Close();
                return;
            }
            
            if (product == null) // Adding a new product
            {
                this.Text = "Add new product";
                isAdd = true;
            }
            else // Modifying a product
            {
                this.Text = "Modify existing product";
                txtProductID.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProdName;
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                product = new Product();
                product.ProductId = Convert.ToInt32(txtProductID.Text);
                product.ProdName = txtProductName.Text;
            }
            db.Dispose();
            this.Close();
        }
    }
}
