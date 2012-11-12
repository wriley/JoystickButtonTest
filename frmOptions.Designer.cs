namespace JoystickButtonTest
{
    partial class frmOptions
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
            this.cbRefreshes = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbRefresh = new System.Windows.Forms.GroupBox();
            this.lblRefreshUnits = new System.Windows.Forms.Label();
            this.gbRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRefreshes
            // 
            this.cbRefreshes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRefreshes.FormattingEnabled = true;
            this.cbRefreshes.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "250",
            "500"});
            this.cbRefreshes.Location = new System.Drawing.Point(6, 19);
            this.cbRefreshes.Name = "cbRefreshes";
            this.cbRefreshes.Size = new System.Drawing.Size(62, 21);
            this.cbRefreshes.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(32, 90);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbRefresh
            // 
            this.gbRefresh.Controls.Add(this.lblRefreshUnits);
            this.gbRefresh.Controls.Add(this.cbRefreshes);
            this.gbRefresh.Location = new System.Drawing.Point(12, 12);
            this.gbRefresh.Name = "gbRefresh";
            this.gbRefresh.Size = new System.Drawing.Size(196, 57);
            this.gbRefresh.TabIndex = 4;
            this.gbRefresh.TabStop = false;
            this.gbRefresh.Text = "Refresh Interval";
            // 
            // lblRefreshUnits
            // 
            this.lblRefreshUnits.AutoSize = true;
            this.lblRefreshUnits.Location = new System.Drawing.Point(74, 22);
            this.lblRefreshUnits.Name = "lblRefreshUnits";
            this.lblRefreshUnits.Size = new System.Drawing.Size(63, 13);
            this.lblRefreshUnits.TabIndex = 2;
            this.lblRefreshUnits.Text = "milliseconds";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 125);
            this.Controls.Add(this.gbRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbRefresh.ResumeLayout(false);
            this.gbRefresh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRefreshes;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbRefresh;
        private System.Windows.Forms.Label lblRefreshUnits;
    }
}