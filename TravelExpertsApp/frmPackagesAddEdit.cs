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
    public partial class frmAddEdit : Form
    {
		public Package? package;
		private TravelExpertsContext? db;

        public frmAddEdit()
        {
            InitializeComponent();
        }

		private void frmAddEdit_Load(object sender, EventArgs e)
		{
			try
			{
				db = new TravelExpertsContext();
			}
			catch
			{
				MessageBox.Show("Error connecting to the database", "Error");
				if(db != null)
					db.Dispose();
				this.Close();
				return;
			}

			product_box.DataSource = db.Products.Select(p => p.ProdName).ToList();
			supplier_box.DataSource = db.Suppliers.Select(s => s.SupName).ToList();
			if (package == null) //add new package
			{
				this.Text = "Add package";
			}
			else //modify pakcage
			{
				this.Text = "Modify package";
				name_txt.Text = package.PkgName;
				description_txt.Text = package.PkgDesc;
				price_txt.Text = package.PkgBasePrice.ToString();
				comission_txt.Text = package.PkgAgencyCommission.ToString();

				startDate_txt.Text = package.PkgStartDate.HasValue ? 
					package.PkgStartDate.Value.ToString("MM/dd/yyy") : "";
				endDate_txt.Text = package.PkgEndDate.HasValue ?
					package.PkgEndDate.Value.ToString("MM/dd/yyy") : "";

				products_list.DataSource = package.ProductSuppliers.
					Select(p => p.Product.ProdName + " - " + p.Supplier.SupName);
			}
		}

		private void cancel_button_Click(object sender, EventArgs e)
		{
			db.Dispose();
			this.Close();
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			db.Dispose();
			this.Close();
		}

		private void frmAddEdit_FormClosed(object sender, FormClosedEventArgs e)
		{
			db.Dispose();
		}

		private void add_button_Click(object sender, EventArgs e)
		{
			if
			(
				db.Products.Select(p => p.ProdName).ToList().Contains(product_box.Text) &&
				db.Suppliers.Select(s => s.SupName).ToList().Contains(supplier_box.Text) &&
				!products_list.Items.Contains(product_box.Text + " - " + supplier_box.Text)
			)
			{
				products_list.Items.Add(product_box.Text + " - " + supplier_box.Text);
			}
			else
			{
				MessageBox.Show("Valid product and supplier must be selected.", "Invalid product");
			}
		}

		private void remove_button_Click(object sender, EventArgs e)
		{
			products_list.Items.RemoveAt(products_list.SelectedIndex);
		}
	}
}
