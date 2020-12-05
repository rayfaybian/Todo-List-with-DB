
namespace TodoList
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbTodos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDone = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(35, 34);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(257, 26);
            this.datePicker.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(35, 98);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(257, 72);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(111, 187);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 30);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Hinzufügen";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbTodos
            // 
            this.lbTodos.FormattingEnabled = true;
            this.lbTodos.ItemHeight = 16;
            this.lbTodos.Location = new System.Drawing.Point(35, 292);
            this.lbTodos.Name = "lbTodos";
            this.lbTodos.Size = new System.Drawing.Size(257, 132);
            this.lbTodos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Offene Aufgaben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(115, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Neue Aufgabe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ErledigteAufgaben";
            // 
            // lbDone
            // 
            this.lbDone.FormattingEnabled = true;
            this.lbDone.ItemHeight = 16;
            this.lbDone.Location = new System.Drawing.Point(35, 474);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(257, 132);
            this.lbDone.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTodos);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btAdd);
            this.Name = "Form1";
            this.Text = "Meine Aufgaben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox lbTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDone;
    }
}

