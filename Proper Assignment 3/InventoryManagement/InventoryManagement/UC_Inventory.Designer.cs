namespace InventoryManagement
{
    partial class UC_Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdvProducts = new DataGridView();
            grpbxProductDet = new GroupBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtBrand = new TextBox();
            lblBrand = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtID = new TextBox();
            lblID = new Label();
            grpbxDelProd = new GroupBox();
            btnDelProd = new Button();
            txtDelProd = new TextBox();
            btnCSVSAVE = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)grdvProducts).BeginInit();
            grpbxProductDet.SuspendLayout();
            grpbxDelProd.SuspendLayout();
            SuspendLayout();
            // 
            // grdvProducts
            // 
            grdvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdvProducts.Location = new Point(285, 39);
            grdvProducts.Name = "grdvProducts";
            grdvProducts.Size = new Size(308, 313);
            grdvProducts.TabIndex = 1;
            grdvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpbxProductDet
            // 
            grpbxProductDet.Controls.Add(txtPrice);
            grpbxProductDet.Controls.Add(lblPrice);
            grpbxProductDet.Controls.Add(txtQuantity);
            grpbxProductDet.Controls.Add(lblQuantity);
            grpbxProductDet.Controls.Add(txtBrand);
            grpbxProductDet.Controls.Add(lblBrand);
            grpbxProductDet.Controls.Add(txtName);
            grpbxProductDet.Controls.Add(lblName);
            grpbxProductDet.Controls.Add(txtID);
            grpbxProductDet.Controls.Add(lblID);
            grpbxProductDet.Location = new Point(31, 28);
            grpbxProductDet.Name = "grpbxProductDet";
            grpbxProductDet.Size = new Size(200, 194);
            grpbxProductDet.TabIndex = 2;
            grpbxProductDet.TabStop = false;
            grpbxProductDet.Text = " Product Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(76, 153);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 156);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(76, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 7;
            txtQuantity.TextChanged += textBox4_TextChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(10, 123);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(76, 88);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 5;
            txtBrand.TextChanged += textBox3_TextChanged;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(10, 91);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Brand";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(76, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(10, 32);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // grpbxDelProd
            // 
            grpbxDelProd.Controls.Add(btnDelProd);
            grpbxDelProd.Controls.Add(txtDelProd);
            grpbxDelProd.Location = new Point(31, 272);
            grpbxDelProd.Name = "grpbxDelProd";
            grpbxDelProd.Size = new Size(200, 80);
            grpbxDelProd.TabIndex = 8;
            grpbxDelProd.TabStop = false;
            grpbxDelProd.Text = "Delete with ID/Name";
            // 
            // btnDelProd
            // 
            btnDelProd.Location = new Point(9, 28);
            btnDelProd.Name = "btnDelProd";
            btnDelProd.Size = new Size(54, 25);
            btnDelProd.TabIndex = 2;
            btnDelProd.Text = "Delete";
            btnDelProd.UseVisualStyleBackColor = true;
            btnDelProd.Click += btnDelProd_Click;
            // 
            // txtDelProd
            // 
            txtDelProd.Location = new Point(76, 29);
            txtDelProd.Name = "txtDelProd";
            txtDelProd.Size = new Size(100, 23);
            txtDelProd.TabIndex = 1;
            // 
            // btnCSVSAVE
            // 
            btnCSVSAVE.Location = new Point(31, 378);
            btnCSVSAVE.Name = "btnCSVSAVE";
            btnCSVSAVE.Size = new Size(67, 23);
            btnCSVSAVE.TabIndex = 3;
            btnCSVSAVE.Text = "Save";
            btnCSVSAVE.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnCSVSAVE);
            Controls.Add(grpbxDelProd);
            Controls.Add(grpbxProductDet);
            Controls.Add(grdvProducts);
            Name = "UC_Inventory";
            Size = new Size(619, 436);
            Load += UC_Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)grdvProducts).EndInit();
            grpbxProductDet.ResumeLayout(false);
            grpbxProductDet.PerformLayout();
            grpbxDelProd.ResumeLayout(false);
            grpbxDelProd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView grdvProducts;
        private GroupBox grpbxProductDet;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtBrand;
        private Label lblBrand;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtID;
        private Label lblID;
        private GroupBox grpbxDelProd;
        private Button btnDelProd;
        private TextBox txtDelProd;
        private Button btnCSVSAVE;
        private TextBox txtPrice;
        private Label lblPrice;
        private Button btnUpdate;
        private Button btnAdd;
    }
}
