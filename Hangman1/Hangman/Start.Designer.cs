namespace Hangman
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(514, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGMAN";
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.Lime;
            this.btnHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnHighScore.Location = new System.Drawing.Point(121, 454);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(269, 100);
            this.btnHighScore.TabIndex = 1;
            this.btnHighScore.Text = "HighScore";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.Lime;
            this.btnAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddWord.Location = new System.Drawing.Point(549, 454);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(269, 100);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Wörter hinzufügen";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPlay.Location = new System.Drawing.Point(549, 284);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(269, 100);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Lime;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEnd.Location = new System.Drawing.Point(958, 454);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(269, 100);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Ende";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(647, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "SF20";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label2;
    }
}

