namespace TravelExpertsApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPackages = new System.Windows.Forms.ListBox();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.cbo_products = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Suppliers = new System.Windows.Forms.ComboBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btn_EditProd = new System.Windows.Forms.Button();
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.btn_EditSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPackages
            // 
            this.lstPackages.FormattingEnabled = true;
            this.lstPackages.ItemHeight = 21;
            this.lstPackages.Location = new System.Drawing.Point(24, 25);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(371, 235);
            this.lstPackages.TabIndex = 0;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(40, 282);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(133, 58);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "&Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(225, 282);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(134, 58);
            this.btnEditPackage.TabIndex = 2;
            this.btnEditPackage.Text = "&Edit Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            // 
            // cbo_products
            // 
            this.cbo_products.FormattingEnabled = true;
            this.cbo_products.Location = new System.Drawing.Point(467, 81);
            this.cbo_products.Name = "cbo_products";
            this.cbo_products.Size = new System.Drawing.Size(260, 29);
            this.cbo_products.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suppliers:";
            // 
            // cbo_Suppliers
            // 
            this.cbo_Suppliers.FormattingEnabled = true;
            this.cbo_Suppliers.Location = new System.Drawing.Point(467, 282);
            this.cbo_Suppliers.Name = "cbo_Suppliers";
            this.cbo_Suppliers.Size = new System.Drawing.Size(260, 29);
            this.cbo_Suppliers.TabIndex = 6;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(467, 136);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(128, 33);
            this.btnAddProd.TabIndex = 7;
            this.btnAddProd.Text = "&Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // btn_EditProd
            // 
            this.btn_EditProd.Location = new System.Drawing.Point(601, 136);
            this.btn_EditProd.Name = "btn_EditProd";
            this.btn_EditProd.Size = new System.Drawing.Size(128, 33);
            this.btn_EditProd.TabIndex = 8;
            this.btn_EditProd.Text = "&Edit Product";
            this.btn_EditProd.UseVisualStyleBackColor = true;
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.Location = new System.Drawing.Point(467, 333);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(128, 33);
            this.btn_AddSupplier.TabIndex = 9;
            this.btn_AddSupplier.Text = "&Add Supplier";
            this.btn_AddSupplier.UseVisualStyleBackColor = true;
            // 
            // btn_EditSupplier
            // 
            this.btn_EditSupplier.Location = new System.Drawing.Point(601, 333);
            this.btn_EditSupplier.Name = "btn_EditSupplier";
            this.btn_EditSupplier.Size = new System.Drawing.Size(128, 33);
            this.btn_EditSupplier.TabIndex = 10;
            this.btn_EditSupplier.Text = "&Edit Supplier";
            this.btn_EditSupplier.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.btn_EditSupplier);
            this.Controls.Add(this.btn_AddSupplier);
            this.Controls.Add(this.btn_EditProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.cbo_Suppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_products);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.lstPackages);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstPackages;
        private Button btnAddPackage;
        private Button btnEditPackage;
        private ComboBox cbo_products;
        private Label label1;
        private Label label2;
        private ComboBox cbo_Suppliers;
        private Button btnAddProd;
        private Button btn_EditProd;
        private Button btn_AddSupplier;
        private Button btn_EditSupplier;
    }
}