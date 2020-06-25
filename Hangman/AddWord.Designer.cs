namespace Hangman
{
    partial class AddWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAddWord = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.lbAlphabeth = new System.Windows.Forms.ListBox();
            this.tbSearchfield = new System.Windows.Forms.TextBox();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(430, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(172, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wörter dem Spiel hinzufügen";
            // 
            // rtbAddWord
            // 
            this.rtbAddWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbAddWord.Location = new System.Drawing.Point(168, 225);
            this.rtbAddWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAddWord.Name = "rtbAddWord";
            this.rtbAddWord.Size = new System.Drawing.Size(320, 329);
            this.rtbAddWord.TabIndex = 2;
            this.rtbAddWord.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(718, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wort aus dem Spiel entfernen";
            // 
            // lbWords
            // 
            this.lbWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbWords.FormattingEnabled = true;
            this.lbWords.ItemHeight = 20;
            this.lbWords.Location = new System.Drawing.Point(715, 225);
            this.lbWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(360, 324);
            this.lbWords.TabIndex = 4;
            // 
            // lbAlphabeth
            // 
            this.lbAlphabeth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbAlphabeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAlphabeth.FormattingEnabled = true;
            this.lbAlphabeth.ItemHeight = 20;
            this.lbAlphabeth.Location = new System.Drawing.Point(629, 225);
            this.lbAlphabeth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAlphabeth.Name = "lbAlphabeth";
            this.lbAlphabeth.Size = new System.Drawing.Size(56, 324);
            this.lbAlphabeth.TabIndex = 5;
            this.lbAlphabeth.SelectedIndexChanged += new System.EventHandler(this.lbAlphabeth_SelectedIndexChanged);
            // 
            // tbSearchfield
            // 
            this.tbSearchfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbSearchfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchfield.Location = new System.Drawing.Point(715, 178);
            this.tbSearchfield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchfield.Name = "tbSearchfield";
            this.tbSearchfield.Size = new System.Drawing.Size(360, 26);
            this.tbSearchfield.TabIndex = 6;
            this.tbSearchfield.TextChanged += new System.EventHandler(this.tbSearchfield_TextChanged);
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteWord.Location = new System.Drawing.Point(715, 594);
            this.btnDeleteWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(359, 42);
            this.btnDeleteWord.TabIndex = 7;
            this.btnDeleteWord.Text = "Wort löschen";
            this.btnDeleteWord.UseVisualStyleBackColor = false;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.Lime;
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddWord.Location = new System.Drawing.Point(168, 594);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(320, 42);
            this.btnAddWord.TabIndex = 8;
            this.btnAddWord.Text = "Wörter hinzufügen";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(173, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "(pro Zeile max. ein Wort)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(632, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 751);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.tbSearchfield);
            this.Controls.Add(this.lbAlphabeth);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbAddWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddWord";
            this.Text = "AddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAddWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.ListBox lbAlphabeth;
        private System.Windows.Forms.TextBox tbSearchfield;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}