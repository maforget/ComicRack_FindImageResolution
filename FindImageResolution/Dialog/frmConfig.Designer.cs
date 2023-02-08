namespace FindImageResolutionNET
{
    partial class frmConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbField = new System.Windows.Forms.RadioButton();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPercentageToCheck = new System.Windows.Forms.Label();
            this.numPercentageOfSlowInspection = new System.Windows.Forms.NumericUpDown();
            this.cbForceRecheck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFieldConfig = new System.Windows.Forms.ComboBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblFieldConfig = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentageOfSlowInspection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(335, 243);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(254, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(40, 17);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(352, 45);
            this.txtText.TabIndex = 4;
            this.txtText.Text = "{<Width>px}";
            this.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtText, resources.GetString("txtText.ToolTip"));
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(6, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text : ";
            this.toolTip1.SetToolTip(this.lblText, resources.GetString("lblText.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCustom);
            this.groupBox1.Controls.Add(this.rbCustom);
            this.groupBox1.Controls.Add(this.rbField);
            this.groupBox1.Controls.Add(this.cmbFields);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert into Field";
            // 
            // txtCustom
            // 
            this.txtCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustom.Enabled = false;
            this.txtCustom.Location = new System.Drawing.Point(80, 46);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(310, 20);
            this.txtCustom.TabIndex = 3;
            this.txtCustom.TextChanged += new System.EventHandler(this.txtCustom_TextChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(7, 46);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbField
            // 
            this.rbField.AutoSize = true;
            this.rbField.Checked = true;
            this.rbField.Location = new System.Drawing.Point(7, 22);
            this.rbField.Name = "rbField";
            this.rbField.Size = new System.Drawing.Size(52, 17);
            this.rbField.TabIndex = 0;
            this.rbField.TabStop = true;
            this.rbField.Text = "Fields";
            this.rbField.UseVisualStyleBackColor = true;
            this.rbField.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // cmbFields
            // 
            this.cmbFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(80, 21);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(310, 21);
            this.cmbFields.TabIndex = 1;
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(81, 214);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(110, 21);
            this.cmbLogLevel.TabIndex = 5;
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLog.AutoSize = true;
            this.lblLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLog.Location = new System.Drawing.Point(15, 217);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(60, 13);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log Level :";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercentageToCheck
            // 
            this.lblPercentageToCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentageToCheck.AutoSize = true;
            this.lblPercentageToCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPercentageToCheck.Location = new System.Drawing.Point(218, 217);
            this.lblPercentageToCheck.Name = "lblPercentageToCheck";
            this.lblPercentageToCheck.Size = new System.Drawing.Size(111, 13);
            this.lblPercentageToCheck.TabIndex = 12;
            this.lblPercentageToCheck.Text = "% of Slow Inspection :";
            this.lblPercentageToCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblPercentageToCheck, resources.GetString("lblPercentageToCheck.ToolTip"));
            // 
            // numPercentageOfSlowInspection
            // 
            this.numPercentageOfSlowInspection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numPercentageOfSlowInspection.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPercentageOfSlowInspection.Location = new System.Drawing.Point(335, 215);
            this.numPercentageOfSlowInspection.Name = "numPercentageOfSlowInspection";
            this.numPercentageOfSlowInspection.Size = new System.Drawing.Size(75, 20);
            this.numPercentageOfSlowInspection.TabIndex = 6;
            this.numPercentageOfSlowInspection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.numPercentageOfSlowInspection, resources.GetString("numPercentageOfSlowInspection.ToolTip"));
            this.numPercentageOfSlowInspection.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbForceRecheck
            // 
            this.cbForceRecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbForceRecheck.AutoSize = true;
            this.cbForceRecheck.Location = new System.Drawing.Point(12, 249);
            this.cbForceRecheck.Name = "cbForceRecheck";
            this.cbForceRecheck.Size = new System.Drawing.Size(100, 17);
            this.cbForceRecheck.TabIndex = 13;
            this.cbForceRecheck.Text = "Force Recheck";
            this.toolTip1.SetToolTip(this.cbForceRecheck, resources.GetString("cbForceRecheck.ToolTip"));
            this.cbForceRecheck.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(339, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Inserted the Prefix, Field & Suffix with the correct syntax at the cursor locatio" +
        "n.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbFieldConfig
            // 
            this.cmbFieldConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFieldConfig.FormattingEnabled = true;
            this.cmbFieldConfig.Location = new System.Drawing.Point(100, 90);
            this.cmbFieldConfig.Name = "cmbFieldConfig";
            this.cmbFieldConfig.Size = new System.Drawing.Size(134, 21);
            this.cmbFieldConfig.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbFieldConfig, "Any value can be used, even those that aren\'t in the Drop Down.\r\nIf the value doe" +
        "sn\'t exist, then it will check in the custom fields.");
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrefix.Location = new System.Drawing.Point(6, 90);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(88, 20);
            this.txtPrefix.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtPrefix, "Will be inserted before the field if it has a value.\r\n");
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuffix.Location = new System.Drawing.Point(240, 90);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(93, 20);
            this.txtSuffix.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtSuffix, "Will be inserted after the field if it has a value.");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblText);
            this.groupBox2.Controls.Add(this.lblSuffix);
            this.groupBox2.Controls.Add(this.txtText);
            this.groupBox2.Controls.Add(this.lblFieldConfig);
            this.groupBox2.Controls.Add(this.txtPrefix);
            this.groupBox2.Controls.Add(this.lblPrefix);
            this.groupBox2.Controls.Add(this.cmbFieldConfig);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtSuffix);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field Config";
            // 
            // lblSuffix
            // 
            this.lblSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(270, 74);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblSuffix.TabIndex = 20;
            this.lblSuffix.Text = "Suffix";
            this.toolTip1.SetToolTip(this.lblSuffix, "Will be inserted after the field if it has a value.");
            // 
            // lblFieldConfig
            // 
            this.lblFieldConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFieldConfig.AutoSize = true;
            this.lblFieldConfig.Location = new System.Drawing.Point(149, 74);
            this.lblFieldConfig.Name = "lblFieldConfig";
            this.lblFieldConfig.Size = new System.Drawing.Size(29, 13);
            this.lblFieldConfig.TabIndex = 19;
            this.lblFieldConfig.Text = "Field";
            this.toolTip1.SetToolTip(this.lblFieldConfig, "Any value can be used, even those that aren\'t in the Drop Down.\r\nIf the value doe" +
        "sn\'t exist, then it will check in the custom fields.");
            // 
            // lblPrefix
            // 
            this.lblPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(30, 74);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(33, 13);
            this.lblPrefix.TabIndex = 18;
            this.lblPrefix.Text = "Prefix";
            this.toolTip1.SetToolTip(this.lblPrefix, "Will be inserted before the field if it has a value.");
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbForceRecheck);
            this.Controls.Add(this.numPercentageOfSlowInspection);
            this.Controls.Add(this.lblPercentageToCheck);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.cmbLogLevel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentageOfSlowInspection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbField;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPercentageToCheck;
        private System.Windows.Forms.NumericUpDown numPercentageOfSlowInspection;
        private System.Windows.Forms.CheckBox cbForceRecheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbFieldConfig;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblFieldConfig;
        private System.Windows.Forms.Label lblPrefix;
    }
}