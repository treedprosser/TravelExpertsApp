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
        public frmSuppliersAddEdit()
        {
            InitializeComponent();
        }

        private string formAction;
        // todo: Form values

        private void buttonSubmitForm_Click(object sender, EventArgs e)
        {

            // Create a new generic product object
            Supplier newSupplier = new Supplier();

            // Get a list of all textBoxes to be validated
            List<TextBox> textBoxList = new();
            //textBoxList.Add(txtBoxSupID);
            //textBoxList.Add(txtBoxSubName);
            //TODO



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

                        //TODO
                        //newSupplier.SupName = txtBoxSupName.Text;

                        //// Open a connection to the database
                        ////using (TravelExpertsContext db = new TravelExpertsContext())
                        //{
                        //    // Add the new product to the database
                        //    database.SupplierContacts.Add(newSupplier);
                        //    // Save changes
                        //    database.SaveChanges();
                        //}

                        // Close the dialog
                        // todo close dialog function
                    }

                    break;

            }
        }
    }
}