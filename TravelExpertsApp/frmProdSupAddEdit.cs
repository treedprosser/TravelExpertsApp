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
    public partial class frmProdSupAddEdit : Form
    {
        public ProductsSupplier currentProdSup;
        public bool isAdd;

        public frmProdSupAddEdit()
        {
            InitializeComponent();
        }

        private void frmProdSupAddEdit_Load(object sender, EventArgs e)
        {
            // Set the title of the form based on the action
            if (isAdd)
            {
                this.Text = "Add new Product-Supplier";
            }
            else
            {
                this.Text = "Modify Product-Supplier";
            }
            PopulateLists();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                currentProdSup = new ProductsSupplier();
            }
            LoadProdSup();
            this.DialogResult = DialogResult.OK;
        }

        private void PopulateLists()
        {
            TravelExpertsContext db = new TravelExpertsContext();
            cbo_Products.DataSource = db.Products.Select(p => p.ProductId + " : " + p.ProdName).ToList();
            cbo_Suppliers.DataSource = db.Suppliers.Select(s => s.SupplierId + " : " + s.SupName).ToList();
        }

        private void LoadProdSup()
        {
            currentProdSup.ProductId = (int?)cbo_Products.SelectedValue;
            currentProdSup.SupplierId = (int?)cbo_Suppliers.SelectedValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
