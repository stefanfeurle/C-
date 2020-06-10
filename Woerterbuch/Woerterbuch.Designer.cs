namespace Woerterbuch
{
    partial class Woerterbuch
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
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lbTranslationE = new System.Windows.Forms.Label();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslationE = new System.Windows.Forms.TextBox();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.tbSchwedishWord = new System.Windows.Forms.TextBox();
            this.lbTranslationS = new System.Windows.Forms.Label();
            this.tbTranslationS = new System.Windows.Forms.TextBox();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.lBoxAlphabeth = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(636, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbGermanWord.Location = new System.Drawing.Point(306, 121);
            this.tbGermanWord.Multiline = true;
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(265, 42);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbEnglishWord.Location = new System.Drawing.Point(941, 80);
            this.tbEnglishWord.Multiline = true;
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(265, 42);
            this.tbEnglishWord.TabIndex = 2;
            // 
            // lbTranslationE
            // 
            this.lbTranslationE.AutoSize = true;
            this.lbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationE.Location = new System.Drawing.Point(631, 112);
            this.lbTranslationE.Name = "lbTranslationE";
            this.lbTranslationE.Size = new System.Drawing.Size(197, 25);
            this.lbTranslationE.TabIndex = 3;
            this.lbTranslationE.Text = "Deutsch<>Englisch";
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.AllowDrop = true;
            this.lBoxGermanWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 25;
            this.lBoxGermanWords.Location = new System.Drawing.Point(306, 462);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(451, 479);
            this.lBoxGermanWords.TabIndex = 4;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslationE
            // 
            this.tbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationE.Location = new System.Drawing.Point(941, 452);
            this.tbTranslationE.Multiline = true;
            this.tbTranslationE.Name = "tbTranslationE";
            this.tbTranslationE.Size = new System.Drawing.Size(265, 42);
            this.tbTranslationE.TabIndex = 5;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(864, 829);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(165, 63);
            this.btnExportToCSV.TabIndex = 6;
            this.btnExportToCSV.Text = "Export CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // tbSchwedishWord
            // 
            this.tbSchwedishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbSchwedishWord.Location = new System.Drawing.Point(941, 155);
            this.tbSchwedishWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSchwedishWord.Multiline = true;
            this.tbSchwedishWord.Name = "tbSchwedishWord";
            this.tbSchwedishWord.Size = new System.Drawing.Size(265, 42);
            this.tbSchwedishWord.TabIndex = 7;
            // 
            // lbTranslationS
            // 
            this.lbTranslationS.AutoSize = true;
            this.lbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationS.Location = new System.Drawing.Point(631, 155);
            this.lbTranslationS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTranslationS.Name = "lbTranslationS";
            this.lbTranslationS.Size = new System.Drawing.Size(230, 25);
            this.lbTranslationS.TabIndex = 10;
            this.lbTranslationS.Text = "Deutsch<>Schwedisch";
            // 
            // tbTranslationS
            // 
            this.tbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationS.Location = new System.Drawing.Point(941, 534);
            this.tbTranslationS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTranslationS.Multiline = true;
            this.tbTranslationS.Name = "tbTranslationS";
            this.tbTranslationS.Size = new System.Drawing.Size(265, 42);
            this.tbTranslationS.TabIndex = 11;
            // 
            // tbSearchField
            // 
            this.tbSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearchField.Location = new System.Drawing.Point(306, 389);
            this.tbSearchField.Multiline = true;
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(451, 42);
            this.tbSearchField.TabIndex = 12;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // lBoxAlphabeth
            // 
            this.lBoxAlphabeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lBoxAlphabeth.FormattingEnabled = true;
            this.lBoxAlphabeth.ItemHeight = 25;
            this.lBoxAlphabeth.Location = new System.Drawing.Point(216, 462);
            this.lBoxAlphabeth.Name = "lBoxAlphabeth";
            this.lBoxAlphabeth.Size = new System.Drawing.Size(52, 479);
            this.lBoxAlphabeth.TabIndex = 13;
            this.lBoxAlphabeth.SelectedIndexChanged += new System.EventHandler(this.lBoxAlphabeth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(211, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // Woerterbuch
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 1142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBoxAlphabeth);
            this.Controls.Add(this.tbSearchField);
            this.Controls.Add(this.tbTranslationS);
            this.Controls.Add(this.lbTranslationS);
            this.Controls.Add(this.tbSchwedishWord);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.tbTranslationE);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.lbTranslationE);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Name = "Woerterbuch";
            this.Text = "Woerterbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.Label lbTranslationE;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslationE;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.TextBox tbSchwedishWord;
        private System.Windows.Forms.Label lbTranslationS;
        private System.Windows.Forms.TextBox tbTranslationS;
        private System.Windows.Forms.TextBox tbSearchField;
        private System.Windows.Forms.ListBox lBoxAlphabeth;
        private System.Windows.Forms.Label label1;
    }
}

