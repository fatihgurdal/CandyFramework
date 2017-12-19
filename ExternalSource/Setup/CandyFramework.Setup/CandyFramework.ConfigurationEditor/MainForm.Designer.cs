namespace CandyFramework.ConfigurationEditor
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "CandyBlog - fgurdal",
            "CandyBlog - test",
            "CandyFramework - Developer"});
            this.listBox1.Location = new System.Drawing.Point(23, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 212);
            this.listBox1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(23, 63);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(64, 21);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseSelectable = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(93, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 21);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Çıkar";
            this.btnRemove.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(169, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 21);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 324);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Konfigürasyon Düzenleyicisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnEdit;
    }
}

