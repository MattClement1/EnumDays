namespace EnumDays
{
    partial class frmEnumDays
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstDays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(11, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(218, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Click on the current day of the week:";
            // 
            // lstDays
            // 
            this.lstDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDays.FormattingEnabled = true;
            this.lstDays.ItemHeight = 16;
            this.lstDays.Location = new System.Drawing.Point(60, 30);
            this.lstDays.Name = "lstDays";
            this.lstDays.Size = new System.Drawing.Size(120, 132);
            this.lstDays.TabIndex = 1;
            this.lstDays.SelectedIndexChanged += new System.EventHandler(this.lstDays_SelectedIndexChanged);
            // 
            // frmEnumDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 194);
            this.Controls.Add(this.lstDays);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmEnumDays";
            this.Text = "Days of the Week";
            this.Load += new System.EventHandler(this.frmEnumDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ListBox lstDays;
    }
}

