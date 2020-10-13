using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10___Multiple_Forms
{
    public partial class FormAddName : Form
    {
        public FormAddName()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = MainForm.names;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newName = txtAddName.Text.Trim();
            if (newName != "")
            {
                if (MainForm.names.Contains(newName))
                {
                    lblStatus.Text = "Please enter a name not already in the list";
                }
                else
                {
                    MainForm.names.Add(newName);
                    lstNames.DataSource = null;
                    lstNames.DataSource = MainForm.names;
                    txtAddName.Text = "";
                    lblStatus.Text = ($"New name {newName} had been added");
                }

            }
        }
    }
}
