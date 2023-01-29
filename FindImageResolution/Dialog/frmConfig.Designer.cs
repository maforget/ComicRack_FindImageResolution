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
            this.cbAppend = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiHeight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.cbNewline = new System.Windows.Forms.CheckBox();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(318, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(42, 126);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(293, 20);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "<Width>px";
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 129);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text : ";
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
            this.groupBox1.Size = new System.Drawing.Size(381, 77);
            this.groupBox1.TabIndex = 4;
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
            this.txtCustom.Size = new System.Drawing.Size(293, 20);
            this.txtCustom.TabIndex = 3;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(7, 46);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 2;
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
            this.rbField.TabIndex = 1;
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
            this.cmbFields.Size = new System.Drawing.Size(293, 21);
            this.cmbFields.TabIndex = 0;
            // 
            // cbAppend
            // 
            this.cbAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAppend.AutoSize = true;
            this.cbAppend.Location = new System.Drawing.Point(12, 158);
            this.cbAppend.Name = "cbAppend";
            this.cbAppend.Size = new System.Drawing.Size(63, 17);
            this.cbAppend.TabIndex = 5;
            this.cbAppend.Text = "Append";
            this.cbAppend.UseVisualStyleBackColor = true;
            this.cbAppend.CheckedChanged += new System.EventHandler(this.cbAppend_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(332, 126);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(64, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiHeight,
            this.tsiWidth});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Variable";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsiHeight
            // 
            this.tsiHeight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsiHeight.Name = "tsiHeight";
            this.tsiHeight.Size = new System.Drawing.Size(110, 22);
            this.tsiHeight.Text = "Height";
            this.tsiHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsiHeight.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // tsiWidth
            // 
            this.tsiWidth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsiWidth.Name = "tsiWidth";
            this.tsiWidth.Size = new System.Drawing.Size(110, 22);
            this.tsiWidth.Text = "Width";
            this.tsiWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsiWidth.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // cbNewline
            // 
            this.cbNewline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNewline.AutoSize = true;
            this.cbNewline.Enabled = false;
            this.cbNewline.Location = new System.Drawing.Point(81, 158);
            this.cbNewline.Name = "cbNewline";
            this.cbNewline.Size = new System.Drawing.Size(64, 17);
            this.cbNewline.TabIndex = 8;
            this.cbNewline.Text = "Newline";
            this.cbNewline.UseVisualStyleBackColor = true;
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(272, 98);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbLogLevel.TabIndex = 9;
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLog.AutoSize = true;
            this.lblLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLog.Location = new System.Drawing.Point(203, 101);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(63, 13);
            this.lblLog.TabIndex = 10;
            this.lblLog.Text = "Log Level : ";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(405, 189);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.cmbLogLevel);
            this.Controls.Add(this.cbNewline);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbAppend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbAppend;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiHeight;
        private System.Windows.Forms.ToolStripMenuItem tsiWidth;
        private System.Windows.Forms.CheckBox cbNewline;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.Label lblLog;
    }
}