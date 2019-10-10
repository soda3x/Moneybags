namespace Moneybags
{
    partial class ItemCreator
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
            this.itemCodeLabel = new MetroFramework.Controls.MetroLabel();
            this.itemCodeTB = new MetroFramework.Controls.MetroTextBox();
            this.descLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTB = new MetroFramework.Controls.MetroTextBox();
            this.unitPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.unitPriceTB = new MetroFramework.Controls.MetroTextBox();
            this.qtyTB = new MetroFramework.Controls.MetroTextBox();
            this.qtyLabel = new MetroFramework.Controls.MetroLabel();
            this.addItemBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Location = new System.Drawing.Point(32, 79);
            this.itemCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(134, 20);
            this.itemCodeLabel.TabIndex = 0;
            this.itemCodeLabel.Text = "Item Code (optional)";
            // 
            // itemCodeTB
            // 
            this.itemCodeTB.Location = new System.Drawing.Point(227, 79);
            this.itemCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.itemCodeTB.Name = "itemCodeTB";
            this.itemCodeTB.Size = new System.Drawing.Size(167, 28);
            this.itemCodeTB.TabIndex = 1;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(441, 79);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(79, 20);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Description";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(548, 78);
            this.descriptionTB.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(332, 178);
            this.descriptionTB.TabIndex = 3;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(32, 124);
            this.unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(69, 20);
            this.unitPriceLabel.TabIndex = 4;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceTB
            // 
            this.unitPriceTB.Location = new System.Drawing.Point(227, 124);
            this.unitPriceTB.Margin = new System.Windows.Forms.Padding(4);
            this.unitPriceTB.Name = "unitPriceTB";
            this.unitPriceTB.Size = new System.Drawing.Size(167, 28);
            this.unitPriceTB.TabIndex = 5;
            // 
            // qtyTB
            // 
            this.qtyTB.Location = new System.Drawing.Point(227, 171);
            this.qtyTB.Margin = new System.Windows.Forms.Padding(4);
            this.qtyTB.Name = "qtyTB";
            this.qtyTB.Size = new System.Drawing.Size(167, 28);
            this.qtyTB.TabIndex = 7;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(32, 171);
            this.qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(61, 20);
            this.qtyLabel.TabIndex = 6;
            this.qtyLabel.Text = "Quantity";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(699, 277);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(181, 23);
            this.addItemBtn.TabIndex = 10;
            this.addItemBtn.Text = "Add Item to Invoice";
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 328);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.qtyTB);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.unitPriceTB);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.itemCodeTB);
            this.Controls.Add(this.itemCodeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemCreator";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel itemCodeLabel;
        private MetroFramework.Controls.MetroTextBox itemCodeTB;
        private MetroFramework.Controls.MetroLabel descLabel;
        private MetroFramework.Controls.MetroTextBox descriptionTB;
        private MetroFramework.Controls.MetroLabel unitPriceLabel;
        private MetroFramework.Controls.MetroTextBox unitPriceTB;
        private MetroFramework.Controls.MetroTextBox qtyTB;
        private MetroFramework.Controls.MetroLabel qtyLabel;
        private MetroFramework.Controls.MetroButton addItemBtn;
    }
}