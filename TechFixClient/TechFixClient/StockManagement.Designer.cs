namespace TechFixClient
{
    partial class StockManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHSId = new System.Windows.Forms.Label();
            this.txtHSId = new System.Windows.Forms.TextBox();
            this.txtHSStock = new System.Windows.Forms.TextBox();
            this.lblHSStock = new System.Windows.Forms.Label();
            this.txtHSDescription = new System.Windows.Forms.TextBox();
            this.lblHSDescription = new System.Windows.Forms.Label();
            this.txtHSCategory = new System.Windows.Forms.TextBox();
            this.lblHSCategory = new System.Windows.Forms.Label();
            this.txtHSPrice = new System.Windows.Forms.TextBox();
            this.lblHSPrice = new System.Windows.Forms.Label();
            this.txtHSName = new System.Windows.Forms.TextBox();
            this.lblHSName = new System.Windows.Forms.Label();
            this.btnHSAdd = new System.Windows.Forms.Button();
            this.btnHSSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management";
            // 
            // lblHSId
            // 
            this.lblHSId.AutoSize = true;
            this.lblHSId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSId.Location = new System.Drawing.Point(101, 144);
            this.lblHSId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSId.Name = "lblHSId";
            this.lblHSId.Size = new System.Drawing.Size(31, 28);
            this.lblHSId.TabIndex = 1;
            this.lblHSId.Text = "ID";
            // 
            // txtHSId
            // 
            this.txtHSId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSId.Location = new System.Drawing.Point(156, 142);
            this.txtHSId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSId.Name = "txtHSId";
            this.txtHSId.Size = new System.Drawing.Size(194, 30);
            this.txtHSId.TabIndex = 2;
            // 
            // txtHSStock
            // 
            this.txtHSStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSStock.Location = new System.Drawing.Point(156, 430);
            this.txtHSStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSStock.Name = "txtHSStock";
            this.txtHSStock.Size = new System.Drawing.Size(305, 30);
            this.txtHSStock.TabIndex = 4;
            // 
            // lblHSStock
            // 
            this.lblHSStock.AutoSize = true;
            this.lblHSStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSStock.Location = new System.Drawing.Point(72, 432);
            this.lblHSStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSStock.Name = "lblHSStock";
            this.lblHSStock.Size = new System.Drawing.Size(60, 28);
            this.lblHSStock.TabIndex = 3;
            this.lblHSStock.Text = "Stock";
            // 
            // txtHSDescription
            // 
            this.txtHSDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSDescription.Location = new System.Drawing.Point(156, 346);
            this.txtHSDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSDescription.Multiline = true;
            this.txtHSDescription.Name = "txtHSDescription";
            this.txtHSDescription.Size = new System.Drawing.Size(305, 65);
            this.txtHSDescription.TabIndex = 6;
            // 
            // lblHSDescription
            // 
            this.lblHSDescription.AutoSize = true;
            this.lblHSDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSDescription.Location = new System.Drawing.Point(20, 346);
            this.lblHSDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSDescription.Name = "lblHSDescription";
            this.lblHSDescription.Size = new System.Drawing.Size(112, 28);
            this.lblHSDescription.TabIndex = 5;
            this.lblHSDescription.Text = "Description";
            // 
            // txtHSCategory
            // 
            this.txtHSCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSCategory.Location = new System.Drawing.Point(156, 296);
            this.txtHSCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSCategory.Name = "txtHSCategory";
            this.txtHSCategory.Size = new System.Drawing.Size(305, 30);
            this.txtHSCategory.TabIndex = 8;
            // 
            // lblHSCategory
            // 
            this.lblHSCategory.AutoSize = true;
            this.lblHSCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSCategory.Location = new System.Drawing.Point(40, 298);
            this.lblHSCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSCategory.Name = "lblHSCategory";
            this.lblHSCategory.Size = new System.Drawing.Size(92, 28);
            this.lblHSCategory.TabIndex = 7;
            this.lblHSCategory.Text = "Category";
            // 
            // txtHSPrice
            // 
            this.txtHSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSPrice.Location = new System.Drawing.Point(156, 241);
            this.txtHSPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSPrice.Name = "txtHSPrice";
            this.txtHSPrice.Size = new System.Drawing.Size(305, 30);
            this.txtHSPrice.TabIndex = 10;
            // 
            // lblHSPrice
            // 
            this.lblHSPrice.AutoSize = true;
            this.lblHSPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSPrice.Location = new System.Drawing.Point(78, 243);
            this.lblHSPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSPrice.Name = "lblHSPrice";
            this.lblHSPrice.Size = new System.Drawing.Size(54, 28);
            this.lblHSPrice.TabIndex = 9;
            this.lblHSPrice.Text = "Price";
            // 
            // txtHSName
            // 
            this.txtHSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSName.Location = new System.Drawing.Point(156, 191);
            this.txtHSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSName.Name = "txtHSName";
            this.txtHSName.Size = new System.Drawing.Size(305, 30);
            this.txtHSName.TabIndex = 12;
            // 
            // lblHSName
            // 
            this.lblHSName.AutoSize = true;
            this.lblHSName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSName.Location = new System.Drawing.Point(68, 193);
            this.lblHSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSName.Name = "lblHSName";
            this.lblHSName.Size = new System.Drawing.Size(64, 28);
            this.lblHSName.TabIndex = 11;
            this.lblHSName.Text = "Name";
            // 
            // btnHSAdd
            // 
            this.btnHSAdd.BackColor = System.Drawing.Color.Navy;
            this.btnHSAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSAdd.ForeColor = System.Drawing.Color.White;
            this.btnHSAdd.Location = new System.Drawing.Point(156, 478);
            this.btnHSAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSAdd.Name = "btnHSAdd";
            this.btnHSAdd.Size = new System.Drawing.Size(130, 44);
            this.btnHSAdd.TabIndex = 13;
            this.btnHSAdd.Text = "Add";
            this.btnHSAdd.UseVisualStyleBackColor = false;
            this.btnHSAdd.Click += new System.EventHandler(this.btnHSAdd_Click);
            // 
            // btnHSSearch
            // 
            this.btnHSSearch.BackColor = System.Drawing.Color.Navy;
            this.btnHSSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSSearch.ForeColor = System.Drawing.Color.White;
            this.btnHSSearch.Location = new System.Drawing.Point(361, 134);
            this.btnHSSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHSSearch.Name = "btnHSSearch";
            this.btnHSSearch.Size = new System.Drawing.Size(100, 44);
            this.btnHSSearch.TabIndex = 17;
            this.btnHSSearch.Text = "Search";
            this.btnHSSearch.UseVisualStyleBackColor = false;
            this.btnHSSearch.Click += new System.EventHandler(this.btnHSSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(331, 478);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 44);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProducts.Location = new System.Drawing.Point(535, 114);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(616, 391);
            this.dgvProducts.TabIndex = 19;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1167, 554);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHSSearch);
            this.Controls.Add(this.btnHSAdd);
            this.Controls.Add(this.txtHSName);
            this.Controls.Add(this.lblHSName);
            this.Controls.Add(this.txtHSPrice);
            this.Controls.Add(this.lblHSPrice);
            this.Controls.Add(this.txtHSCategory);
            this.Controls.Add(this.lblHSCategory);
            this.Controls.Add(this.txtHSDescription);
            this.Controls.Add(this.lblHSDescription);
            this.Controls.Add(this.txtHSStock);
            this.Controls.Add(this.lblHSStock);
            this.Controls.Add(this.txtHSId);
            this.Controls.Add(this.lblHSId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHSId;
        private System.Windows.Forms.TextBox txtHSId;
        private System.Windows.Forms.TextBox txtHSStock;
        private System.Windows.Forms.Label lblHSStock;
        private System.Windows.Forms.TextBox txtHSDescription;
        private System.Windows.Forms.Label lblHSDescription;
        private System.Windows.Forms.TextBox txtHSCategory;
        private System.Windows.Forms.Label lblHSCategory;
        private System.Windows.Forms.TextBox txtHSPrice;
        private System.Windows.Forms.Label lblHSPrice;
        private System.Windows.Forms.TextBox txtHSName;
        private System.Windows.Forms.Label lblHSName;
        private System.Windows.Forms.Button btnHSAdd;
        private System.Windows.Forms.Button btnHSSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}