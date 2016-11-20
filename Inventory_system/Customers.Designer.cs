namespace Inventory_system
{
    partial class customers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVNcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legalAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homepageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headMobilePhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.customersTable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 723);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 650);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1348, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Controls.Add(this.printButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1308, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Pievienot";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(84, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Meklēt";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(165, 3);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Drukāt";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(246, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Dzēst";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // customersTable
            // 
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.nameColumn,
            this.registrationNumberColumn,
            this.PVNcodeColumn,
            this.legalAddressColumn,
            this.actualAddressColumn,
            this.emailColumn,
            this.homepageColumn,
            this.SupplierColumn,
            this.headColumn,
            this.headPhoneNumberColumn,
            this.headMobilePhoneNumberColumn,
            this.BankColumn,
            this.bankCodeColumn,
            this.bankAccountNumberColumn,
            this.AddedTimeColumn});
            this.customersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTable.Location = new System.Drawing.Point(3, 3);
            this.customersTable.Name = "customersTable";
            this.customersTable.RowTemplate.Height = 24;
            this.customersTable.Size = new System.Drawing.Size(1342, 644);
            this.customersTable.TabIndex = 1;
            this.customersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Kods uzskaitē";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nosaukums";
            this.nameColumn.Name = "nameColumn";
            // 
            // registrationNumberColumn
            // 
            this.registrationNumberColumn.HeaderText = "Reģistrācijas numurs";
            this.registrationNumberColumn.Name = "registrationNumberColumn";
            // 
            // PVNcodeColumn
            // 
            this.PVNcodeColumn.HeaderText = "PVN kods";
            this.PVNcodeColumn.Name = "PVNcodeColumn";
            // 
            // legalAddressColumn
            // 
            this.legalAddressColumn.HeaderText = "Juridiskā adrese";
            this.legalAddressColumn.Name = "legalAddressColumn";
            // 
            // actualAddressColumn
            // 
            this.actualAddressColumn.HeaderText = "Faktiskā adrese";
            this.actualAddressColumn.Name = "actualAddressColumn";
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-pasts";
            this.emailColumn.Name = "emailColumn";
            // 
            // homepageColumn
            // 
            this.homepageColumn.HeaderText = "Mājas lapa";
            this.homepageColumn.Name = "homepageColumn";
            // 
            // SupplierColumn
            // 
            this.SupplierColumn.HeaderText = "Piegādātājs";
            this.SupplierColumn.Name = "SupplierColumn";
            // 
            // headColumn
            // 
            this.headColumn.HeaderText = "Vadītājs";
            this.headColumn.Name = "headColumn";
            // 
            // headPhoneNumberColumn
            // 
            this.headPhoneNumberColumn.HeaderText = "Tālruņa numurs";
            this.headPhoneNumberColumn.Name = "headPhoneNumberColumn";
            // 
            // headMobilePhoneNumberColumn
            // 
            this.headMobilePhoneNumberColumn.HeaderText = "Mobilā tālruņa numurs";
            this.headMobilePhoneNumberColumn.Name = "headMobilePhoneNumberColumn";
            // 
            // BankColumn
            // 
            this.BankColumn.HeaderText = "Banka";
            this.BankColumn.Name = "BankColumn";
            // 
            // bankCodeColumn
            // 
            this.bankCodeColumn.HeaderText = "Bankas kods";
            this.bankCodeColumn.Name = "bankCodeColumn";
            // 
            // bankAccountNumberColumn
            // 
            this.bankAccountNumberColumn.HeaderText = "Bankas konta numurs";
            this.bankAccountNumberColumn.Name = "bankAccountNumberColumn";
            // 
            // AddedTimeColumn
            // 
            this.AddedTimeColumn.HeaderText = "Pievienošanas datums";
            this.AddedTimeColumn.Name = "AddedTimeColumn";
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "customers";
            this.Text = "Pircēji";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView customersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVNcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legalAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homepageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headPhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headMobilePhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedTimeColumn;
    }
}