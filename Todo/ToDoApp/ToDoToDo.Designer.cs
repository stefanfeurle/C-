using System.Windows.Forms;

namespace ToDoApp
{
    partial class ToDoToDo
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
            this.lbTimeAndTask = new System.Windows.Forms.ListBox();
            this.cbTaskDone = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTimeAndTask
            // 
            this.lbTimeAndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTimeAndTask.FormattingEnabled = true;
            this.lbTimeAndTask.ItemHeight = 20;
            this.lbTimeAndTask.Location = new System.Drawing.Point(175, 80);
            this.lbTimeAndTask.Name = "lbTimeAndTask";
            this.lbTimeAndTask.Size = new System.Drawing.Size(511, 284);
            this.lbTimeAndTask.TabIndex = 4;
            // 
            // cbTaskDone
            // 
            this.cbTaskDone.AutoSize = true;
            this.cbTaskDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTaskDone.Location = new System.Drawing.Point(175, 434);
            this.cbTaskDone.Name = "cbTaskDone";
            this.cbTaskDone.Size = new System.Drawing.Size(86, 24);
            this.cbTaskDone.TabIndex = 5;
            this.cbTaskDone.Text = "erledigt";
            this.cbTaskDone.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(471, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangeForm
            // 
            this.btnChangeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangeForm.Location = new System.Drawing.Point(175, 540);
            this.btnChangeForm.Name = "btnChangeForm";
            this.btnChangeForm.Size = new System.Drawing.Size(495, 52);
            this.btnChangeForm.TabIndex = 7;
            this.btnChangeForm.Text = "zurück";
            this.btnChangeForm.UseVisualStyleBackColor = true;
            this.btnChangeForm.Click += new System.EventHandler(this.btnChangeForm_Click);
            // 
            // ToDoToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 721);
            this.Controls.Add(this.btnChangeForm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbTaskDone);
            this.Controls.Add(this.lbTimeAndTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.Name = "ToDoToDo";
            this.Text = "importantToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
       
    
        private System.Windows.Forms.ListBox lbTimeAndTask;
        private System.Windows.Forms.CheckBox cbTaskDone;
        private System.Windows.Forms.Button btnSave;
        private Button btnChangeForm;
    }
}