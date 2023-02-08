using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindImageResolutionNET.Setting;

namespace FindImageResolutionNET
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            cmbFields.DataSource = Enum.GetValues(typeof(FieldsEnum));
            cmbLogLevel.DataSource = Enum.GetValues(typeof(SimpleLogger.LogLevel));
            cmbFieldConfig.Items.AddRange(Enum.GetNames(typeof(ResolutionEnum)));
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            var fields = Config.ReadUserFromFile();
            if (Enum.TryParse(fields.Field, true, out FieldsEnum field))
                cmbFields.SelectedItem = field;

            if (Enum.TryParse(fields.LogLevel, true, out SimpleLogger.LogLevel logLevel))
                cmbLogLevel.SelectedItem = logLevel;

            numPercentageOfSlowInspection.Value = fields.PercentageOfSlowInspection;
            cbForceRecheck.Checked = fields.ForceRecheck;
            rbCustom.Checked = fields.Custom;
            rbField.Checked = !fields.Custom;
            txtCustom.Text = fields.CustomField;
            txtText.Text = fields.Text;

            //Set location so Insert is by default at the end on load
            txtText.SelectionStart = txtText.TextLength;
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
            {
                SetFieldConfigValue(txt.Text);
                txt.Enabled = true;
            }
            else
            {
                txt.Enabled = false;
            }
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
                ForceRecheck = cbForceRecheck.Checked,
                Custom = rbCustom.Checked,
                CustomField = txtCustom.Text,
                Text = txtText.Text,
                Field = cmbFields.SelectedItem.ToString(),
                LogLevel = cmbLogLevel.SelectedItem.ToString(),
                PercentageOfSlowInspection = (int)numPercentageOfSlowInspection.Value,
            };
            Config.WriteUserToFile(fields);
            this.Close();
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if(rbField.Checked)
                SetFieldConfigValue(comboBox.Text);
        }

        private void SetFieldConfigValue(string text)
        {
            cmbFieldConfig.Items.Clear();
            cmbFieldConfig.Items.Add(text);
            cmbFieldConfig.Items.AddRange(Enum.GetNames(typeof(ResolutionEnum)));
            cmbFieldConfig.Text = text;
        }

        private void txtCustom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if(rbCustom.Checked)
                SetFieldConfigValue(textBox.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            value += "{" + txtPrefix.Text;
            value += $"<{cmbFieldConfig.Text}>";
            value += txtSuffix.Text + "}";

            if (!string.IsNullOrEmpty(value))
            {
                int cursorPosition = txtText.SelectionStart;
                txtText.Text = txtText.Text.Insert(cursorPosition, value);
                txtText.SelectionStart = txtText.TextLength;
            }
        }
    }
}
