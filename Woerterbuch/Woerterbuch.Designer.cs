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
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(325, 172);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbGermanWord.Location = new System.Drawing.Point(99, 73);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(2);
            this.tbGermanWord.Multiline = true;
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(178, 29);
            this.tbGermanWord.TabIndex = 1;
            //this.tbGermanWord.Click += new System.EventHandler(this.tbGermanWord_Click);
            //this.tbGermanWord.MouseLeave += new System.EventHandler(this.tbGermanWord_MouseLeave);
            //this.tbGermanWord.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbGermanWord_MouseMove);
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbEnglishWord.Location = new System.Drawing.Point(508, 51);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnglishWord.Multiline = true;
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(178, 29);
            this.tbEnglishWord.TabIndex = 2;
            // 
            // lbTranslationE
            // 
            this.lbTranslationE.AutoSize = true;
            this.lbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationE.Location = new System.Drawing.Point(327, 63);
            this.lbTranslationE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTranslationE.Name = "lbTranslationE";
            this.lbTranslationE.Size = new System.Drawing.Size(129, 17);
            this.lbTranslationE.TabIndex = 3;
            this.lbTranslationE.Text = "Deutsch<>Englisch";
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.AllowDrop = true;
            this.lBoxGermanWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 17;
            this.lBoxGermanWords.Location = new System.Drawing.Point(99, 253);
            this.lBoxGermanWords.Margin = new System.Windows.Forms.Padding(2);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(302, 327);
            this.lBoxGermanWords.TabIndex = 4;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslationE
            // 
            this.tbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationE.Location = new System.Drawing.Point(508, 253);
            this.tbTranslationE.Margin = new System.Windows.Forms.Padding(2);
            this.tbTranslationE.Multiline = true;
            this.tbTranslationE.Name = "tbTranslationE";
            this.tbTranslationE.Size = new System.Drawing.Size(178, 29);
            this.tbTranslationE.TabIndex = 5;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(576, 539);
            this.btnExportToCSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(110, 41);
            this.btnExportToCSV.TabIndex = 6;
            this.btnExportToCSV.Text = "Export CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // tbSchwedishWord
            // 
            this.tbSchwedishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbSchwedishWord.Location = new System.Drawing.Point(508, 101);
            this.tbSchwedishWord.Multiline = true;
            this.tbSchwedishWord.Name = "tbSchwedishWord";
            this.tbSchwedishWord.Size = new System.Drawing.Size(178, 29);
            this.tbSchwedishWord.TabIndex = 7;
            // 
            // lbTranslationS
            // 
            this.lbTranslationS.AutoSize = true;
            this.lbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationS.Location = new System.Drawing.Point(327, 101);
            this.lbTranslationS.Name = "lbTranslationS";
            this.lbTranslationS.Size = new System.Drawing.Size(150, 17);
            this.lbTranslationS.TabIndex = 10;
            this.lbTranslationS.Text = "Deutsch<>Schwedisch";
            // 
            // tbTranslationS
            // 
            this.tbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationS.Location = new System.Drawing.Point(508, 300);
            this.tbTranslationS.Multiline = true;
            this.tbTranslationS.Name = "tbTranslationS";
            this.tbTranslationS.Size = new System.Drawing.Size(178, 29);
            this.tbTranslationS.TabIndex = 11;
            // 
            // Woerterbuch
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 742);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Woerterbuch";
            this.Text = "Woerterbuch";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Woerterbuch_FormClosing);
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
    }
}

