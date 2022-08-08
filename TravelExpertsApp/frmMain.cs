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
        // private properties
        private Package selectedPackage;
        private Product selectedProduct;
        private Supplier selectedSupplier;  

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
            if (result == DialogResult.OK)
            {
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        db.Packages.Add(selectedPackage);
                        db.SaveChanges();
                    }
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when adding Package");
                }
            }
        }

        // loads on application
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            btnEditPackage.Enabled = false;
            btn_EditProd.Enabled = false;
            btn_EditSupplier.Enabled = false;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var packages = (from package in db.Packages
                                select new
                                {
                                    package.PackageId,
                                    package.PkgName,
                                    package.PkgBasePrice
                                }).ToList();
                lstPackages.DataSource = packages;

                cbo_products.DataSource = db.Products.Select(p => p.ProductId + " : " + p.ProdName).ToList();
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
            secondForm.currentProduct = null;

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
        }

        // edits the product that has been selected
        private void btn_EditProd_Click(object sender, EventArgs e)
        {
            frmProductsAddEdit secondForm = new frmProductsAddEdit();
            secondForm.isAdd = false;
            // Get selected product from drop down list
            secondForm.currentProduct = selectedProduct;

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    try
                    {
                        int prodID = secondForm.currentProduct.ProductId;
                        selectedProduct = db.Products.Find(prodID);
                        if (selectedProduct == null)
                        {
                            MessageBox.Show("Current product does not exit", "Modify error");
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
                        MessageBox.Show("Error when updating Product");
                    }
                }
            }
        }

        // adds supplier 
        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            frmSuppliersAddEdit secondForm = new frmSuppliersAddEdit();
            //secondForm.isAdd = true;

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        db.Suppliers.Add(selectedSupplier);
                        db.SaveChanges();
                    }
                }
                catch (DbUpdateException ex)
                {
                    HandleDbUpdateException(ex);
                }
                catch
                {
                    MessageBox.Show("Error when adding Supplier");
                }
            }
        }

        // edits supplier that was selected
        private void btn_EditSupplier_Click(object sender, EventArgs e)
        {
            frmSuppliersAddEdit secondForm = new frmSuppliersAddEdit();
            //secondForm.isAdd = false;

            // Get selected product from drop down list
            secondForm.currentSupplier = selectedSupplier;

            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    try
                    {
                        int supID = secondForm.currentSupplier.SupplierID;
                        selectedSupplier = db.Suppliers.Find(supID);
                        if (selectedSupplier == null)
                        {
                            MessageBox.Show("Current supplier does not exit", "Modify error");
                            return;
                        }
                        selectedSupplier.SupplierID = secondForm.currentSupplier.SupplierID;
                        selectedSupplier.SupplierName = secondForm.currentSupplier.SupplierName;
                        db.SaveChanges();
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDbUpdateException(ex);
                    }
                    catch
                    {
                        MessageBox.Show("Error when updating Product");
                    }
                }
            }
        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditPackage.Enabled = true;
        }

        // database error handling 
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
    }
}