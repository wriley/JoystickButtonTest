namespace JoystickButtonTest
{
    partial class Button
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button));
            this.btnStatus = new System.Windows.Forms.Label();
            this.ilButton = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStatus.ImageKey = "button_off.png";
            this.btnStatus.ImageList = this.ilButton;
            this.btnStatus.Location = new System.Drawing.Point(0, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(32, 32);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "###";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilButton
            // 
            this.ilButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButton.ImageStream")));
            this.ilButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButton.Images.SetKeyName(0, "button_off.png");
            this.ilButton.Images.SetKeyName(1, "button_on.png");
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatus);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(32, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnStatus;
        private System.Windows.Forms.ImageList ilButton;
    }
}
