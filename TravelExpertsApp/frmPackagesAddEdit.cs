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
		//package that is being modified
		//set null to add package
		//or set to existing package to modify
		public Package? package;
		//do not try to set isAdd
		//it is assigned and used later in the code
		public bool isAdd;

        public frmAddEdit()
        {
            InitializeComponent();
        }

		//checks if will add or modify
		//fills the form fields accordingly
		private void frmAddEdit_Load(object sender, EventArgs e)
		{
			try
			{
				//fills the products and the suppliers boxes
				using(TravelExpertsContext db = new TravelExpertsContext())
				{
					product_box.DataSource = db.Products.Select(p => p.ProductId+":"+p.ProdName).ToList();
					supplier_box.DataSource = db.Suppliers.Select(s => s.SupplierId+":"+s.SupName).ToList();
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
			{	 //fill the fields with package data
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

		//closes the form
		private void cancel_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//cleans data and saves in the database
		private void ok_button_Click(object sender, EventArgs e)
		{
			//create package if adding
			if (package == null)
				package = new Package();

			//trim fields
			name_txt.Text = name_txt.Text.Trim();
			description_txt.Text = description_txt.Text.Trim();
			price_txt.Text = price_txt.Text.Trim();
			comission_txt.Text = comission_txt.Text.Trim();
			startDate_txt.Text = startDate_txt.Text.Trim();
			endDate_txt.Text = endDate_txt.Text.Trim();

			//parsed decimals from the form fields
			decimal price, comission;
			//parse success checkers
			bool priceIsDecimal = decimal.TryParse(price_txt.Text, out price);
			bool comissionIsDecimal = decimal.TryParse(comission_txt.Text, out comission);

			//parsed DateTime form the fields
			DateTime startDate, endDate;
			//parse success checkers
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

			//list of errors during data validation
			List<string> errors = new List<string>();

			if (!(name_txt.Text.Length > 0)) //if name is empty
				errors.Add("Package must have a name");
			if (!(description_txt.Text.Length > 0)) //if description is empty
				errors.Add("Package must have a description");
			if (comission_txt.Text != "") //if comission is not empty
			{
				if (!comissionIsDecimal) //and is not decimal
					errors.Add("Comission must be a valid number");
				else if (comission > price)//and is heigher than the price
					errors.Add("Comission must not be greater than the price");
			}
			if (!priceIsDecimal || price_txt.Text == "")//if price is not decimal or is empty
				errors.Add("Price must be a valid number");
			if(endDate_txt.Text != "")//if end date is not empty
			{
				if (!endDateIsValid)//and is not datetime
					errors.Add("End date is invalid. Format: mm/dd/yyyy");
				else if (!(endDate > startDate))//and is not later than the start date
					errors.Add("End date must not be later than start date");
			}
			if (startDate_txt.Text != "" && !startDateIsValid) //if start date is not empty and is invalid
				errors.Add("Start date is invalid. Format: mm/dd/yyyy");

			if(errors.Count > 0) //if there are any errors
			{
				//does not proceed and shows message box
				MessageBox.Show(String.Join('\n', errors));
			}
			else
			{
				//assigns the form values to the package
				package.PkgName = name_txt.Text;
				package.PkgDesc = description_txt.Text;
				package.PkgBasePrice = price; //required by database
				package.PkgAgencyCommission = comission_txt.Text != "" ? comission : null;

				package.PkgStartDate = startDateIsValid ? startDate : null;
				package.PkgEndDate = endDateIsValid ? endDate : null;

				//if could save in the database, returns OK result
				if(TravelPackageManager.SavePackage(isAdd, package, products_list.Items.Cast<String>().ToList()))
					DialogResult = DialogResult.OK;				
			}
		}

		//adds products and suppliers to the productsSuppliers list
		private void add_button_Click(object sender, EventArgs e)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					int productID = int.Parse(product_box.Text.Split(':')[0]);
					int supplierID = int.Parse(supplier_box.Text.Split(':')[0]);
					if//if the product and supplier exist, and are not on the list, add to the list
					(
						db.Products.Find(productID) != null &&
						db.Suppliers.Find(supplierID) != null &&
						!products_list.Items.Contains(product_box.Text.Trim() + " - " + supplier_box.Text.Trim())
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

		//removes the selected productsSupplier from the list
		private void remove_button_Click(object sender, EventArgs e)
		{
			products_list.Items.RemoveAt(products_list.SelectedIndex);
		}
	}
}
