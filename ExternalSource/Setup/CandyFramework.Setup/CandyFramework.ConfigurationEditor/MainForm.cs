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
    public partial class MainForm : MetroForm
    {
        internal List<Product> ProductList;
        internal const string StaticFrameworkPath = "SOFTWARE\\CandyFramework";
        public MainForm()
        {
            InitializeComponent();
            this.Icon = ConfigurationEditor.Properties.Resources.Candy1;
            ProductList = new List<Product>();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;
            if ((Product)selectedItem != null)
            {
                EditForm ef = new EditForm((Product)selectedItem);
                ef.ShowDialog();
                LoadListBox();
            }
        }
        private void LoadProductInstance()
        {
            this.ProductList.Clear();
            RegistryKey key = Registry.LocalMachine.OpenSubKey(StaticFrameworkPath);

            if (key == null)
            {
                //Eğer Ana klasör oksa oluştur
                key = Registry.LocalMachine.CreateSubKey(StaticFrameworkPath);
            }
            //Ürünler içinde dön
            foreach (var projectName in key.GetSubKeyNames())
            {
                //Oluşturulan Ürün dizinini al
                var projectKey = Registry.LocalMachine.OpenSubKey(StaticFrameworkPath + "\\" + projectName);
                var product = new Product(projectName);
                if (projectKey != null)
                {
                    //Ürünlerin Örneklerinin içinde dön
                    foreach (var instance in projectKey.GetSubKeyNames())
                    {
                        product.InstanceName = instance;
                        //Okunacak Key
                        var productInstance = Registry.LocalMachine.OpenSubKey(StaticFrameworkPath + "\\" + projectName + "\\" + instance);
                        if (productInstance != null)
                        {
                            product.ConnectionString = productInstance.GetValue("ConnectionString")?.ToString();
                        }

                        this.ProductList.Add(product);
                    }
                }
            }
            key.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }
        private void LoadListBox()
        {

            listBox1.DataSource = null;

            LoadProductInstance();

            listBox1.DataSource = this.ProductList;
            listBox1.ClearSelected();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
            LoadListBox();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(null, null);
        }
        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = (Product)listBox1.SelectedItem;
            if (selectedItem != null)
            {
                var any = Registry.LocalMachine.OpenSubKey(MainForm.StaticFrameworkPath + "\\" + selectedItem.ProductName);

                if (any != null)
                {
                    Registry.LocalMachine.DeleteSubKeyTree(MainForm.StaticFrameworkPath + "\\" + selectedItem.ProductName, true);
                }
                LoadListBox();
            }
        }
    }
}
