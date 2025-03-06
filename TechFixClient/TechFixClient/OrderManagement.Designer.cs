namespace TechFixClient
{
    partial class OrderManagement
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
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.txtOId = new System.Windows.Forms.TextBox();
            this.lblOId = new System.Windows.Forms.Label();
            this.btnOUpdate = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.txtODeliveryLocation = new System.Windows.Forms.TextBox();
            this.lblODeliveryLocation = new System.Windows.Forms.Label();
            this.txtODeliveryOn = new System.Windows.Forms.TextBox();
            this.lblODeliveryOn = new System.Windows.Forms.Label();
            this.txtODateOfOrder = new System.Windows.Forms.TextBox();
            this.lblODateOfOrder = new System.Windows.Forms.Label();
            this.txtOCustomerName = new System.Windows.Forms.TextBox();
            this.lblOCustomerName = new System.Windows.Forms.Label();
            this.txtOQuantity = new System.Windows.Forms.TextBox();
            this.lblOQuantity = new System.Windows.Forms.Label();
            this.txtOProductName = new System.Windows.Forms.TextBox();
            this.lblOProductName = new System.Windows.Forms.Label();
            this.btnHOSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderStatus.Location = new System.Drawing.Point(205, 378);
            this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(240, 27);
            this.txtOrderStatus.TabIndex = 34;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(71, 382);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(106, 23);
            this.lblOrderStatus.TabIndex = 33;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // txtOId
            // 
            this.txtOId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOId.Location = new System.Drawing.Point(205, 129);
            this.txtOId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOId.Name = "txtOId";
            this.txtOId.Size = new System.Drawing.Size(132, 27);
            this.txtOId.TabIndex = 20;
            // 
            // lblOId
            // 
            this.lblOId.AutoSize = true;
            this.lblOId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOId.Location = new System.Drawing.Point(150, 133);
            this.lblOId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOId.Name = "lblOId";
            this.lblOId.Size = new System.Drawing.Size(27, 23);
            this.lblOId.TabIndex = 19;
            this.lblOId.Text = "ID";
            // 
            // btnOUpdate
            // 
            this.btnOUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnOUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOUpdate.ForeColor = System.Drawing.Color.White;
            this.btnOUpdate.Location = new System.Drawing.Point(143, 484);
            this.btnOUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOUpdate.Name = "btnOUpdate";
            this.btnOUpdate.Size = new System.Drawing.Size(174, 45);
            this.btnOUpdate.TabIndex = 37;
            this.btnOUpdate.Text = "Update";
            this.btnOUpdate.UseVisualStyleBackColor = false;
            this.btnOUpdate.Click += new System.EventHandler(this.btnOUpdate_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(477, 122);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.Size = new System.Drawing.Size(537, 386);
            this.dgvOrder.TabIndex = 38;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // txtODeliveryLocation
            // 
            this.txtODeliveryLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODeliveryLocation.Location = new System.Drawing.Point(205, 424);
            this.txtODeliveryLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtODeliveryLocation.Name = "txtODeliveryLocation";
            this.txtODeliveryLocation.Size = new System.Drawing.Size(240, 27);
            this.txtODeliveryLocation.TabIndex = 50;
            // 
            // lblODeliveryLocation
            // 
            this.lblODeliveryLocation.AutoSize = true;
            this.lblODeliveryLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODeliveryLocation.Location = new System.Drawing.Point(5, 428);
            this.lblODeliveryLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblODeliveryLocation.Name = "lblODeliveryLocation";
            this.lblODeliveryLocation.Size = new System.Drawing.Size(192, 23);
            this.lblODeliveryLocation.TabIndex = 49;
            this.lblODeliveryLocation.Text = "Order Delivery Location";
            // 
            // txtODeliveryOn
            // 
            this.txtODeliveryOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODeliveryOn.Location = new System.Drawing.Point(205, 339);
            this.txtODeliveryOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtODeliveryOn.Name = "txtODeliveryOn";
            this.txtODeliveryOn.Size = new System.Drawing.Size(240, 27);
            this.txtODeliveryOn.TabIndex = 48;
            // 
            // lblODeliveryOn
            // 
            this.lblODeliveryOn.AutoSize = true;
            this.lblODeliveryOn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODeliveryOn.Location = new System.Drawing.Point(86, 343);
            this.lblODeliveryOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblODeliveryOn.Name = "lblODeliveryOn";
            this.lblODeliveryOn.Size = new System.Drawing.Size(91, 23);
            this.lblODeliveryOn.TabIndex = 47;
            this.lblODeliveryOn.Text = "Deliver On";
            // 
            // txtODateOfOrder
            // 
            this.txtODateOfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODateOfOrder.Location = new System.Drawing.Point(205, 296);
            this.txtODateOfOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtODateOfOrder.Name = "txtODateOfOrder";
            this.txtODateOfOrder.Size = new System.Drawing.Size(240, 27);
            this.txtODateOfOrder.TabIndex = 46;
            // 
            // lblODateOfOrder
            // 
            this.lblODateOfOrder.AutoSize = true;
            this.lblODateOfOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODateOfOrder.Location = new System.Drawing.Point(58, 300);
            this.lblODateOfOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblODateOfOrder.Name = "lblODateOfOrder";
            this.lblODateOfOrder.Size = new System.Drawing.Size(119, 23);
            this.lblODateOfOrder.TabIndex = 45;
            this.lblODateOfOrder.Text = "Date Of Order";
            // 
            // txtOCustomerName
            // 
            this.txtOCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOCustomerName.Location = new System.Drawing.Point(205, 259);
            this.txtOCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOCustomerName.Name = "txtOCustomerName";
            this.txtOCustomerName.Size = new System.Drawing.Size(240, 27);
            this.txtOCustomerName.TabIndex = 44;
            // 
            // lblOCustomerName
            // 
            this.lblOCustomerName.AutoSize = true;
            this.lblOCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCustomerName.Location = new System.Drawing.Point(42, 263);
            this.lblOCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOCustomerName.Name = "lblOCustomerName";
            this.lblOCustomerName.Size = new System.Drawing.Size(135, 23);
            this.lblOCustomerName.TabIndex = 43;
            this.lblOCustomerName.Text = "Customer Name";
            // 
            // txtOQuantity
            // 
            this.txtOQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOQuantity.Location = new System.Drawing.Point(205, 216);
            this.txtOQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOQuantity.Name = "txtOQuantity";
            this.txtOQuantity.Size = new System.Drawing.Size(240, 27);
            this.txtOQuantity.TabIndex = 42;
            // 
            // lblOQuantity
            // 
            this.lblOQuantity.AutoSize = true;
            this.lblOQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOQuantity.Location = new System.Drawing.Point(100, 220);
            this.lblOQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOQuantity.Name = "lblOQuantity";
            this.lblOQuantity.Size = new System.Drawing.Size(77, 23);
            this.lblOQuantity.TabIndex = 41;
            this.lblOQuantity.Text = "Quantity";
            // 
            // txtOProductName
            // 
            this.txtOProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOProductName.Location = new System.Drawing.Point(205, 169);
            this.txtOProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOProductName.Name = "txtOProductName";
            this.txtOProductName.Size = new System.Drawing.Size(240, 27);
            this.txtOProductName.TabIndex = 40;
            // 
            // lblOProductName
            // 
            this.lblOProductName.AutoSize = true;
            this.lblOProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOProductName.Location = new System.Drawing.Point(56, 173);
            this.lblOProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOProductName.Name = "lblOProductName";
            this.lblOProductName.Size = new System.Drawing.Size(121, 23);
            this.lblOProductName.TabIndex = 39;
            this.lblOProductName.Text = "Product Name";
            // 
            // btnHOSearch
            // 
            this.btnHOSearch.BackColor = System.Drawing.Color.Navy;
            this.btnHOSearch.ForeColor = System.Drawing.Color.White;
            this.btnHOSearch.Location = new System.Drawing.Point(345, 127);
            this.btnHOSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHOSearch.Name = "btnHOSearch";
            this.btnHOSearch.Size = new System.Drawing.Size(100, 33);
            this.btnHOSearch.TabIndex = 51;
            this.btnHOSearch.Text = "Search";
            this.btnHOSearch.UseVisualStyleBackColor = false;
            this.btnHOSearch.Click += new System.EventHandler(this.btnHOSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 60);
            this.label1.TabIndex = 52;
            this.label1.Text = "Order Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOSearch);
            this.Controls.Add(this.txtODeliveryLocation);
            this.Controls.Add(this.lblODeliveryLocation);
            this.Controls.Add(this.txtODeliveryOn);
            this.Controls.Add(this.lblODeliveryOn);
            this.Controls.Add(this.txtODateOfOrder);
            this.Controls.Add(this.lblODateOfOrder);
            this.Controls.Add(this.txtOCustomerName);
            this.Controls.Add(this.lblOCustomerName);
            this.Controls.Add(this.txtOQuantity);
            this.Controls.Add(this.lblOQuantity);
            this.Controls.Add(this.txtOProductName);
            this.Controls.Add(this.lblOProductName);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnOUpdate);
            this.Controls.Add(this.txtOrderStatus);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.txtOId);
            this.Controls.Add(this.lblOId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.TextBox txtOId;
        private System.Windows.Forms.Label lblOId;
        private System.Windows.Forms.Button btnOUpdate;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtODeliveryLocation;
        private System.Windows.Forms.Label lblODeliveryLocation;
        private System.Windows.Forms.TextBox txtODeliveryOn;
        private System.Windows.Forms.Label lblODeliveryOn;
        private System.Windows.Forms.TextBox txtODateOfOrder;
        private System.Windows.Forms.Label lblODateOfOrder;
        private System.Windows.Forms.TextBox txtOCustomerName;
        private System.Windows.Forms.Label lblOCustomerName;
        private System.Windows.Forms.TextBox txtOQuantity;
        private System.Windows.Forms.Label lblOQuantity;
        private System.Windows.Forms.TextBox txtOProductName;
        private System.Windows.Forms.Label lblOProductName;
        private System.Windows.Forms.Button btnHOSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}