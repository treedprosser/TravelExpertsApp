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
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.cbo_products = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Suppliers = new System.Windows.Forms.ComboBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btn_EditProd = new System.Windows.Forms.Button();
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_ProductsSuppliers = new System.Windows.Forms.ComboBox();
            this.btn_AddPS = new System.Windows.Forms.Button();
            this.btn_EditPS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
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
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // cbo_products
            // 
            this.cbo_products.FormattingEnabled = true;
            this.cbo_products.Location = new System.Drawing.Point(510, 71);
            this.cbo_products.Name = "cbo_products";
            this.cbo_products.Size = new System.Drawing.Size(260, 29);
            this.cbo_products.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suppliers:";
            // 
            // cbo_Suppliers
            // 
            this.cbo_Suppliers.FormattingEnabled = true;
            this.cbo_Suppliers.Location = new System.Drawing.Point(510, 218);
            this.cbo_Suppliers.Name = "cbo_Suppliers";
            this.cbo_Suppliers.Size = new System.Drawing.Size(260, 29);
            this.cbo_Suppliers.TabIndex = 6;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(508, 106);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(128, 33);
            this.btnAddProd.TabIndex = 7;
            this.btnAddProd.Text = "&Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btn_EditProd
            // 
            this.btn_EditProd.Location = new System.Drawing.Point(642, 106);
            this.btn_EditProd.Name = "btn_EditProd";
            this.btn_EditProd.Size = new System.Drawing.Size(128, 33);
            this.btn_EditProd.TabIndex = 8;
            this.btn_EditProd.Text = "&Edit Product";
            this.btn_EditProd.UseVisualStyleBackColor = true;
            this.btn_EditProd.Click += new System.EventHandler(this.btn_EditProd_Click);
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.Location = new System.Drawing.Point(508, 253);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(128, 33);
            this.btn_AddSupplier.TabIndex = 9;
            this.btn_AddSupplier.Text = "&Add Supplier";
            this.btn_AddSupplier.UseVisualStyleBackColor = true;
            this.btn_AddSupplier.Click += new System.EventHandler(this.btn_AddSupplier_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(642, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 33);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit Supplier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(33, 47);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowTemplate.Height = 25;
            this.dgvPackages.Size = new System.Drawing.Size(405, 229);
            this.dgvPackages.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Products-Suppliers";
            this.label3.Visible = false;
            // 
            // cbo_ProductsSuppliers
            // 
            this.cbo_ProductsSuppliers.FormattingEnabled = true;
            this.cbo_ProductsSuppliers.Location = new System.Drawing.Point(510, 343);
            this.cbo_ProductsSuppliers.Name = "cbo_ProductsSuppliers";
            this.cbo_ProductsSuppliers.Size = new System.Drawing.Size(260, 29);
            this.cbo_ProductsSuppliers.TabIndex = 13;
            this.cbo_ProductsSuppliers.Visible = false;
            // 
            // btn_AddPS
            // 
            this.btn_AddPS.Location = new System.Drawing.Point(508, 378);
            this.btn_AddPS.Name = "btn_AddPS";
            this.btn_AddPS.Size = new System.Drawing.Size(128, 33);
            this.btn_AddPS.TabIndex = 14;
            this.btn_AddPS.Text = "&Add Prod/Sup";
            this.btn_AddPS.UseVisualStyleBackColor = true;
            this.btn_AddPS.Visible = false;
            this.btn_AddPS.Click += new System.EventHandler(this.btn_AddPS_Click);
            // 
            // btn_EditPS
            // 
            this.btn_EditPS.Location = new System.Drawing.Point(642, 378);
            this.btn_EditPS.Name = "btn_EditPS";
            this.btn_EditPS.Size = new System.Drawing.Size(128, 33);
            this.btn_EditPS.TabIndex = 15;
            this.btn_EditPS.Text = "&Edit Prod/Sup";
            this.btn_EditPS.UseVisualStyleBackColor = true;
            this.btn_EditPS.Visible = false;
            this.btn_EditPS.Click += new System.EventHandler(this.btn_EditPS_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.btn_EditPS);
            this.Controls.Add(this.btn_AddPS);
            this.Controls.Add(this.cbo_ProductsSuppliers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_AddSupplier);
            this.Controls.Add(this.btn_EditProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.cbo_Suppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_products);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Travel Experts ";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddPackage;
        private Button btnEditPackage;
        private ComboBox cbo_products;
        private Label label1;
        private Label label2;
        private ComboBox cbo_Suppliers;
        private Button btnAddProd;
        private Button btn_EditProd;
        private Button btn_AddSupplier;
        private Button btnEdit;
        private DataGridView dgvPackages;
        private Label label3;
        private ComboBox cbo_ProductsSuppliers;
        private Button btn_AddPS;
        private Button btn_EditPS;
    }
}