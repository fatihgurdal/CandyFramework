using MetroFramework.Forms;
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
        public MainForm()
        {
            InitializeComponent();
            this.Icon = ConfigurationEditor.Properties.Resources.Candy1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
        }
    }
}
