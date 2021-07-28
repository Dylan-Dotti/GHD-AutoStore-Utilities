
namespace GhdAutoStoreUtilities.GUI
{
    partial class TabbedMainForm2
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
            this.OuterTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.asFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.synqFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.tabbedResultsControl1 = new GhdAutoStoreUtilities.GUI.TabbedResultsControl();
            this.OuterTablePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterTablePanel
            // 
            this.OuterTablePanel.ColumnCount = 1;
            this.OuterTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OuterTablePanel.Controls.Add(this.groupBox1, 0, 0);
            this.OuterTablePanel.Controls.Add(this.analyzeButton, 0, 1);
            this.OuterTablePanel.Controls.Add(this.tabbedResultsControl1, 0, 2);
            this.OuterTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterTablePanel.Location = new System.Drawing.Point(0, 0);
            this.OuterTablePanel.Name = "OuterTablePanel";
            this.OuterTablePanel.Padding = new System.Windows.Forms.Padding(10);
            this.OuterTablePanel.RowCount = 3;
            this.OuterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OuterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OuterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OuterTablePanel.Size = new System.Drawing.Size(435, 456);
            this.OuterTablePanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.asFileSelector, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.synqFileSelector, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(403, 141);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // asFileSelector
            // 
            this.asFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.asFileSelector.ButtonText = "Select AS data";
            this.asFileSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asFileSelector.FileType = "CSV Files|*.csv";
            this.asFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asFileSelector.Location = new System.Drawing.Point(3, 73);
            this.asFileSelector.Name = "asFileSelector";
            this.asFileSelector.Size = new System.Drawing.Size(397, 65);
            this.asFileSelector.TabIndex = 4;
            // 
            // synqFileSelector
            // 
            this.synqFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.synqFileSelector.ButtonText = "Select SynQ data";
            this.synqFileSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synqFileSelector.FileType = "Excel Files|*.xlsx";
            this.synqFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synqFileSelector.Location = new System.Drawing.Point(3, 3);
            this.synqFileSelector.Name = "synqFileSelector";
            this.synqFileSelector.Size = new System.Drawing.Size(397, 64);
            this.synqFileSelector.TabIndex = 3;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeButton.Location = new System.Drawing.Point(124, 183);
            this.analyzeButton.Margin = new System.Windows.Forms.Padding(5);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(186, 30);
            this.analyzeButton.TabIndex = 5;
            this.analyzeButton.TabStop = false;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // tabbedResultsControl1
            // 
            this.tabbedResultsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbedResultsControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbedResultsControl1.Location = new System.Drawing.Point(14, 222);
            this.tabbedResultsControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabbedResultsControl1.Name = "tabbedResultsControl1";
            this.tabbedResultsControl1.Size = new System.Drawing.Size(407, 220);
            this.tabbedResultsControl1.TabIndex = 6;
            // 
            // TabbedMainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 456);
            this.Controls.Add(this.OuterTablePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabbedMainForm2";
            this.Text = "TabbedMainForm2";
            this.OuterTablePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OuterTablePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FileSelector asFileSelector;
        private FileSelector synqFileSelector;
        private System.Windows.Forms.Button analyzeButton;
        private TabbedResultsControl tabbedResultsControl1;
    }
}