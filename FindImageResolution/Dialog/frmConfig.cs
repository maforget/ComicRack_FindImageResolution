﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindImageResolution.Setting;

namespace FindImageResolution.Dialog
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            cmbFields.DataSource = Enum.GetValues(typeof(FieldsEnum));
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            var fields = Config.ReadUserFromFile();
            if (Enum.TryParse(fields.Field, true, out FieldsEnum field))
                cmbFields.SelectedItem = field;
            
            cbAppend.Checked = fields.Append;
            rbCustom.Checked = fields.Custom;
            rbField.Checked = !fields.Custom;
            txtCustom.Text = fields.CustomField;
            txtText.Text = fields.Text;
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;

            if (rb.Name == "rbCustom")
                SwitchEnabled(rb, txtCustom);
            else
                SwitchEnabled(rb, cmbFields);
        }

        private void SwitchEnabled(RadioButton rb, Control txt)
        {
            if (rb.Checked)
                txt.Enabled = true;
            else
                txt.Enabled = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tsi = (ToolStripMenuItem)sender;
            txtText.Text += $"<{tsi.Text}>";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Fields fields = new Fields()
            {
                Append = cbAppend.Checked,
                Custom = rbCustom.Checked,
                CustomField = txtCustom.Text,
                Text = txtText.Text,
                Field = cmbFields.SelectedItem.ToString(),
            };
            Config.WriteUserToFile(fields);
            this.Close();
        }
    }
}
