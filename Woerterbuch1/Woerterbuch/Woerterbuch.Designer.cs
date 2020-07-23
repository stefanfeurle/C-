using System;

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
            this.cbLanguage1 = new System.Windows.Forms.ComboBox();
            this.tbWord1 = new System.Windows.Forms.TextBox();
            this.tbWord2 = new System.Windows.Forms.TextBox();
            this.cbLanguage2 = new System.Windows.Forms.ComboBox();
            this.btnAddWord2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbAlphabeth1 = new System.Windows.Forms.ListBox();
            this.tbSearchfield1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(565, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbGermanWord.Location = new System.Drawing.Point(193, 90);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGermanWord.Multiline = true;
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(236, 34);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbEnglishWord.Location = new System.Drawing.Point(727, 64);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEnglishWord.Multiline = true;
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(236, 34);
            this.tbEnglishWord.TabIndex = 2;
            // 
            // lbTranslationE
            // 
            this.lbTranslationE.AutoSize = true;
            this.lbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationE.Location = new System.Drawing.Point(476, 73);
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
            this.lBoxGermanWords.Location = new System.Drawing.Point(272, 370);
            this.lBoxGermanWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(401, 379);
            this.lBoxGermanWords.TabIndex = 4;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslationE
            // 
            this.tbTranslationE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationE.Location = new System.Drawing.Point(727, 370);
            this.tbTranslationE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTranslationE.Multiline = true;
            this.tbTranslationE.Name = "tbTranslationE";
            this.tbTranslationE.Size = new System.Drawing.Size(236, 34);
            this.tbTranslationE.TabIndex = 5;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(1741, 663);
            this.btnExportToCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(147, 86);
            this.btnExportToCSV.TabIndex = 6;
            this.btnExportToCSV.Text = "__Export CSV                 __und                          __Save Data";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSVAndSaveData_Click);
            // 
            // tbSchwedishWord
            // 
            this.tbSchwedishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbSchwedishWord.Location = new System.Drawing.Point(727, 121);
            this.tbSchwedishWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbSchwedishWord.Multiline = true;
            this.tbSchwedishWord.Name = "tbSchwedishWord";
            this.tbSchwedishWord.Size = new System.Drawing.Size(236, 34);
            this.tbSchwedishWord.TabIndex = 7;
            // 
            // lbTranslationS
            // 
            this.lbTranslationS.AutoSize = true;
            this.lbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTranslationS.Location = new System.Drawing.Point(476, 124);
            this.lbTranslationS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTranslationS.Name = "lbTranslationS";
            this.lbTranslationS.Size = new System.Drawing.Size(230, 25);
            this.lbTranslationS.TabIndex = 10;
            this.lbTranslationS.Text = "Deutsch<>Schwedisch";
            // 
            // tbTranslationS
            // 
            this.tbTranslationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslationS.Location = new System.Drawing.Point(727, 432);
            this.tbTranslationS.Margin = new System.Windows.Forms.Padding(4);
            this.tbTranslationS.Multiline = true;
            this.tbTranslationS.Name = "tbTranslationS";
            this.tbTranslationS.Size = new System.Drawing.Size(236, 34);
            this.tbTranslationS.TabIndex = 11;
            // 
            // tbSearchField
            // 
            this.tbSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearchField.Location = new System.Drawing.Point(272, 311);
            this.tbSearchField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchField.Multiline = true;
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(401, 34);
            this.tbSearchField.TabIndex = 12;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // lBoxAlphabeth
            // 
            this.lBoxAlphabeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lBoxAlphabeth.FormattingEnabled = true;
            this.lBoxAlphabeth.ItemHeight = 25;
            this.lBoxAlphabeth.Location = new System.Drawing.Point(206, 370);
            this.lBoxAlphabeth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBoxAlphabeth.Name = "lBoxAlphabeth";
            this.lBoxAlphabeth.Size = new System.Drawing.Size(47, 379);
            this.lBoxAlphabeth.TabIndex = 13;
            this.lBoxAlphabeth.SelectedIndexChanged += new System.EventHandler(this.lBoxAlphabeth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(188, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // cbLanguage1
            // 
            this.cbLanguage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbLanguage1.FormattingEnabled = true;
            this.cbLanguage1.Location = new System.Drawing.Point(1088, 91);
            this.cbLanguage1.Name = "cbLanguage1";
            this.cbLanguage1.Size = new System.Drawing.Size(121, 33);
            this.cbLanguage1.TabIndex = 15;
            // 
            // tbWord1
            // 
            this.tbWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbWord1.Location = new System.Drawing.Point(1231, 91);
            this.tbWord1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWord1.Multiline = true;
            this.tbWord1.Name = "tbWord1";
            this.tbWord1.Size = new System.Drawing.Size(236, 34);
            this.tbWord1.TabIndex = 16;
            // 
            // tbWord2
            // 
            this.tbWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbWord2.Location = new System.Drawing.Point(1499, 90);
            this.tbWord2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWord2.Multiline = true;
            this.tbWord2.Name = "tbWord2";
            this.tbWord2.Size = new System.Drawing.Size(236, 34);
            this.tbWord2.TabIndex = 17;
            // 
            // cbLanguage2
            // 
            this.cbLanguage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbLanguage2.FormattingEnabled = true;
            this.cbLanguage2.Location = new System.Drawing.Point(1767, 90);
            this.cbLanguage2.Name = "cbLanguage2";
            this.cbLanguage2.Size = new System.Drawing.Size(121, 33);
            this.cbLanguage2.TabIndex = 18;
            // 
            // btnAddWord2
            // 
            this.btnAddWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAddWord2.Location = new System.Drawing.Point(1185, 164);
            this.btnAddWord2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWord2.Name = "btnAddWord2";
            this.btnAddWord2.Size = new System.Drawing.Size(174, 46);
            this.btnAddWord2.TabIndex = 19;
            this.btnAddWord2.Text = "Hinzufügen";
            this.btnAddWord2.UseVisualStyleBackColor = true;
            this.btnAddWord2.Click += new System.EventHandler(this.btnAddWord2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(1412, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.Location = new System.Drawing.Point(1640, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 46);
            this.button3.TabIndex = 21;
            this.button3.Text = "Suchen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbAlphabeth1
            // 
            this.lbAlphabeth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbAlphabeth1.FormattingEnabled = true;
            this.lbAlphabeth1.ItemHeight = 25;
            this.lbAlphabeth1.Location = new System.Drawing.Point(1119, 381);
            this.lbAlphabeth1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAlphabeth1.Name = "lbAlphabeth1";
            this.lbAlphabeth1.Size = new System.Drawing.Size(47, 379);
            this.lbAlphabeth1.TabIndex = 22;
            this.lbAlphabeth1.SelectedIndexChanged += new System.EventHandler(this.lbAlphabeth1_SelectedIndexChanged);
            // 
            // tbSearchfield1
            // 
            this.tbSearchfield1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearchfield1.Location = new System.Drawing.Point(1221, 311);
            this.tbSearchfield1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchfield1.Multiline = true;
            this.tbSearchfield1.Name = "tbSearchfield1";
            this.tbSearchfield1.Size = new System.Drawing.Size(401, 34);
            this.tbSearchfield1.TabIndex = 23;
            this.tbSearchfield1.TextChanged += new System.EventHandler(this.tbSearchfield1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(1114, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search";
            // 
            // lBoxWords
            // 
            this.lBoxWords.AllowDrop = true;
            this.lBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lBoxWords.FormattingEnabled = true;
            this.lBoxWords.ItemHeight = 25;
            this.lBoxWords.Location = new System.Drawing.Point(1221, 370);
            this.lBoxWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBoxWords.Name = "lBoxWords";
            this.lBoxWords.Size = new System.Drawing.Size(401, 379);
            this.lBoxWords.TabIndex = 25;
            this.lBoxWords.SelectedIndexChanged += new System.EventHandler(this.lBoxWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbTranslation.Location = new System.Drawing.Point(1652, 370);
            this.tbTranslation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTranslation.Multiline = true;
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(236, 34);
            this.tbTranslation.TabIndex = 26;
            // 
            // Woerterbuch
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2324, 957);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchfield1);
            this.Controls.Add(this.lbAlphabeth1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddWord2);
            this.Controls.Add(this.cbLanguage2);
            this.Controls.Add(this.tbWord2);
            this.Controls.Add(this.tbWord1);
            this.Controls.Add(this.cbLanguage1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cbLanguage1;
        private System.Windows.Forms.TextBox tbWord1;
        private System.Windows.Forms.TextBox tbWord2;
        private System.Windows.Forms.ComboBox cbLanguage2;
        private System.Windows.Forms.Button btnAddWord2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbAlphabeth1;
        private System.Windows.Forms.TextBox tbSearchfield1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxWords;
        private System.Windows.Forms.TextBox tbTranslation;
    }
}

