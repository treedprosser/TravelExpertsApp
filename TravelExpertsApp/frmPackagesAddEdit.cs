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
using TravelData;

namespace TravelExpertsApp
{
    public partial class frmAddEdit : Form
    {
		public Package? package;
		private bool isAdd;

        public frmAddEdit()
        {
            InitializeComponent();
        }

		private void frmAddEdit_Load(object sender, EventArgs e)
		{
			try
			{
				using(TravelExpertsContext db = new TravelExpertsContext())
				{
					product_box.DataSource = db.Products.Select(p => p.ProdName).ToList();
					supplier_box.DataSource = db.Suppliers.Select(s => s.SupName).ToList();
				}
			}
			catch
			{
				MessageBox.Show("Error connecting to the database", "Error");
				this.Close();
				return;
			}

			if (package == null) //add new package
			{
				this.Text = "Add package";
				isAdd = true;
			}
			else //modify pakcage
			{
				isAdd = false;
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
					Select(p => p.Product.ProductId +":"+ p.Product.ProdName + " - " + p.Supplier.SupplierId + ":" + p.Supplier.SupName);
			}
		}

		private void cancel_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			if (package == null)
				package = new Package();

			name_txt.Text = name_txt.Text.Trim();
			description_txt.Text = description_txt.Text.Trim();
			price_txt.Text = price_txt.Text.Trim();
			comission_txt.Text = comission_txt.Text.Trim();
			startDate_txt.Text = startDate_txt.Text.Trim();
			endDate_txt.Text = endDate_txt.Text.Trim();

			decimal price, comission;
			bool priceIsDecimal = decimal.TryParse(price_txt.Text, out price);
			bool comissionIsDecimal = decimal.TryParse(comission_txt.Text, out comission);

			DateTime startDate, endDate;
			bool startDateIsValid = DateTime.TryParseExact(
				startDate_txt.Text,
				"MM/dd/yyy",
				CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out startDate);
			bool endDateIsValid = DateTime.TryParseExact(
				endDate_txt.Text,
				"MM/dd/yyy",
				CultureInfo.InvariantCulture,
				DateTimeStyles.None,
				out endDate);

			List<string> errors = new List<string>();

			if (!(name_txt.Text.Length > 0))
				errors.Add("Package must have a name");
			if (!(description_txt.Text.Length > 0))
				errors.Add("Package must have a description");
			if (comission_txt.Text != "")
			{
				if (!comissionIsDecimal)
					errors.Add("Comission must be a valid number");
				else if (comission > price)
					errors.Add("Comission must not be greater than the price");
			}
			if (!priceIsDecimal)
				errors.Add("Price must be a valid number");
			if(endDate_txt.Text != "")
			{
				if (!endDateIsValid)
					errors.Add("End date is invalid. Format: mm/dd/yyyy");
				else if (endDate > startDate)
					errors.Add("End date must not be later than start date");
			}
			if (startDate_txt.Text != "" && !startDateIsValid)
				errors.Add("Start date is invalid. Format: mm/dd/yyyy");

			if(errors.Count > 0)
			{
				MessageBox.Show(String.Join('\n', errors));
			}
			else
			{
				package.PkgName = name_txt.Text;
				package.PkgDesc = description_txt.Text;
				package.PkgBasePrice = price; //required by database
				package.PkgAgencyCommission = comission_txt.Text != "" ? comission : null;

				package.PkgStartDate = startDateIsValid ? startDate : null;
				package.PkgEndDate = endDateIsValid ? endDate : null;

				if(TravelPackageManager.SavePackage(isAdd, package, products_list.Items.Cast<String>().ToList()))
					DialogResult = DialogResult.OK;				
			}
		}

		private void add_button_Click(object sender, EventArgs e)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
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
			}
			catch
			{
				MessageBox.Show("Error connecting to the database", "Error");
				this.Close();
				return;
			}			
		}

		private void remove_button_Click(object sender, EventArgs e)
		{
			products_list.Items.RemoveAt(products_list.SelectedIndex);
		}
	}
}
