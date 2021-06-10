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
            this.bsbTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.accountNumberTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lastNameTB = new MetroFramework.Controls.MetroTextBox();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
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
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.addItemsPage = new MetroFramework.Controls.MetroTabPage();
            this.invoiceSuccessLabel = new System.Windows.Forms.Label();
            this.saveIncompleteBtn = new MetroFramework.Controls.MetroButton();
            this.loadIncompleteBtn = new MetroFramework.Controls.MetroButton();
            this.removeItemBtn = new MetroFramework.Controls.MetroButton();
            this.createInvoiceBtn = new MetroFramework.Controls.MetroButton();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.itemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addItemBtn = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.basicDetailsPage.SuspendLayout();
            this.addItemsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.basicDetailsPage);
            this.tabControl.Controls.Add(this.addItemsPage);
            this.tabControl.Location = new System.Drawing.Point(24, 64);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1202, 839);
            this.tabControl.TabIndex = 0;
            // 
            // basicDetailsPage
            // 
            this.basicDetailsPage.Controls.Add(this.bsbTB);
            this.basicDetailsPage.Controls.Add(this.metroLabel11);
            this.basicDetailsPage.Controls.Add(this.accountNumberTB);
            this.basicDetailsPage.Controls.Add(this.metroLabel10);
            this.basicDetailsPage.Controls.Add(this.lastNameTB);
            this.basicDetailsPage.Controls.Add(this.lastNameLabel);
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
            this.basicDetailsPage.Controls.Add(this.firstNameLabel);
            this.basicDetailsPage.HorizontalScrollbarBarColor = true;
            this.basicDetailsPage.Location = new System.Drawing.Point(4, 35);
            this.basicDetailsPage.Name = "basicDetailsPage";
            this.basicDetailsPage.Size = new System.Drawing.Size(1194, 800);
            this.basicDetailsPage.TabIndex = 0;
            this.basicDetailsPage.Text = "01 Basic Details";
            this.basicDetailsPage.VerticalScrollbarBarColor = true;
            // 
            // bsbTB
            // 
            this.bsbTB.Location = new System.Drawing.Point(177, 318);
            this.bsbTB.Name = "bsbTB";
            this.bsbTB.Size = new System.Drawing.Size(128, 23);
            this.bsbTB.TabIndex = 21;
            this.bsbTB.Text = "Autofill from Persona";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(20, 318);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(32, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "BSB";
            // 
            // accountNumberTB
            // 
            this.accountNumberTB.Location = new System.Drawing.Point(177, 290);
            this.accountNumberTB.Name = "accountNumberTB";
            this.accountNumberTB.Size = new System.Drawing.Size(128, 23);
            this.accountNumberTB.TabIndex = 19;
            this.accountNumberTB.Text = "Autofill from Persona";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(20, 290);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(109, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Account Number";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(177, 117);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(128, 23);
            this.lastNameTB.TabIndex = 17;
            this.lastNameTB.Text = "Autofill from Persona";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(20, 117);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(71, 19);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(22, 42);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(187, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "You may update it if necessary";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(20, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(373, 25);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "This data has been pre-filled from your persona";
            // 
            // postalAddr2TB
            // 
            this.postalAddr2TB.Location = new System.Drawing.Point(177, 262);
            this.postalAddr2TB.Name = "postalAddr2TB";
            this.postalAddr2TB.Size = new System.Drawing.Size(128, 23);
            this.postalAddr2TB.TabIndex = 13;
            this.postalAddr2TB.Text = "Autofill from Persona";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 262);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(132, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Postal Address Line 2";
            // 
            // postalAddr1TB
            // 
            this.postalAddr1TB.Location = new System.Drawing.Point(177, 233);
            this.postalAddr1TB.Name = "postalAddr1TB";
            this.postalAddr1TB.Size = new System.Drawing.Size(128, 23);
            this.postalAddr1TB.TabIndex = 11;
            this.postalAddr1TB.Text = "Autofill from Persona";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 233);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Postal Address Line 1";
            // 
            // addr2TB
            // 
            this.addr2TB.Location = new System.Drawing.Point(177, 204);
            this.addr2TB.Name = "addr2TB";
            this.addr2TB.Size = new System.Drawing.Size(128, 23);
            this.addr2TB.TabIndex = 9;
            this.addr2TB.Text = "Autofill from Persona";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 204);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Address Line 2";
            // 
            // addr1TB
            // 
            this.addr1TB.Location = new System.Drawing.Point(177, 175);
            this.addr1TB.Name = "addr1TB";
            this.addr1TB.Size = new System.Drawing.Size(128, 23);
            this.addr1TB.TabIndex = 7;
            this.addr1TB.Text = "Autofill from Persona";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Address Line 1";
            // 
            // abnTB
            // 
            this.abnTB.Location = new System.Drawing.Point(177, 146);
            this.abnTB.Name = "abnTB";
            this.abnTB.Size = new System.Drawing.Size(128, 23);
            this.abnTB.TabIndex = 5;
            this.abnTB.Text = "Autofill from Persona";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "ABN";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(177, 88);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(128, 23);
            this.firstNameTB.TabIndex = 3;
            this.firstNameTB.Text = "Autofill from Persona";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 88);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(73, 19);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // addItemsPage
            // 
            this.addItemsPage.Controls.Add(this.invoiceSuccessLabel);
            this.addItemsPage.Controls.Add(this.saveIncompleteBtn);
            this.addItemsPage.Controls.Add(this.loadIncompleteBtn);
            this.addItemsPage.Controls.Add(this.removeItemBtn);
            this.addItemsPage.Controls.Add(this.createInvoiceBtn);
            this.addItemsPage.Controls.Add(this.itemsListView);
            this.addItemsPage.Controls.Add(this.addItemBtn);
            this.addItemsPage.HorizontalScrollbarBarColor = true;
            this.addItemsPage.Location = new System.Drawing.Point(4, 35);
            this.addItemsPage.Name = "addItemsPage";
            this.addItemsPage.Size = new System.Drawing.Size(1194, 800);
            this.addItemsPage.TabIndex = 1;
            this.addItemsPage.Text = "02 Create / Edit Invoice";
            this.addItemsPage.VerticalScrollbarBarColor = true;
            // 
            // invoiceSuccessLabel
            // 
            this.invoiceSuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceSuccessLabel.AutoSize = true;
            this.invoiceSuccessLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.invoiceSuccessLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceSuccessLabel.Location = new System.Drawing.Point(3, 745);
            this.invoiceSuccessLabel.Name = "invoiceSuccessLabel";
            this.invoiceSuccessLabel.Size = new System.Drawing.Size(80, 17);
            this.invoiceSuccessLabel.TabIndex = 10;
            this.invoiceSuccessLabel.Text = "Status Label";
            // 
            // saveIncompleteBtn
            // 
            this.saveIncompleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveIncompleteBtn.Location = new System.Drawing.Point(148, 764);
            this.saveIncompleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveIncompleteBtn.Name = "saveIncompleteBtn";
            this.saveIncompleteBtn.Size = new System.Drawing.Size(140, 33);
            this.saveIncompleteBtn.TabIndex = 9;
            this.saveIncompleteBtn.Text = "Save Invoice";
            this.saveIncompleteBtn.Click += new System.EventHandler(this.SaveIncompleteInvoiceBtn_Click);
            // 
            // loadIncompleteBtn
            // 
            this.loadIncompleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadIncompleteBtn.Location = new System.Drawing.Point(4, 764);
            this.loadIncompleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadIncompleteBtn.Name = "loadIncompleteBtn";
            this.loadIncompleteBtn.Size = new System.Drawing.Size(140, 33);
            this.loadIncompleteBtn.TabIndex = 8;
            this.loadIncompleteBtn.Text = "Load Invoice";
            this.loadIncompleteBtn.Click += new System.EventHandler(this.LoadIncompleteInvoiceBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemBtn.Location = new System.Drawing.Point(729, 764);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(156, 33);
            this.removeItemBtn.TabIndex = 4;
            this.removeItemBtn.Text = "Remove Selected Item";
            this.removeItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // createInvoiceBtn
            // 
            this.createInvoiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createInvoiceBtn.Location = new System.Drawing.Point(1051, 764);
            this.createInvoiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createInvoiceBtn.Name = "createInvoiceBtn";
            this.createInvoiceBtn.Size = new System.Drawing.Size(140, 33);
            this.createInvoiceBtn.TabIndex = 6;
            this.createInvoiceBtn.Text = "Generate Invoice";
            this.createInvoiceBtn.Click += new System.EventHandler(this.CreateInvoiceBtn_Click);
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
            this.itemsListView.Location = new System.Drawing.Point(4, 3);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(1187, 758);
            this.itemsListView.TabIndex = 5;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            this.itemsListView.DoubleClick += new System.EventHandler(this.ItemsListView_DoubleClick);
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
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Location = new System.Drawing.Point(890, 764);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(156, 33);
            this.addItemBtn.TabIndex = 3;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // InvoiceCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 926);
            this.Controls.Add(this.tabControl);
            this.Name = "InvoiceCreator";
            this.Text = "Invoice Creator";
            this.tabControl.ResumeLayout(false);
            this.basicDetailsPage.ResumeLayout(false);
            this.basicDetailsPage.PerformLayout();
            this.addItemsPage.ResumeLayout(false);
            this.addItemsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage basicDetailsPage;
        private MetroFramework.Controls.MetroTabPage addItemsPage;
        private MetroFramework.Controls.MetroTextBox abnTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox firstNameTB;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
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
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroTextBox bsbTB;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox accountNumberTB;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton createInvoiceBtn;
        private MetroFramework.Controls.MetroButton saveIncompleteBtn;
        private MetroFramework.Controls.MetroButton loadIncompleteBtn;
        private System.Windows.Forms.Label invoiceSuccessLabel;
    }
}