
namespace GhdAutoStoreUtilities.GUI
{
    partial class TabbedMainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.missingBinFinderControl1 = new GhdAutoStoreUtilities.GUI.MissingBinFinderControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mismatchedBinFinderControl1 = new AutoStoreMissingBinFinder.GUI.MismatchedBinFinderControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.missingBinFinderControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find missing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // missingBinFinderControl1
            // 
            this.missingBinFinderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingBinFinderControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingBinFinderControl1.Location = new System.Drawing.Point(3, 3);
            this.missingBinFinderControl1.Margin = new System.Windows.Forms.Padding(4);
            this.missingBinFinderControl1.Name = "missingBinFinderControl1";
            this.missingBinFinderControl1.Size = new System.Drawing.Size(519, 262);
            this.missingBinFinderControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mismatchedBinFinderControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find mismatched locations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mismatchedBinFinderControl1
            // 
            this.mismatchedBinFinderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mismatchedBinFinderControl1.Location = new System.Drawing.Point(3, 3);
            this.mismatchedBinFinderControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mismatchedBinFinderControl1.Name = "mismatchedBinFinderControl1";
            this.mismatchedBinFinderControl1.Size = new System.Drawing.Size(519, 262);
            this.mismatchedBinFinderControl1.TabIndex = 0;
            // 
            // TabbedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 327);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabbedMainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "TabbedMainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MissingBinFinderControl missingBinFinderControl1;
        private AutoStoreMissingBinFinder.GUI.MismatchedBinFinderControl mismatchedBinFinderControl1;
    }
}