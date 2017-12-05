namespace CandyFramework.Setup
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
            this.pnl_Vs = new System.Windows.Forms.Panel();
            this.pb_Install = new MetroFramework.Controls.MetroProgressBar();
            this.btnInstall = new MetroFramework.Controls.MetroTile();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblLink = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // pnl_Vs
            // 
            this.pnl_Vs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Vs.Location = new System.Drawing.Point(20, 60);
            this.pnl_Vs.Name = "pnl_Vs";
            this.pnl_Vs.Size = new System.Drawing.Size(432, 216);
            this.pnl_Vs.TabIndex = 0;
            // 
            // pb_Install
            // 
            this.pb_Install.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_Install.Location = new System.Drawing.Point(20, 276);
            this.pb_Install.Name = "pb_Install";
            this.pb_Install.Size = new System.Drawing.Size(432, 23);
            this.pb_Install.TabIndex = 1;
            // 
            // btnInstall
            // 
            this.btnInstall.ActiveControl = null;
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.Location = new System.Drawing.Point(339, 305);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(113, 41);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "Yükle / Güncelle";
            this.btnInstall.UseSelectable = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Hazır...";
            // 
            // lblLink
            // 
            this.lblLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLink.Location = new System.Drawing.Point(20, 343);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(169, 23);
            this.lblLink.TabIndex = 4;
            this.lblLink.Text = "Candy Framework - Github";
            this.lblLink.UseSelectable = true;
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 369);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.pb_Install);
            this.Controls.Add(this.pnl_Vs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Candy Framework Kurulum";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Vs;
        private MetroFramework.Controls.MetroProgressBar pb_Install;
        private MetroFramework.Controls.MetroTile btnInstall;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLink lblLink;
    }
}

