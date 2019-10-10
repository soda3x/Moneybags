namespace Moneybags
{
    partial class InvoiceCreator
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.basicDetailsPage = new MetroFramework.Controls.MetroTabPage();
            this.lastNameTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.postalAddr2TB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.postalAddr1TB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.addr2TB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.addr1TB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.abnTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.firstNameTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addItemsPage = new MetroFramework.Controls.MetroTabPage();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.itemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeItemBtn = new MetroFramework.Controls.MetroButton();
            this.addItemBtn = new MetroFramework.Controls.MetroButton();
            this.createPage = new MetroFramework.Controls.MetroTabPage();
            this.invoiceSuccessLabel = new MetroFramework.Controls.MetroLabel();
            this.createInvoiceBtn = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.basicDetailsPage.SuspendLayout();
            this.addItemsPage.SuspendLayout();
            this.createPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.basicDetailsPage);
            this.tabControl.Controls.Add(this.addItemsPage);
            this.tabControl.Controls.Add(this.createPage);
            this.tabControl.Location = new System.Drawing.Point(32, 79);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(1108, 718);
            this.tabControl.TabIndex = 0;
            // 
            // basicDetailsPage
            // 
            this.basicDetailsPage.Controls.Add(this.lastNameTB);
            this.basicDetailsPage.Controls.Add(this.metroLabel9);
            this.basicDetailsPage.Controls.Add(this.metroLabel8);
            this.basicDetailsPage.Controls.Add(this.metroLabel7);
            this.basicDetailsPage.Controls.Add(this.postalAddr2TB);
            this.basicDetailsPage.Controls.Add(this.metroLabel6);
            this.basicDetailsPage.Controls.Add(this.postalAddr1TB);
            this.basicDetailsPage.Controls.Add(this.metroLabel5);
            this.basicDetailsPage.Controls.Add(this.addr2TB);
            this.basicDetailsPage.Controls.Add(this.metroLabel4);
            this.basicDetailsPage.Controls.Add(this.addr1TB);
            this.basicDetailsPage.Controls.Add(this.metroLabel3);
            this.basicDetailsPage.Controls.Add(this.abnTB);
            this.basicDetailsPage.Controls.Add(this.metroLabel2);
            this.basicDetailsPage.Controls.Add(this.firstNameTB);
            this.basicDetailsPage.Controls.Add(this.metroLabel1);
            this.basicDetailsPage.HorizontalScrollbarBarColor = true;
            this.basicDetailsPage.HorizontalScrollbarSize = 12;
            this.basicDetailsPage.Location = new System.Drawing.Point(4, 38);
            this.basicDetailsPage.Margin = new System.Windows.Forms.Padding(4);
            this.basicDetailsPage.Name = "basicDetailsPage";
            this.basicDetailsPage.Size = new System.Drawing.Size(1100, 676);
            this.basicDetailsPage.TabIndex = 0;
            this.basicDetailsPage.Text = "01 Basic Details";
            this.basicDetailsPage.VerticalScrollbarBarColor = true;
            this.basicDetailsPage.VerticalScrollbarSize = 13;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(236, 144);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(171, 28);
            this.lastNameTB.TabIndex = 17;
            this.lastNameTB.Text = "Autofill from Persona";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(27, 144);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 20);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Last Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 52);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(198, 20);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "You may update it if necessary";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(27, 21);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(391, 25);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "This data has been pre-filled from your persona";
            // 
            // postalAddr2TB
            // 
            this.postalAddr2TB.Location = new System.Drawing.Point(236, 322);
            this.postalAddr2TB.Margin = new System.Windows.Forms.Padding(4);
            this.postalAddr2TB.Name = "postalAddr2TB";
            this.postalAddr2TB.Size = new System.Drawing.Size(171, 28);
            this.postalAddr2TB.TabIndex = 13;
            this.postalAddr2TB.Text = "Autofill from Persona";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(27, 322);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(140, 20);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Postal Address Line 2";
            // 
            // postalAddr1TB
            // 
            this.postalAddr1TB.Location = new System.Drawing.Point(236, 287);
            this.postalAddr1TB.Margin = new System.Windows.Forms.Padding(4);
            this.postalAddr1TB.Name = "postalAddr1TB";
            this.postalAddr1TB.Size = new System.Drawing.Size(171, 28);
            this.postalAddr1TB.TabIndex = 11;
            this.postalAddr1TB.Text = "Autofill from Persona";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 287);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(137, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Postal Address Line 1";
            // 
            // addr2TB
            // 
            this.addr2TB.Location = new System.Drawing.Point(236, 251);
            this.addr2TB.Margin = new System.Windows.Forms.Padding(4);
            this.addr2TB.Name = "addr2TB";
            this.addr2TB.Size = new System.Drawing.Size(171, 28);
            this.addr2TB.TabIndex = 9;
            this.addr2TB.Text = "Autofill from Persona";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 251);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Address Line 2";
            // 
            // addr1TB
            // 
            this.addr1TB.Location = new System.Drawing.Point(236, 215);
            this.addr1TB.Margin = new System.Windows.Forms.Padding(4);
            this.addr1TB.Name = "addr1TB";
            this.addr1TB.Size = new System.Drawing.Size(171, 28);
            this.addr1TB.TabIndex = 7;
            this.addr1TB.Text = "Autofill from Persona";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 215);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Address Line 1";
            // 
            // abnTB
            // 
            this.abnTB.Location = new System.Drawing.Point(236, 180);
            this.abnTB.Margin = new System.Windows.Forms.Padding(4);
            this.abnTB.Name = "abnTB";
            this.abnTB.Size = new System.Drawing.Size(171, 28);
            this.abnTB.TabIndex = 5;
            this.abnTB.Text = "Autofill from Persona";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 180);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "ABN";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(236, 108);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(171, 28);
            this.firstNameTB.TabIndex = 3;
            this.firstNameTB.Text = "Autofill from Persona";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 108);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "First Name";
            // 
            // addItemsPage
            // 
            this.addItemsPage.Controls.Add(this.itemsListView);
            this.addItemsPage.Controls.Add(this.removeItemBtn);
            this.addItemsPage.Controls.Add(this.addItemBtn);
            this.addItemsPage.HorizontalScrollbarBarColor = true;
            this.addItemsPage.HorizontalScrollbarSize = 12;
            this.addItemsPage.Location = new System.Drawing.Point(4, 38);
            this.addItemsPage.Margin = new System.Windows.Forms.Padding(4);
            this.addItemsPage.Name = "addItemsPage";
            this.addItemsPage.Size = new System.Drawing.Size(1100, 676);
            this.addItemsPage.TabIndex = 1;
            this.addItemsPage.Text = "02 Add Items";
            this.addItemsPage.VerticalScrollbarBarColor = true;
            this.addItemsPage.VerticalScrollbarSize = 13;
            // 
            // itemsListView
            // 
            this.itemsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemCode,
            this.description,
            this.unitPrice,
            this.quantity,
            this.gst,
            this.total});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(5, 5);
            this.itemsListView.Margin = new System.Windows.Forms.Padding(4);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(1091, 631);
            this.itemsListView.TabIndex = 5;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // itemCode
            // 
            this.itemCode.Text = "Item Code";
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 500;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "Unit Price";
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // gst
            // 
            this.gst.Text = "GST";
            // 
            // total
            // 
            this.total.Text = "Total";
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemBtn.Location = new System.Drawing.Point(1058, 640);
            this.removeItemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(39, 28);
            this.removeItemBtn.TabIndex = 4;
            this.removeItemBtn.Text = "-";
            this.removeItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Location = new System.Drawing.Point(922, 640);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(128, 28);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "+";
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // createPage
            // 
            this.createPage.Controls.Add(this.panel1);
            this.createPage.HorizontalScrollbarBarColor = true;
            this.createPage.HorizontalScrollbarSize = 12;
            this.createPage.Location = new System.Drawing.Point(4, 38);
            this.createPage.Margin = new System.Windows.Forms.Padding(4);
            this.createPage.Name = "createPage";
            this.createPage.Size = new System.Drawing.Size(1100, 676);
            this.createPage.TabIndex = 2;
            this.createPage.Text = "03 Create";
            this.createPage.VerticalScrollbarBarColor = true;
            this.createPage.VerticalScrollbarSize = 13;
            // 
            // invoiceSuccessLabel
            // 
            this.invoiceSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceSuccessLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.invoiceSuccessLabel.Location = new System.Drawing.Point(2, 142);
            this.invoiceSuccessLabel.Name = "invoiceSuccessLabel";
            this.invoiceSuccessLabel.Size = new System.Drawing.Size(377, 82);
            this.invoiceSuccessLabel.TabIndex = 3;
            this.invoiceSuccessLabel.Text = "Invoice was successfully created.";
            this.invoiceSuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createInvoiceBtn
            // 
            this.createInvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createInvoiceBtn.Location = new System.Drawing.Point(51, 72);
            this.createInvoiceBtn.MinimumSize = new System.Drawing.Size(187, 67);
            this.createInvoiceBtn.Name = "createInvoiceBtn";
            this.createInvoiceBtn.Size = new System.Drawing.Size(283, 67);
            this.createInvoiceBtn.TabIndex = 2;
            this.createInvoiceBtn.Text = "Create Invoice";
            this.createInvoiceBtn.Click += new System.EventHandler(this.CreateInvoiceBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.createInvoiceBtn);
            this.panel1.Controls.Add(this.invoiceSuccessLabel);
            this.panel1.Location = new System.Drawing.Point(356, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 224);
            this.panel1.TabIndex = 4;
            // 
            // InvoiceCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 825);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceCreator";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Invoice Creator";
            this.tabControl.ResumeLayout(false);
            this.basicDetailsPage.ResumeLayout(false);
            this.basicDetailsPage.PerformLayout();
            this.addItemsPage.ResumeLayout(false);
            this.createPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage basicDetailsPage;
        private MetroFramework.Controls.MetroTabPage addItemsPage;
        private MetroFramework.Controls.MetroTabPage createPage;
        private MetroFramework.Controls.MetroTextBox abnTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox firstNameTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox addr2TB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox addr1TB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox postalAddr2TB;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox postalAddr1TB;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton removeItemBtn;
        private MetroFramework.Controls.MetroButton addItemBtn;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ColumnHeader itemCode;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader gst;
        private System.Windows.Forms.ColumnHeader total;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox lastNameTB;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton createInvoiceBtn;
        private MetroFramework.Controls.MetroLabel invoiceSuccessLabel;
        private System.Windows.Forms.Panel panel1;
    }
}