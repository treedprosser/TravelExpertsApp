using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TravelData;

namespace TravelExpertsApp
{
    /// <summary>
    /// Main form page for Travel Experts Application
    /// Author: Brianna Gibson 
    /// When: July 2022
    /// </summary>
    public partial class frmMain : Form
    {
        private Package selectedPackage;
        private Product selectedProduct;
        private ProductsSupplier selectedProdSup;

        public frmMain()
        {
            InitializeComponent();
        }

        // adds a new package 
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            // calls the frmPackageAddEdit
            frmAddEdit secondForm = new frmAddEdit();
            secondForm.isAdd = true;

            DialogResult result = secondForm.ShowDialog();

        }

        // loads on application
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            //btnEditPackage.Enabled = false;
            //btn_EditProd.Enabled = false;
            //btn_EditSupplier.Enabled = false;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                UpdatePackages();
                UpdateProducts();
                UpdateProdSup();
                cbo_Suppliers.DataSource = db.Suppliers.Select(s => s.SupplierId + " : " + s.SupName).ToList();
            }
        }

        // edits the packages that have been selected
        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            // calls the frmPackagesAddEdit
            frmAddEdit secondForm = new frmAddEdit();
            secondForm.isAdd = false;

            DialogResult result = secondForm.ShowDialog();

        }

        // adds a product
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            // Calls the frmProductsAddEdit
            frmProductsAddEdit secondForm = new frmProductsAddEdit();
            secondForm.isAdd = true;

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedProduct = secondForm.currentProduct;

                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        db.Products.Add(selectedProduct);
                        db.SaveChanges();
                    }
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when adding Product");
                }
            }
            UpdateProducts();
        }

        // edits the product that has been selected
        private void btn_EditProd_Click(object sender, EventArgs e)
        {
            frmProductsAddEdit secondForm = new frmProductsAddEdit();
            secondForm.isAdd = false;
            TravelExpertsContext db = new TravelExpertsContext();
            selectedProduct = db.Products.Find(cbo_products.SelectedIndex + 1);
            secondForm.currentProduct = selectedProduct;

            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    int productID = secondForm.currentProduct.ProductId;
                    selectedProduct = db.Products.Find(productID);
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Current product does not exist", "Modify error");
                        return;
                    }
                    selectedProduct.ProductId = secondForm.currentProduct.ProductId;
                    selectedProduct.ProdName = secondForm.currentProduct.ProdName;
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when Modifying Product");
                }
            }
            UpdateProducts();
        }

        // adds supplier 
        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
           ShowDialog();  
        }

        // edits supplier that was selected
        private void btn_EditSupplier_Click(object sender, EventArgs e)
        {
            ShowDialog("edit");

        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditPackage.Enabled = true;
        }

        private void HandleDbUpdateException(DbUpdateException ex)
        {
            // get the inner exception with potentially multiple errors 
            SqlException innerException = (SqlException)ex.InnerException;
            string message = "";
            foreach (SqlError err in innerException.Errors)
            {
                message += $"Error {err.Number}: {err.Message}\n";
            }
            MessageBox.Show(message, "Database Update Error(s)");
        }
        private void ShowDialog(
            string formAction = "add",
            int supplierID = 0,
            string supplierName = ""

        )
        {

            // Create a new  form object with values passed in to populate the text boxes
            frmSuppliersAddEdit addSupplierForm = new(
                formAction,
                supplierID,
                supplierName
            );

            // Hide the main ProductMaintenance form
            this.Hide();

            // Open a ProductMaintenanceEdit form as a dialog
            addSupplierForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = 0;

            string Name = "";

            string[] Option = cbo_Suppliers.Text.Split(":");

            ID = Convert.ToInt32(Option[0]);

            Name = Option[1];

            ShowDialog("edit", ID, Name );


        }

        private void UpdateProducts()
        {
            TravelExpertsContext db = new TravelExpertsContext();
            cbo_products.DataSource = db.Products.Select(p => p.ProductId + " : " + p.ProdName).ToList();
        }

        private void UpdateProdSup()
        {
            TravelExpertsContext db = new TravelExpertsContext();
            cbo_ProductsSuppliers.DataSource = db.ProductsSuppliers.Select(p => p.ProductSupplierId).ToList();
        }

        private void UpdatePackages()
        {
            dgvPackages.Columns.Clear();
            TravelExpertsContext db = new TravelExpertsContext();
            var packages = (from package in db.Packages
                            select new
                            {
                                package.PackageId,
                                package.PkgName,
                                package.PkgBasePrice
                            }).ToList();

            dgvPackages.DataSource = packages;

            dgvPackages.Columns[0].HeaderText = "Package ID";
            dgvPackages.Columns[0].Width = 75;

            dgvPackages.Columns[1].HeaderText = "Package Name";
            dgvPackages.Columns[1].Width = 200;

            dgvPackages.Columns[2].HeaderText = "Package Base Price";
            dgvPackages.Columns[2].Width = 100;
            dgvPackages.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btn_AddPS_Click(object sender, EventArgs e)
        {
            // Calls the frmProdSupAddEdit
            frmProdSupAddEdit secondForm = new frmProdSupAddEdit();
            secondForm.isAdd = true;

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedProdSup = secondForm.currentProdSup;

                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        db.ProductsSuppliers.Add(selectedProdSup);
                        db.SaveChanges();
                    }
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when adding Product");
                }
            }
            UpdateProdSup();
        }

        private void btn_EditPS_Click(object sender, EventArgs e)
        {
            frmProdSupAddEdit secondForm = new frmProdSupAddEdit();
            secondForm.isAdd = false;
            TravelExpertsContext db = new TravelExpertsContext();
            selectedProdSup = db.ProductsSuppliers.Find(cbo_ProductsSuppliers.SelectedIndex + 1);
            secondForm.currentProdSup = selectedProdSup;

            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    int prodsupID = secondForm.currentProdSup.ProductSupplierId;
                    selectedProdSup = db.ProductsSuppliers.Find(prodsupID);
                    if (selectedProdSup == null)
                    {
                        MessageBox.Show("Current Product/Supplier does not exist", "Modify error");
                        return;
                    }
                    selectedProdSup.ProductId = secondForm.currentProdSup.ProductId;
                    selectedProdSup.SupplierId = secondForm.currentProdSup.SupplierId;
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when Modifying Product");
                }
            }
            UpdateProdSup();
        }
    }
}