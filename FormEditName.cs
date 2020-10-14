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
    public partial class FormEditName : Form
    {
        int index;       
        public FormEditName(int index)
        {           
            InitializeComponent();
            this.index = index;
        }


        private void FormEditName_Load(object sender, EventArgs e)
        {
            lblEditName.Text = "Old name: " + MainForm.names[index];
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            txtEditName.Text = txtEditName.Text.Trim();

            if (txtEditName.Text != "")
            {

                if (!MainForm.names.Contains(txtEditName.Text.ToUpper()))
                {
                    MainForm.names.RemoveAt(index);
                    MainForm.names.Add(txtEditName.Text.ToUpper());
                    MainForm.names.Sort();
                    this.Dispose();
                }

                else
                {
                    lblEditError.Text = "Please enter a name not already in the list";
                }
            }
            else
                lblEditError.Text = "Please enter an acutal name";
        }   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
