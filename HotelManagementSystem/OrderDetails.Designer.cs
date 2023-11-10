
namespace HotelManagementSystem
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.btnPreviousOrder = new System.Windows.Forms.Button();
            this.btnShowOD = new System.Windows.Forms.Button();
            this.btnLogoutOD = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderIItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrderDetail.BackgroundImage")));
            this.pnlOrderDetail.Controls.Add(this.btnPreviousOrder);
            this.pnlOrderDetail.Controls.Add(this.btnShowOD);
            this.pnlOrderDetail.Controls.Add(this.btnLogoutOD);
            this.pnlOrderDetail.Controls.Add(this.dgvOrderDetails);
            this.pnlOrderDetail.Location = new System.Drawing.Point(0, -2);
            this.pnlOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(745, 502);
            this.pnlOrderDetail.TabIndex = 1;
            // 
            // btnPreviousOrder
            // 
            this.btnPreviousOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPreviousOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreviousOrder.Location = new System.Drawing.Point(234, 372);
            this.btnPreviousOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreviousOrder.Name = "btnPreviousOrder";
            this.btnPreviousOrder.Size = new System.Drawing.Size(65, 34);
            this.btnPreviousOrder.TabIndex = 5;
            this.btnPreviousOrder.Text = "Previous";
            this.btnPreviousOrder.UseVisualStyleBackColor = false;
            this.btnPreviousOrder.Click += new System.EventHandler(this.btnPreviousOrder_Click);
            // 
            // btnShowOD
            // 
            this.btnShowOD.BackColor = System.Drawing.Color.DarkRed;
            this.btnShowOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOD.ForeColor = System.Drawing.Color.White;
            this.btnShowOD.Location = new System.Drawing.Point(290, 316);
            this.btnShowOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowOD.Name = "btnShowOD";
            this.btnShowOD.Size = new System.Drawing.Size(75, 37);
            this.btnShowOD.TabIndex = 4;
            this.btnShowOD.Text = "ShowList";
            this.btnShowOD.UseVisualStyleBackColor = false;
            this.btnShowOD.Click += new System.EventHandler(this.btnShowOD_Click);
            // 
            // btnLogoutOD
            // 
            this.btnLogoutOD.BackColor = System.Drawing.Color.Maroon;
            this.btnLogoutOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutOD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogoutOD.Location = new System.Drawing.Point(177, 316);
            this.btnLogoutOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogoutOD.Name = "btnLogoutOD";
            this.btnLogoutOD.Size = new System.Drawing.Size(62, 37);
            this.btnLogoutOD.TabIndex = 3;
            this.btnLogoutOD.Text = "Logout";
            this.btnLogoutOD.UseVisualStyleBackColor = false;
            this.btnLogoutOD.Click += new System.EventHandler(this.btnLogoutOD_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderIItemName});
            this.dgvOrderDetails.GridColor = System.Drawing.Color.Bisque;
            this.dgvOrderDetails.Location = new System.Drawing.Point(413, 112);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(302, 308);
            this.dgvOrderDetails.TabIndex = 2;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 125;
            // 
            // OrderIItemName
            // 
            this.OrderIItemName.DataPropertyName = "OrderItemName";
            this.OrderIItemName.HeaderText = "Order Item Name";
            this.OrderIItemName.MinimumWidth = 6;
            this.OrderIItemName.Name = "OrderIItemName";
            this.OrderIItemName.ReadOnly = true;
            this.OrderIItemName.Width = 125;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 498);
            this.Controls.Add(this.pnlOrderDetail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderDetails_FormClosing);
            this.pnlOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnShowOD;
        private System.Windows.Forms.Button btnLogoutOD;
        private System.Windows.Forms.Button btnPreviousOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIItemName;
    }
}