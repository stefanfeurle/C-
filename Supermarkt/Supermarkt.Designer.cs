namespace Supermarkt
{
    partial class Supermarkt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbPurchasingList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdd.Location = new System.Drawing.Point(573, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemove.Location = new System.Drawing.Point(765, 105);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 46);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbProduct.Location = new System.Drawing.Point(62, 105);
            this.tbProduct.Multiline = true;
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(197, 46);
            this.tbProduct.TabIndex = 2;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbNumber.Location = new System.Drawing.Point(342, 105);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(144, 46);
            this.tbNumber.TabIndex = 3;
            // 
            // lbPurchasingList
            // 
            this.lbPurchasingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbPurchasingList.FormattingEnabled = true;
            this.lbPurchasingList.ItemHeight = 22;
            this.lbPurchasingList.Location = new System.Drawing.Point(62, 202);
            this.lbPurchasingList.Name = "lbPurchasingList";
            this.lbPurchasingList.Size = new System.Drawing.Size(530, 422);
            this.lbPurchasingList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produkt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(358, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExportCSV.Location = new System.Drawing.Point(765, 535);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(180, 89);
            this.btnExportCSV.TabIndex = 7;
            this.btnExportCSV.Text = "Einkaufsliste speichern";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // Supermarkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 807);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPurchasingList);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Supermarkt";
            this.Text = "My Supermarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.ListBox lbPurchasingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportCSV;
    }
}

