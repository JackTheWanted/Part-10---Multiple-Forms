﻿using System;
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
    public partial class MainForm : Form
    {
        public static List<string> names = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddName frmAddName = new FormAddName();
            frmAddName.ShowDialog();
            ResetList();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            FormEditName frmEditName = new FormEditName(lstNames.SelectedIndex);
            frmEditName.ShowDialog();
            ResetList();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            names.Add("JACK");
            names.Add("COLE");
            names.Add("TILSON");
            names.Sort();
            lstNames.DataSource = names;
        }

        private void btnRemoveNames_Click(object sender, EventArgs e)
        {
            names.RemoveAt(lstNames.SelectedIndex);
            ResetList();
        }

        private void ResetList()
        {
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }
    }
}
