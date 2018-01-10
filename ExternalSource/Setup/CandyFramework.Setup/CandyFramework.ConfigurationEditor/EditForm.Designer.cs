namespace CandyFramework.ConfigurationEditor
{
    partial class EditForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.txtProjectName = new MetroFramework.Controls.MetroTextBox();
            this.txtInstanceName = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Project Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Instance Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 132);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            // 
            // 
            // 
            this.txtConnectionString.CustomButton.Image = null;
            this.txtConnectionString.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtConnectionString.CustomButton.Name = "";
            this.txtConnectionString.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConnectionString.CustomButton.TabIndex = 1;
            this.txtConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConnectionString.CustomButton.UseSelectable = true;
            this.txtConnectionString.CustomButton.Visible = false;
            this.txtConnectionString.Lines = new string[] {
        "Data Source=.;initial catalog=CandyFramDb;User ID=sa;Password=Bimser123;Persist S" +
            "ecurity Info=True;"};
            this.txtConnectionString.Location = new System.Drawing.Point(23, 167);
            this.txtConnectionString.MaxLength = 32767;
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.PasswordChar = '\0';
            this.txtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConnectionString.SelectedText = "";
            this.txtConnectionString.SelectionLength = 0;
            this.txtConnectionString.SelectionStart = 0;
            this.txtConnectionString.ShortcutsEnabled = true;
            this.txtConnectionString.Size = new System.Drawing.Size(394, 121);
            this.txtConnectionString.TabIndex = 3;
            this.txtConnectionString.Text = "Data Source=.;initial catalog=CandyFramDb;User ID=sa;Password=Bimser123;Persist S" +
    "ecurity Info=True;";
            this.txtConnectionString.UseSelectable = true;
            this.txtConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProjectName
            // 
            // 
            // 
            // 
            this.txtProjectName.CustomButton.Image = null;
            this.txtProjectName.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtProjectName.CustomButton.Name = "";
            this.txtProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectName.CustomButton.TabIndex = 1;
            this.txtProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectName.CustomButton.UseSelectable = true;
            this.txtProjectName.CustomButton.Visible = false;
            this.txtProjectName.Lines = new string[] {
        "CandyFramework"};
            this.txtProjectName.Location = new System.Drawing.Point(154, 56);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.ShortcutsEnabled = true;
            this.txtProjectName.Size = new System.Drawing.Size(263, 23);
            this.txtProjectName.TabIndex = 4;
            this.txtProjectName.Text = "CandyFramework";
            this.txtProjectName.UseSelectable = true;
            this.txtProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInstanceName
            // 
            // 
            // 
            // 
            this.txtInstanceName.CustomButton.Image = null;
            this.txtInstanceName.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtInstanceName.CustomButton.Name = "";
            this.txtInstanceName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInstanceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstanceName.CustomButton.TabIndex = 1;
            this.txtInstanceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstanceName.CustomButton.UseSelectable = true;
            this.txtInstanceName.CustomButton.Visible = false;
            this.txtInstanceName.Lines = new string[] {
        "Developer"};
            this.txtInstanceName.Location = new System.Drawing.Point(154, 97);
            this.txtInstanceName.MaxLength = 32767;
            this.txtInstanceName.Name = "txtInstanceName";
            this.txtInstanceName.PasswordChar = '\0';
            this.txtInstanceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstanceName.SelectedText = "";
            this.txtInstanceName.SelectionLength = 0;
            this.txtInstanceName.SelectionStart = 0;
            this.txtInstanceName.ShortcutsEnabled = true;
            this.txtInstanceName.Size = new System.Drawing.Size(263, 23);
            this.txtInstanceName.TabIndex = 5;
            this.txtInstanceName.Text = "Developer";
            this.txtInstanceName.UseSelectable = true;
            this.txtInstanceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstanceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 322);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInstanceName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtConnectionString;
        private MetroFramework.Controls.MetroTextBox txtProjectName;
        private MetroFramework.Controls.MetroTextBox txtInstanceName;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}