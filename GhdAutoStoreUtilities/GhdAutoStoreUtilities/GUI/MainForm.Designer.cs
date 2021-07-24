namespace GhdAutoStoreUtilities.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.synqFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.asFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.missingBinFinderControl1 = new GhdAutoStoreUtilities.GUI.MissingBinFinderControl();
            this.SuspendLayout();
            // 
            // synqFileDialog
            // 
            this.synqFileDialog.Filter = "Excel Files|*.xlsx";
            // 
            // asFileDialog
            // 
            this.asFileDialog.Filter = "CSV Files|*.csv";
            // 
            // missingBinFinderControl1
            // 
            this.missingBinFinderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingBinFinderControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingBinFinderControl1.Location = new System.Drawing.Point(0, 0);
            this.missingBinFinderControl1.Margin = new System.Windows.Forms.Padding(4);
            this.missingBinFinderControl1.Name = "missingBinFinderControl1";
            this.missingBinFinderControl1.Size = new System.Drawing.Size(556, 238);
            this.missingBinFinderControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 238);
            this.Controls.Add(this.missingBinFinderControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missing Bin Finder";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog synqFileDialog;
        private System.Windows.Forms.OpenFileDialog asFileDialog;
        private MissingBinFinderControl missingBinFinderControl1;
    }
}

