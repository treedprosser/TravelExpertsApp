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

        //        //fills the Package list and fills the product and supplier combo boxes
        //        using (TravelExpertsContext db = new TravelExpertsContext())
        //        {
        //            var packages = (from package in db.Packages
        //                            select new
        //                            {
        //                                package.PackageId,
        //                                package.PkgName,
        //                                package.PkgBasePrice
        //                            }).ToList();
        //            lstPackages.DataSource = packages;

        //            //lstPackages.DataSource = db.Packages.ToList();
        //            cbo_products.DataSource = db.Products.Select(p => p.ProductId + ":" + p.ProdName).ToList();
        //            cbo_Suppliers.DataSource = db.Suppliers.Select(s => s.SupplierId + ":" + s.SupName).ToList();
        //        }


        //    btnEditPackage.Enabled = false;
        //    btn_EditProd.Enabled = false;
        //    btn_EditSupplier.Enabled = false;
        }

        // adds a new package 
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddEdit secondForm = new frmAddEdit();

        }

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
            }
        }
    }
}