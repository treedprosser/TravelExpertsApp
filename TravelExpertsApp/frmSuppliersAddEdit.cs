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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace TravelExpertsApp
{
    public partial class frmSuppliersAddEdit : Form
    {
        public frmSuppliersAddEdit()
        {
            InitializeComponent();
        }
        private string formAction;
        private string SupConFirstName;
        private string SupConLastName;
        private string SupConCompany;
        private string SupConAddress;
        private string SupConCity;
        private string SupConProv;
        private string SupConPostal;
        private string SupConCountry;
        private string SupConBusPhone;
        private string SupConFax;
        private string SupConEmail;
        private string SupConUrl;

        private void buttonSubmitForm_Click(object sender, EventArgs e)
        {

            // Create a new generic product object
            Supplier newSupplier = new Supplier();

            // Get a list of all textBoxes to be validated
            List<TextBox> textBoxList = new();
            textBoxList.Add(txtBoxFirstName);
            textBoxList.Add(txtBoxLastName);
            textBoxList.Add(txtBoxCompany);
            textBoxList.Add(txtBoxAddress);
            textBoxList.Add(txtBoxCity);
            textBoxList.Add(txtBoxProvince);
            textBoxList.Add(txtBoxPostal);
            textBoxList.Add(txtBoxCountry);
            textBoxList.Add(txtBoxPhone);
            textBoxList.Add(txtBoxFax);
            textBoxList.Add(txtBoxEmail);
            textBoxList.Add(txtBoxUrl);


            // Determine the form function
            switch (formAction)
            {
                //If the form action is "add"
                case "add":

                    // Sets the form text to "add Supplier"
                    this.Text = "Add Suplier";

                    
                    

                    // Validate textBoxList
                    if (Validation.ContainsLegalCharacters(textBoxList, "|!@#$%^&*()-=_+[],<>:?`~"))
                    {
                        // Validate textBoxPhone
                        if (Validation.IsLengthWithinBounds(txtBoxPhone, 1, 10))
                        {
                            // Validate textBoxFirstName
                            if (Validation.IsLengthWithinBounds(txtBoxFirstName, 1, 50))
                            {


                                {
                                    // Confirm if they want to save the change
                                    DialogResult confirm = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

                                    // confirm change
                                    if (confirm == DialogResult.Yes)
                                    {
                                        // 
                                        newSupplier.SupConFirstName = txtBoxFirstName.Text;
                                        newSupplier.SupConLastName = txtBoxLastName.Text;
                                        newSupplier.SupConCompany = txtBoxCompany.Text;
                                        newSupplier.SupConAddress = txtBoxAddress.Text;
                                        newSupplier.SupConCity = txtBoxCity.Text;
                                        newSupplier.SupConProvince = txtBoxProvince.Text;
                                        newSupplier.SupConPostal = txtBoxPostal.Text;
                                        newSupplier.SupConCountry = txtBoxCountry.Text;
                                        newSupplier.SupConPhone = txtBoxPhone.Text;
                                        newSupplier.SupConFax = txtBoxFax.Text;
                                        newSupplier.SupConEmail = txtBoxEmail.Text;
                                        newSupplier.SupConWebsite = txtBoxUrl.Text;



                                        //// Open a connection to the database
                                        ////using (TravelExpertsContext db = new TravelExpertsContext())
                                        //{
                                        //    // Add the new product to the database
                                        //    database.SupplierContacts.Add(newSupplier);
                                        //    // Save changes
                                        //    database.SaveChanges();
                                        //}

                                        // Close the dialog
                                        CloseDialog();
                                    }
                                



                                // Invalid format
                                else
                                {
                                    MessageBox.Show(
                                        "Invalid Phone number format provided!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }
                            }
                            // Invalid Name
                            else
                            {
                                MessageBox.Show(
                                        "Invalid Name length provided!",
                                        "Invalid Name",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                            }
                        }
                        // Invalid Code
                        else
                        {
                            MessageBox.Show(
                                        "Invalid Code length provided!",
                                        "Invalid Code",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                        }
                    }
                    // incorrect Characters
                    else
                    {
                        MessageBox.Show(
                                    "Invalid characters provided!",
                                    "Invalid Code",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                    }

                    break;




            }
        }