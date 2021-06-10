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
            this.unitPriceIncludesGSTLabel = new MetroFramework.Controls.MetroLabel();
            this.unitPriceIncludesGSTCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Location = new System.Drawing.Point(24, 64);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(131, 19);
            this.itemCodeLabel.TabIndex = 0;
            this.itemCodeLabel.Text = "Item Code (optional)";
            // 
            // itemCodeTB
            // 
            this.itemCodeTB.Location = new System.Drawing.Point(170, 64);
            this.itemCodeTB.Name = "itemCodeTB";
            this.itemCodeTB.Size = new System.Drawing.Size(156, 23);
            this.itemCodeTB.TabIndex = 1;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(331, 64);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(74, 19);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Description";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(411, 63);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(249, 145);
            this.descriptionTB.TabIndex = 3;
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(24, 101);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(65, 19);
            this.unitPriceLabel.TabIndex = 4;
            this.unitPriceLabel.Text = "Unit Price";
            // 
            // unitPriceTB
            // 
            this.unitPriceTB.Location = new System.Drawing.Point(170, 101);
            this.unitPriceTB.Name = "unitPriceTB";
            this.unitPriceTB.Size = new System.Drawing.Size(156, 23);
            this.unitPriceTB.TabIndex = 5;
            // 
            // qtyTB
            // 
            this.qtyTB.Location = new System.Drawing.Point(170, 160);
            this.qtyTB.Name = "qtyTB";
            this.qtyTB.Size = new System.Drawing.Size(156, 23);
            this.qtyTB.TabIndex = 7;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(24, 160);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(58, 19);
            this.qtyLabel.TabIndex = 6;
            this.qtyLabel.Text = "Quantity";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(524, 225);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(136, 19);
            this.addItemBtn.TabIndex = 10;
            this.addItemBtn.Text = "Add Item to Invoice";
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // unitPriceIncludesGSTLabel
            // 
            this.unitPriceIncludesGSTLabel.AutoSize = true;
            this.unitPriceIncludesGSTLabel.Location = new System.Drawing.Point(184, 132);
            this.unitPriceIncludesGSTLabel.Name = "unitPriceIncludesGSTLabel";
            this.unitPriceIncludesGSTLabel.Size = new System.Drawing.Size(142, 19);
            this.unitPriceIncludesGSTLabel.TabIndex = 11;
            this.unitPriceIncludesGSTLabel.Text = "Unit Price Includes GST";
            // 
            // unitPriceIncludesGSTCheckBox
            // 
            this.unitPriceIncludesGSTCheckBox.AutoSize = true;
            this.unitPriceIncludesGSTCheckBox.Location = new System.Drawing.Point(170, 135);
            this.unitPriceIncludesGSTCheckBox.Name = "unitPriceIncludesGSTCheckBox";
            this.unitPriceIncludesGSTCheckBox.Size = new System.Drawing.Size(15, 14);
            this.unitPriceIncludesGSTCheckBox.TabIndex = 12;
            this.unitPriceIncludesGSTCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 266);
            this.Controls.Add(this.unitPriceIncludesGSTCheckBox);
            this.Controls.Add(this.unitPriceIncludesGSTLabel);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.qtyTB);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.unitPriceTB);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.itemCodeTB);
            this.Controls.Add(this.itemCodeLabel);
            this.Name = "ItemCreator";
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
        private MetroFramework.Controls.MetroLabel unitPriceIncludesGSTLabel;
        private System.Windows.Forms.CheckBox unitPriceIncludesGSTCheckBox;
    }
}