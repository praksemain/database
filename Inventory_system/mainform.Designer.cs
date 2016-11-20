namespace Inventory_system
{
    partial class mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDiscountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSubgroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monetaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesProposalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.procurementDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProcurementDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfProcurementDocumentsSarakstsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizationDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programDataToolStripMenuItem,
            this.ProductsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programDataToolStripMenuItem
            // 
            this.programDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDataToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.customersToolStripMenuItem,
            this.individualDiscountsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.productGroupsToolStripMenuItem,
            this.productSubgroupsToolStripMenuItem,
            this.monetaryToolStripMenuItem});
            this.programDataToolStripMenuItem.Name = "programDataToolStripMenuItem";
            this.programDataToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.programDataToolStripMenuItem.Text = "Programmas dati";
            // 
            // companyDataToolStripMenuItem
            // 
            this.companyDataToolStripMenuItem.Name = "companyDataToolStripMenuItem";
            this.companyDataToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.companyDataToolStripMenuItem.Text = "Uzņēmuma dati";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.employeesToolStripMenuItem.Text = "Darbinieki";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.darbiniekiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 6);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.customersToolStripMenuItem.Text = "Pircēji";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // individualDiscountsToolStripMenuItem
            // 
            this.individualDiscountsToolStripMenuItem.Name = "individualDiscountsToolStripMenuItem";
            this.individualDiscountsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.individualDiscountsToolStripMenuItem.Text = "Individuālās atlaides";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.suppliersToolStripMenuItem.Text = "Piegādātāji";
            // 
            // productGroupsToolStripMenuItem
            // 
            this.productGroupsToolStripMenuItem.Name = "productGroupsToolStripMenuItem";
            this.productGroupsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.productGroupsToolStripMenuItem.Text = "Preču grupas";
            // 
            // productSubgroupsToolStripMenuItem
            // 
            this.productSubgroupsToolStripMenuItem.Name = "productSubgroupsToolStripMenuItem";
            this.productSubgroupsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.productSubgroupsToolStripMenuItem.Text = "Preču apakšgrupas";
            // 
            // monetaryToolStripMenuItem
            // 
            this.monetaryToolStripMenuItem.Name = "monetaryToolStripMenuItem";
            this.monetaryToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.monetaryToolStripMenuItem.Text = "Valūtas";
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.requestsToolStripMenuItem,
            this.salesProposalsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.procurementDocumentsToolStripMenuItem,
            this.bookingDocumentsToolStripMenuItem,
            this.realizationDocumentsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.searchReservationToolStripMenuItem});
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ProductsToolStripMenuItem.Text = "Preces";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.ordersToolStripMenuItem.Text = "Pasūtījumi";
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.requestsToolStripMenuItem.Text = "Pieprasījumi";
            // 
            // salesProposalsToolStripMenuItem
            // 
            this.salesProposalsToolStripMenuItem.Name = "salesProposalsToolStripMenuItem";
            this.salesProposalsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.salesProposalsToolStripMenuItem.Text = "Komercpiedāvājumi";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(316, 6);
            // 
            // procurementDocumentsToolStripMenuItem
            // 
            this.procurementDocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProcurementDocumentToolStripMenuItem,
            this.listOfProcurementDocumentsSarakstsToolStripMenuItem});
            this.procurementDocumentsToolStripMenuItem.Name = "procurementDocumentsToolStripMenuItem";
            this.procurementDocumentsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.procurementDocumentsToolStripMenuItem.Text = "Iepirkumu dokumenti";
            // 
            // newProcurementDocumentToolStripMenuItem
            // 
            this.newProcurementDocumentToolStripMenuItem.Name = "newProcurementDocumentToolStripMenuItem";
            this.newProcurementDocumentToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.newProcurementDocumentToolStripMenuItem.Text = "Iepirkuma dokumenta ievadīšana";
            // 
            // listOfProcurementDocumentsSarakstsToolStripMenuItem
            // 
            this.listOfProcurementDocumentsSarakstsToolStripMenuItem.Name = "listOfProcurementDocumentsSarakstsToolStripMenuItem";
            this.listOfProcurementDocumentsSarakstsToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.listOfProcurementDocumentsSarakstsToolStripMenuItem.Text = "Iepirkuma dokumentu saraksts";
            // 
            // bookingDocumentsToolStripMenuItem
            // 
            this.bookingDocumentsToolStripMenuItem.Name = "bookingDocumentsToolStripMenuItem";
            this.bookingDocumentsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.bookingDocumentsToolStripMenuItem.Text = "Rezervācijas dokumenti";
            // 
            // realizationDocumentsToolStripMenuItem
            // 
            this.realizationDocumentsToolStripMenuItem.Name = "realizationDocumentsToolStripMenuItem";
            this.realizationDocumentsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.realizationDocumentsToolStripMenuItem.Text = "Realizācijas dokumenti";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(316, 6);
            // 
            // searchReservationToolStripMenuItem
            // 
            this.searchReservationToolStripMenuItem.Name = "searchReservationToolStripMenuItem";
            this.searchReservationToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.searchReservationToolStripMenuItem.Text = "Atlikumi / Meklēšana / Rezervēšana";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1348, 723);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "Mainark 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualDiscountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSubgroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monetaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesProposalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem procurementDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProcurementDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfProcurementDocumentsSarakstsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizationDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem searchReservationToolStripMenuItem;
    }
}

