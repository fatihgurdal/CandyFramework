using CandyFramework.ConfigurationEditor.Entites;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyFramework.ConfigurationEditor
{
    public partial class EditForm : MetroForm
    {
        Product oldProductData;
        public EditForm()
        {

            InitializeComponent();
        }
        public EditForm(Product product) : this()
        {
            oldProductData = product;
            this.txtProjectName.Text = product.ProductName;
            this.txtInstanceName.Text = product.InstanceName;
            this.txtConnectionString.Text = product.ConnectionString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (oldProductData != null)
            {
                var any = Registry.LocalMachine.OpenSubKey(MainForm.StaticFrameworkPath + "\\" + oldProductData.ProductName);

                if (any != null)
                {
                    Registry.LocalMachine.DeleteSubKeyTree(MainForm.StaticFrameworkPath + "\\" + oldProductData.ProductName, true);
                }
            }

            Registry.LocalMachine.CreateSubKey(MainForm.StaticFrameworkPath + "\\" + txtProjectName.Text);
            Registry.LocalMachine.CreateSubKey(MainForm.StaticFrameworkPath + "\\" + txtProjectName.Text + "\\" + txtInstanceName.Text);

            var key = Registry.LocalMachine.OpenSubKey(MainForm.StaticFrameworkPath + "\\" + txtProjectName.Text + "\\" + txtInstanceName.Text, true);

            key.SetValue("ConnectionString", txtConnectionString.Text, RegistryValueKind.String);

            this.Close();
        }
    }
}
