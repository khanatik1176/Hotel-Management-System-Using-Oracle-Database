
namespace HotelManagementSystem
{
    partial class Member
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
            this.pnlMember = new System.Windows.Forms.Panel();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemberListCheck = new System.Windows.Forms.Button();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.btnMemberPrevious = new System.Windows.Forms.Button();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.lblmemberworkhour = new System.Windows.Forms.Label();
            this.lblmemberbonus = new System.Windows.Forms.Label();
            this.lblmemberaddress = new System.Windows.Forms.Label();
            this.lblmembersalary = new System.Windows.Forms.Label();
            this.lblmembername = new System.Windows.Forms.Label();
            this.lblmemberid = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberSalary = new System.Windows.Forms.TextBox();
            this.txtMemberBonus = new System.Windows.Forms.TextBox();
            this.txtMemberWorkHour = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberWorkHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMember
            // 
            this.pnlMember.Controls.Add(this.btnDisable);
            this.pnlMember.Controls.Add(this.btnEnable);
            this.pnlMember.Controls.Add(this.button1);
            this.pnlMember.Controls.Add(this.lblMemberSearch);
            this.pnlMember.Controls.Add(this.btnClear);
            this.pnlMember.Controls.Add(this.btnMemberListCheck);
            this.pnlMember.Controls.Add(this.txtMemberSearch);
            this.pnlMember.Controls.Add(this.btnMemberPrevious);
            this.pnlMember.Controls.Add(this.btnMemberDelete);
            this.pnlMember.Controls.Add(this.btnMemberUpdate);
            this.pnlMember.Controls.Add(this.btnMemberAdd);
            this.pnlMember.Controls.Add(this.lblmemberworkhour);
            this.pnlMember.Controls.Add(this.lblmemberbonus);
            this.pnlMember.Controls.Add(this.lblmemberaddress);
            this.pnlMember.Controls.Add(this.lblmembersalary);
            this.pnlMember.Controls.Add(this.lblmembername);
            this.pnlMember.Controls.Add(this.lblmemberid);
            this.pnlMember.Controls.Add(this.txtMemberID);
            this.pnlMember.Controls.Add(this.txtMemberName);
            this.pnlMember.Controls.Add(this.txtMemberSalary);
            this.pnlMember.Controls.Add(this.txtMemberBonus);
            this.pnlMember.Controls.Add(this.txtMemberWorkHour);
            this.pnlMember.Controls.Add(this.dgvMembers);
            this.pnlMember.Controls.Add(this.txtMemberAddress);
            this.pnlMember.Controls.Add(this.panel1);
            this.pnlMember.Location = new System.Drawing.Point(0, -2);
            this.pnlMember.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(1049, 498);
            this.pnlMember.TabIndex = 0;
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.DimGray;
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(475, 124);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(92, 32);
            this.btnDisable.TabIndex = 51;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.DimGray;
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(379, 124);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(92, 32);
            this.btnEnable.TabIndex = 50;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(966, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Location = new System.Drawing.Point(716, 91);
            this.lblMemberSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(127, 13);
            this.lblMemberSearch.TabIndex = 48;
            this.lblMemberSearch.Text = "Search by Member Name";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(888, 124);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 32);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnMemberListCheck
            // 
            this.btnMemberListCheck.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMemberListCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberListCheck.ForeColor = System.Drawing.Color.White;
            this.btnMemberListCheck.Location = new System.Drawing.Point(123, 455);
            this.btnMemberListCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberListCheck.Name = "btnMemberListCheck";
            this.btnMemberListCheck.Size = new System.Drawing.Size(94, 35);
            this.btnMemberListCheck.TabIndex = 46;
            this.btnMemberListCheck.Text = "List Check";
            this.btnMemberListCheck.UseVisualStyleBackColor = false;
            this.btnMemberListCheck.Click += new System.EventHandler(this.btnMemberListCheck_Click);
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(847, 88);
            this.txtMemberSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(200, 20);
            this.txtMemberSearch.TabIndex = 45;
            this.txtMemberSearch.TextChanged += new System.EventHandler(this.txtMemberSearch_TextChanged_1);
            // 
            // btnMemberPrevious
            // 
            this.btnMemberPrevious.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMemberPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberPrevious.ForeColor = System.Drawing.Color.White;
            this.btnMemberPrevious.Location = new System.Drawing.Point(22, 455);
            this.btnMemberPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberPrevious.Name = "btnMemberPrevious";
            this.btnMemberPrevious.Size = new System.Drawing.Size(82, 32);
            this.btnMemberPrevious.TabIndex = 44;
            this.btnMemberPrevious.Text = "Previous";
            this.btnMemberPrevious.UseVisualStyleBackColor = false;
            this.btnMemberPrevious.Click += new System.EventHandler(this.btnMemberPrevious_Click);
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnMemberDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberDelete.ForeColor = System.Drawing.Color.White;
            this.btnMemberDelete.Location = new System.Drawing.Point(692, 124);
            this.btnMemberDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(111, 32);
            this.btnMemberDelete.TabIndex = 43;
            this.btnMemberDelete.Text = "Delete";
            this.btnMemberDelete.UseVisualStyleBackColor = false;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click_1);
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnMemberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberUpdate.ForeColor = System.Drawing.Color.White;
            this.btnMemberUpdate.Location = new System.Drawing.Point(596, 124);
            this.btnMemberUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnMemberUpdate.TabIndex = 42;
            this.btnMemberUpdate.Text = "Update";
            this.btnMemberUpdate.UseVisualStyleBackColor = false;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click_1);
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnMemberAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberAdd.ForeColor = System.Drawing.Color.White;
            this.btnMemberAdd.Location = new System.Drawing.Point(820, 124);
            this.btnMemberAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(64, 32);
            this.btnMemberAdd.TabIndex = 41;
            this.btnMemberAdd.Text = "Add";
            this.btnMemberAdd.UseVisualStyleBackColor = false;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click_1);
            // 
            // lblmemberworkhour
            // 
            this.lblmemberworkhour.AutoSize = true;
            this.lblmemberworkhour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmemberworkhour.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberworkhour.ForeColor = System.Drawing.Color.Purple;
            this.lblmemberworkhour.Location = new System.Drawing.Point(11, 410);
            this.lblmemberworkhour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmemberworkhour.Name = "lblmemberworkhour";
            this.lblmemberworkhour.Size = new System.Drawing.Size(152, 19);
            this.lblmemberworkhour.TabIndex = 40;
            this.lblmemberworkhour.Text = "Member Work-Hour";
            // 
            // lblmemberbonus
            // 
            this.lblmemberbonus.AutoSize = true;
            this.lblmemberbonus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmemberbonus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberbonus.ForeColor = System.Drawing.Color.Purple;
            this.lblmemberbonus.Location = new System.Drawing.Point(11, 358);
            this.lblmemberbonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmemberbonus.Name = "lblmemberbonus";
            this.lblmemberbonus.Size = new System.Drawing.Size(116, 19);
            this.lblmemberbonus.TabIndex = 39;
            this.lblmemberbonus.Text = "Member Bonus";
            // 
            // lblmemberaddress
            // 
            this.lblmemberaddress.AutoSize = true;
            this.lblmemberaddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmemberaddress.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberaddress.ForeColor = System.Drawing.Color.Purple;
            this.lblmemberaddress.Location = new System.Drawing.Point(11, 305);
            this.lblmemberaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmemberaddress.Name = "lblmemberaddress";
            this.lblmemberaddress.Size = new System.Drawing.Size(129, 19);
            this.lblmemberaddress.TabIndex = 38;
            this.lblmemberaddress.Text = "Member Address";
            // 
            // lblmembersalary
            // 
            this.lblmembersalary.AutoSize = true;
            this.lblmembersalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmembersalary.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembersalary.ForeColor = System.Drawing.Color.Purple;
            this.lblmembersalary.Location = new System.Drawing.Point(11, 251);
            this.lblmembersalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmembersalary.Name = "lblmembersalary";
            this.lblmembersalary.Size = new System.Drawing.Size(114, 19);
            this.lblmembersalary.TabIndex = 37;
            this.lblmembersalary.Text = "Member Salary";
            // 
            // lblmembername
            // 
            this.lblmembername.AutoSize = true;
            this.lblmembername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmembername.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmembername.ForeColor = System.Drawing.Color.Purple;
            this.lblmembername.Location = new System.Drawing.Point(11, 198);
            this.lblmembername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmembername.Name = "lblmembername";
            this.lblmembername.Size = new System.Drawing.Size(114, 19);
            this.lblmembername.TabIndex = 36;
            this.lblmembername.Text = "Member Name";
            // 
            // lblmemberid
            // 
            this.lblmemberid.AutoSize = true;
            this.lblmemberid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblmemberid.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberid.ForeColor = System.Drawing.Color.Purple;
            this.lblmemberid.Location = new System.Drawing.Point(11, 151);
            this.lblmemberid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmemberid.Name = "lblmemberid";
            this.lblmemberid.Size = new System.Drawing.Size(88, 19);
            this.lblmemberid.TabIndex = 35;
            this.lblmemberid.Text = "Member ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(11, 172);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(200, 20);
            this.txtMemberID.TabIndex = 34;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(11, 229);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 20);
            this.txtMemberName.TabIndex = 33;
            // 
            // txtMemberSalary
            // 
            this.txtMemberSalary.Location = new System.Drawing.Point(11, 283);
            this.txtMemberSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberSalary.Name = "txtMemberSalary";
            this.txtMemberSalary.Size = new System.Drawing.Size(200, 20);
            this.txtMemberSalary.TabIndex = 32;
            // 
            // txtMemberBonus
            // 
            this.txtMemberBonus.Location = new System.Drawing.Point(11, 388);
            this.txtMemberBonus.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberBonus.Name = "txtMemberBonus";
            this.txtMemberBonus.Size = new System.Drawing.Size(200, 20);
            this.txtMemberBonus.TabIndex = 30;
            // 
            // txtMemberWorkHour
            // 
            this.txtMemberWorkHour.Location = new System.Drawing.Point(11, 431);
            this.txtMemberWorkHour.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberWorkHour.Name = "txtMemberWorkHour";
            this.txtMemberWorkHour.Size = new System.Drawing.Size(200, 20);
            this.txtMemberWorkHour.TabIndex = 29;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.Membername,
            this.MemberSalary,
            this.MemberAddress,
            this.MemberWorkHour,
            this.MemberBonus});
            this.dgvMembers.Location = new System.Drawing.Point(235, 160);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(807, 327);
            this.dgvMembers.TabIndex = 28;
            this.dgvMembers.DoubleClick += new System.EventHandler(this.dgvMembers_DoubleClick_1);
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.MinimumWidth = 6;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 125;
            // 
            // Membername
            // 
            this.Membername.DataPropertyName = "Membername";
            this.Membername.HeaderText = "Member Name";
            this.Membername.MinimumWidth = 6;
            this.Membername.Name = "Membername";
            this.Membername.ReadOnly = true;
            this.Membername.Width = 125;
            // 
            // MemberSalary
            // 
            this.MemberSalary.DataPropertyName = "MemberSalary";
            this.MemberSalary.HeaderText = "Member Salary";
            this.MemberSalary.MinimumWidth = 6;
            this.MemberSalary.Name = "MemberSalary";
            this.MemberSalary.ReadOnly = true;
            this.MemberSalary.Width = 125;
            // 
            // MemberAddress
            // 
            this.MemberAddress.DataPropertyName = "MemberAddress";
            this.MemberAddress.HeaderText = "Member Address";
            this.MemberAddress.MinimumWidth = 6;
            this.MemberAddress.Name = "MemberAddress";
            this.MemberAddress.ReadOnly = true;
            this.MemberAddress.Width = 125;
            // 
            // MemberWorkHour
            // 
            this.MemberWorkHour.DataPropertyName = "MemberWorkHour";
            this.MemberWorkHour.HeaderText = "Member Work-Hour";
            this.MemberWorkHour.MinimumWidth = 6;
            this.MemberWorkHour.Name = "MemberWorkHour";
            this.MemberWorkHour.ReadOnly = true;
            this.MemberWorkHour.Width = 125;
            // 
            // MemberBonus
            // 
            this.MemberBonus.DataPropertyName = "MemberBonus";
            this.MemberBonus.HeaderText = "Member Bonus";
            this.MemberBonus.MinimumWidth = 6;
            this.MemberBonus.Name = "MemberBonus";
            this.MemberBonus.ReadOnly = true;
            this.MemberBonus.Width = 125;
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.Location = new System.Drawing.Point(11, 336);
            this.txtMemberAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(200, 20);
            this.txtMemberAddress.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 81);
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(440, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Member Registration";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 498);
            this.Controls.Add(this.pnlMember);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Member_FormClosing_1);
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Button btnMemberListCheck;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button btnMemberPrevious;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.Label lblmemberworkhour;
        private System.Windows.Forms.Label lblmemberbonus;
        private System.Windows.Forms.Label lblmemberaddress;
        private System.Windows.Forms.Label lblmembersalary;
        private System.Windows.Forms.Label lblmembername;
        private System.Windows.Forms.Label lblmemberid;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberSalary;
        private System.Windows.Forms.TextBox txtMemberBonus;
        private System.Windows.Forms.TextBox txtMemberWorkHour;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membername;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberWorkHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberBonus;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
    }
}