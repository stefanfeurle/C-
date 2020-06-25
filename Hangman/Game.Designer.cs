namespace Hangman
{
    partial class Game
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
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxAlphabeth = new System.Windows.Forms.ComboBox();
            this.tbCryptedWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAttempt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Location = new System.Drawing.Point(119, 162);
            this.pictureBoxHangman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(306, 364);
            this.pictureBoxHangman.TabIndex = 0;
            this.pictureBoxHangman.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(436, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "HANGMAN";
            // 
            // cboxAlphabeth
            // 
            this.cboxAlphabeth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboxAlphabeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboxAlphabeth.FormattingEnabled = true;
            this.cboxAlphabeth.Location = new System.Drawing.Point(888, 300);
            this.cboxAlphabeth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAlphabeth.Name = "cboxAlphabeth";
            this.cboxAlphabeth.Size = new System.Drawing.Size(108, 33);
            this.cboxAlphabeth.TabIndex = 2;
            // 
            // tbCryptedWord
            // 
            this.tbCryptedWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCryptedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCryptedWord.Location = new System.Drawing.Point(538, 303);
            this.tbCryptedWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCryptedWord.Name = "tbCryptedWord";
            this.tbCryptedWord.Size = new System.Drawing.Size(296, 30);
            this.tbCryptedWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(533, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Versuch:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(533, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zeit:         ";
            // 
            // tbAttempt
            // 
            this.tbAttempt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAttempt.Location = new System.Drawing.Point(697, 458);
            this.tbAttempt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttempt.Name = "tbAttempt";
            this.tbAttempt.Size = new System.Drawing.Size(104, 30);
            this.tbAttempt.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(697, 503);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 30);
            this.textBox3.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Lime;
            this.btnLogout.Location = new System.Drawing.Point(119, 598);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 29);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Spiel beenden";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(538, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "HighScore";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Lime;
            this.btnStartGame.Location = new System.Drawing.Point(538, 162);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(134, 30);
            this.btnStartGame.TabIndex = 11;
            this.btnStartGame.Text = "Start Spiel";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Location = new System.Drawing.Point(538, 359);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(458, 32);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "ausgewählter Buchstabe bestätigen";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 672);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbAttempt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCryptedWord);
            this.Controls.Add(this.cboxAlphabeth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHangman);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxAlphabeth;
        private System.Windows.Forms.TextBox tbCryptedWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAttempt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPlay;
    }
}