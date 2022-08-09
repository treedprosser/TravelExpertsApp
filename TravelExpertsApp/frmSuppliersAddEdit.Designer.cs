namespace TravelExpertsApp
{
    partial class frmSuppliersAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtBoxSupID = new System.Windows.Forms.TextBox();
            this.txtBoxSupName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(12, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(69, 15);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Tag = "supplier id";
            this.lblFirstName.Text = "Supplier ID";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSupplierName.Location = new System.Drawing.Point(12, 114);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(92, 15);
            this.lblSupplierName.TabIndex = 3;
            this.lblSupplierName.Tag = "Supplier Name";
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // txtBoxSupID
            // 
            this.txtBoxSupID.Location = new System.Drawing.Point(88, 43);
            this.txtBoxSupID.Name = "txtBoxSupID";
            this.txtBoxSupID.Size = new System.Drawing.Size(218, 23);
            this.txtBoxSupID.TabIndex = 14;
            // 
            // txtBoxSupName
            // 
            this.txtBoxSupName.Location = new System.Drawing.Point(120, 111);
            this.txtBoxSupName.Name = "txtBoxSupName";
            this.txtBoxSupName.Size = new System.Drawing.Size(218, 23);
            this.txtBoxSupName.TabIndex = 15;
            this.txtBoxSupName.Tag = "SubName";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(147, 436);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 67);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // frmSuppliersAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 515);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtBoxSupName);
            this.Controls.Add(this.txtBoxSupID);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.button2);
            this.Name = "frmSuppliersAddEdit";
            this.Text = "frmSuppliersAddEdit";
            this.Load += new System.EventHandler(this.frmSuppliersAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFirstName;
        private Label lblSupplierName;
        private TextBox txtBoxSupID;
        private TextBox txtBoxSupName;
        private Button button2;
        private Button buttonAdd;
    }
}