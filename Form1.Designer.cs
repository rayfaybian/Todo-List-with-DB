
namespace Todo_List
{
    partial class Form1
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
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.rTP = new System.Windows.Forms.RichTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dTP
            // 
            this.dTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTP.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP.Location = new System.Drawing.Point(48, 35);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(253, 26);
            this.dTP.TabIndex = 0;
            // 
            // rTP
            // 
            this.rTP.Location = new System.Drawing.Point(48, 80);
            this.rTP.Name = "rTP";
            this.rTP.Size = new System.Drawing.Size(253, 292);
            this.rTP.TabIndex = 1;
            this.rTP.Text = "";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(129, 399);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 26);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.rTP);
            this.Controls.Add(this.dTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.RichTextBox rTP;
        private System.Windows.Forms.Button btAdd;
    }
}

