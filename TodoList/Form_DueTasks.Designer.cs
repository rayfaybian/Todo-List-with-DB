
namespace TodoList
{
    partial class Form_DueTasks
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
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.cbRemindLater = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateBox
            // 
            this.dateBox.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox.Location = new System.Drawing.Point(32, 30);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(257, 26);
            this.dateBox.TabIndex = 8;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(32, 76);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(257, 195);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(103, 383);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 30);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(32, 290);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(78, 21);
            this.cbDone.TabIndex = 9;
            this.cbDone.Text = "Erledigt";
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.CheckedChanged += new System.EventHandler(this.cbDone_CheckedChanged);
            // 
            // cbRemindLater
            // 
            this.cbRemindLater.AutoSize = true;
            this.cbRemindLater.Location = new System.Drawing.Point(32, 317);
            this.cbRemindLater.Name = "cbRemindLater";
            this.cbRemindLater.Size = new System.Drawing.Size(129, 21);
            this.cbRemindLater.TabIndex = 10;
            this.cbRemindLater.Text = "Später erinnern";
            this.cbRemindLater.UseVisualStyleBackColor = true;
            this.cbRemindLater.CheckedChanged += new System.EventHandler(this.cbRemindLater_CheckedChanged);
            // 
            // Form_DueTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.cbRemindLater);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btSave);
            this.Name = "Form_DueTasks";
            this.Text = "Erinnerung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DueTasks_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.CheckBox cbRemindLater;
    }
}