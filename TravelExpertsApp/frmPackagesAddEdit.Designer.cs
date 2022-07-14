namespace TravelExpertsApp
{
    partial class frmAddEdit
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
			this.name_txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.description_txt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.price_txt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comission_txt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.products_list = new System.Windows.Forms.ListBox();
			this.remove_button = new System.Windows.Forms.Button();
			this.product_box = new System.Windows.Forms.ComboBox();
			this.supplier_box = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.add_button = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.endDate_txt = new System.Windows.Forms.TextBox();
			this.startDate_txt = new System.Windows.Forms.TextBox();
			this.cancel_button = new System.Windows.Forms.Button();
			this.ok_button = new System.Windows.Forms.Button();
			this.message_label = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// name_txt
			// 
			this.name_txt.Location = new System.Drawing.Point(6, 37);
			this.name_txt.Name = "name_txt";
			this.name_txt.Size = new System.Drawing.Size(200, 23);
			this.name_txt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Package name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description:";
			// 
			// description_txt
			// 
			this.description_txt.Location = new System.Drawing.Point(6, 81);
			this.description_txt.Name = "description_txt";
			this.description_txt.Size = new System.Drawing.Size(200, 23);
			this.description_txt.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Base price:";
			// 
			// price_txt
			// 
			this.price_txt.Location = new System.Drawing.Point(6, 125);
			this.price_txt.Name = "price_txt";
			this.price_txt.Size = new System.Drawing.Size(100, 23);
			this.price_txt.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(106, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Comission:";
			// 
			// comission_txt
			// 
			this.comission_txt.Location = new System.Drawing.Point(106, 125);
			this.comission_txt.Name = "comission_txt";
			this.comission_txt.Size = new System.Drawing.Size(100, 23);
			this.comission_txt.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Start date:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "End date:";
			// 
			// products_list
			// 
			this.products_list.FormattingEnabled = true;
			this.products_list.ItemHeight = 15;
			this.products_list.Location = new System.Drawing.Point(6, 22);
			this.products_list.Name = "products_list";
			this.products_list.Size = new System.Drawing.Size(200, 184);
			this.products_list.TabIndex = 12;
			// 
			// remove_button
			// 
			this.remove_button.Location = new System.Drawing.Point(6, 212);
			this.remove_button.Name = "remove_button";
			this.remove_button.Size = new System.Drawing.Size(200, 35);
			this.remove_button.TabIndex = 14;
			this.remove_button.Text = "&Remove selection";
			this.remove_button.UseVisualStyleBackColor = true;
			this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
			// 
			// product_box
			// 
			this.product_box.FormattingEnabled = true;
			this.product_box.Location = new System.Drawing.Point(6, 41);
			this.product_box.Name = "product_box";
			this.product_box.Size = new System.Drawing.Size(200, 23);
			this.product_box.TabIndex = 15;
			// 
			// supplier_box
			// 
			this.supplier_box.FormattingEnabled = true;
			this.supplier_box.Location = new System.Drawing.Point(6, 85);
			this.supplier_box.Name = "supplier_box";
			this.supplier_box.Size = new System.Drawing.Size(200, 23);
			this.supplier_box.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 15);
			this.label9.TabIndex = 18;
			this.label9.Text = "Product type:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 15);
			this.label10.TabIndex = 19;
			this.label10.Text = "Supplier:";
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(6, 123);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(200, 35);
			this.add_button.TabIndex = 20;
			this.add_button.Text = "&Add product >>";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(260, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(451, 281);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Products";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.products_list);
			this.groupBox3.Controls.Add(this.remove_button);
			this.groupBox3.Location = new System.Drawing.Point(232, 22);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(213, 254);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Included products";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.product_box);
			this.groupBox2.Controls.Add(this.add_button);
			this.groupBox2.Controls.Add(this.supplier_box);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(6, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 254);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add product";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.endDate_txt);
			this.groupBox4.Controls.Add(this.startDate_txt);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.name_txt);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.description_txt);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.price_txt);
			this.groupBox4.Controls.Add(this.comission_txt);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Location = new System.Drawing.Point(6, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(250, 281);
			this.groupBox4.TabIndex = 22;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Package information";
			// 
			// endDate_txt
			// 
			this.endDate_txt.Location = new System.Drawing.Point(6, 239);
			this.endDate_txt.Name = "endDate_txt";
			this.endDate_txt.Size = new System.Drawing.Size(200, 23);
			this.endDate_txt.TabIndex = 13;
			// 
			// startDate_txt
			// 
			this.startDate_txt.Location = new System.Drawing.Point(6, 195);
			this.startDate_txt.Name = "startDate_txt";
			this.startDate_txt.Size = new System.Drawing.Size(200, 23);
			this.startDate_txt.TabIndex = 12;
			// 
			// cancel_button
			// 
			this.cancel_button.Location = new System.Drawing.Point(608, 299);
			this.cancel_button.Name = "cancel_button";
			this.cancel_button.Size = new System.Drawing.Size(90, 35);
			this.cancel_button.TabIndex = 21;
			this.cancel_button.Text = "&Cancel";
			this.cancel_button.UseVisualStyleBackColor = true;
			this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
			// 
			// ok_button
			// 
			this.ok_button.Location = new System.Drawing.Point(498, 299);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(90, 35);
			this.ok_button.TabIndex = 23;
			this.ok_button.Text = "&Ok";
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// message_label
			// 
			this.message_label.AutoSize = true;
			this.message_label.Location = new System.Drawing.Point(12, 309);
			this.message_label.Name = "message_label";
			this.message_label.Size = new System.Drawing.Size(0, 15);
			this.message_label.TabIndex = 24;
			// 
			// frmAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 343);
			this.Controls.Add(this.message_label);
			this.Controls.Add(this.ok_button);
			this.Controls.Add(this.cancel_button);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmAddEdit";
			this.Text = "frmAddEdit";
			this.Load += new System.EventHandler(this.frmAddEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private TextBox name_txt;
		private Label label1;
		private Label label2;
		private TextBox description_txt;
		private Label label3;
		private TextBox price_txt;
		private Label label4;
		private TextBox comission_txt;
		private Label label5;
		private Label label6;
		private ListBox products_list;
		private Button remove_button;
		private ComboBox product_box;
		private ComboBox supplier_box;
		private Label label9;
		private Label label10;
		private Button add_button;
		private GroupBox groupBox1;
		private GroupBox groupBox3;
		private GroupBox groupBox2;
		private GroupBox groupBox4;
		private Button cancel_button;
		private Button ok_button;
		private Label message_label;
		private TextBox endDate_txt;
		private TextBox startDate_txt;
	}
}