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
        public frmMain()
        {
            InitializeComponent();
        }

        // as application starts 
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //fills the Package list and fills the product and supplier combo boxes
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    lstPackages.DataSource = db.Packages.Select(p => p.PackageId + ":" + p.PkgName).ToList();
                    cbo_products.DataSource = db.Products.Select(p => p.ProductId + ":" + p.ProdName).ToList();
                    cbo_Suppliers.DataSource = db.Suppliers.Select(s => s.SupplierId + ":" + s.SupName).ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error connecting to the database", "Error");
                this.Close();
                return;
            }

            btnEditPackage.Enabled = false;
        }

        // adds a new package 
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddEdit secondForm = new frmAddEdit();

        }
    }
}