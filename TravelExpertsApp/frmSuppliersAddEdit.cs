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
    public partial class frmSuppliersAddEdit : Form
    {
        public frmSuppliersAddEdit(string formAction, int supplierID, string supplierName)
        {
            InitializeComponent();
            this.formAction = formAction;
            this.supplierName = supplierName;
        }

        private string formAction;
        private string supplierName;
        private int supplierID = 13567;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create a new generic Supplier object
            Supplier newSupplier = new Supplier();

            // Get a list of all textBoxes to be validated
            List<TextBox> textBoxList = new();
            textBoxList.Add(txtBoxSupName);

            //Validation
            bool valid = true;
            for (int i = 0; i < textBoxList.Count; i++)
            {
                if (!Validator.IsPresent(textBoxList[i]))
                {
                    valid = false;
                }

            }

            if (valid)
            {

                // Determine the form function
                switch (formAction)
                {
                    //If the form action is "add"
                    case "add":

                        // Confirm if they want to save the change
                        DialogResult confirm = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

                        // confirm change
                        if (confirm == DialogResult.Yes)
                        {

                            //adding value to blank object from textbox
                            newSupplier.SupName = txtBoxSupName.Text;
                            newSupplier.SupplierId = supplierID;
                            supplierID++;

                            // Open a connection to the database
                            using (TravelExpertsContext db = new TravelExpertsContext())
                            {
                                // Add the new product to the database
                                db.Suppliers.Add(newSupplier);
                                // Save changes
                                db.SaveChanges();
                            }

                        }

                        break;

                    case "edit":

                        // Confirm if they want to save the change
                        DialogResult confirmEdit = MessageBox.Show("Are you sure you want to save these changes?", "Confirm Changes", MessageBoxButtons.YesNo);

                        // confirm change
                        if (confirmEdit == DialogResult.Yes)
                        {

                            //set blank obj values from selected supplier from the main form
                            newSupplier.SupName = supplierName;

                            // creating blank object to be updated/added
                            Supplier updatedSupplier = new Supplier();

                            // update blank object from textbox input
                            updatedSupplier.SupName = txtBoxSupName.Text;

                            // Open a connection to the database
                            using (TravelExpertsContext db = new TravelExpertsContext())
                            {
                                // Add the new supplier to the database
                                db.Suppliers.Remove(newSupplier);
                                db.Suppliers.Add(updatedSupplier);
                                // Save changes
                                db.SaveChanges();
                            }


                        }

                        break;
                }
            }
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void frmSuppliersAddEdit_Load(object sender, EventArgs e)
        {

            // Determine form action
            switch (formAction)
            {

                // Form action "add"
                case "add":

                    // Sets the form text to "add supplier"
                    this.Text = "Add Supplier";

                    // Set the active control to supplier name
                    this.ActiveControl = txtBoxSupName;

                    txtBoxSupName.Text = "";

                    break;

                // Form action "edit"
                case "edit":

                    // Sets the form text to "modify supplier"
                    this.Text = "Modify Supplier";
                    buttonAdd.Text = "Edit";
                    // Set the active control to supplier name
                    this.ActiveControl = txtBoxSupName;
                    txtBoxSupName.Text = supplierName;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}