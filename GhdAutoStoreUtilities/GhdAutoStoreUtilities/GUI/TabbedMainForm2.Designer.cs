
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
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.missingBinsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.binID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.synqLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.asFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.compareButton = new System.Windows.Forms.Button();
            this.synqFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.OuterTablePanel.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterTablePanel
            // 
            this.OuterTablePanel.ColumnCount = 1;
            this.OuterTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OuterTablePanel.Controls.Add(this.ResultsGroupBox, 0, 1);
            this.OuterTablePanel.Controls.Add(this.groupBox1, 0, 0);
            this.OuterTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuterTablePanel.Location = new System.Drawing.Point(0, 0);
            this.OuterTablePanel.Name = "OuterTablePanel";
            this.OuterTablePanel.Padding = new System.Windows.Forms.Padding(10);
            this.OuterTablePanel.RowCount = 2;
            this.OuterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.OuterTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.OuterTablePanel.Size = new System.Drawing.Size(435, 444);
            this.OuterTablePanel.TabIndex = 0;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.tabControl1);
            this.ResultsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsGroupBox.Location = new System.Drawing.Point(13, 203);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.ResultsGroupBox.Size = new System.Drawing.Size(409, 228);
            this.ResultsGroupBox.TabIndex = 3;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 203);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Missing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.missingBinsTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 145);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // missingBinsTextBox
            // 
            this.missingBinsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingBinsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingBinsTextBox.Location = new System.Drawing.Point(5, 35);
            this.missingBinsTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
            this.missingBinsTextBox.Multiline = true;
            this.missingBinsTextBox.Name = "missingBinsTextBox";
            this.missingBinsTextBox.ReadOnly = true;
            this.missingBinsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.missingBinsTextBox.Size = new System.Drawing.Size(366, 100);
            this.missingBinsTextBox.TabIndex = 100;
            this.missingBinsTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 10, 7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Missing AutoStore bins:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mismatched locations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.binID,
            this.synqLocation,
            this.asLocation});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 166);
            this.listView1.TabIndex = 1;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // binID
            // 
            this.binID.Text = "Bin ID";
            this.binID.Width = 91;
            // 
            // synqLocation
            // 
            this.synqLocation.Text = "Synq Location";
            this.synqLocation.Width = 139;
            // 
            // asLocation
            // 
            this.asLocation.Text = "AS Location";
            this.asLocation.Width = 151;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.asFileSelector, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.compareButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.synqFileSelector, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(403, 163);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // asFileSelector
            // 
            this.asFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.asFileSelector.ButtonText = "Select AS data";
            this.asFileSelector.FileType = "CSV Files|*.csv";
            this.asFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asFileSelector.Location = new System.Drawing.Point(7, 64);
            this.asFileSelector.Margin = new System.Windows.Forms.Padding(7);
            this.asFileSelector.Name = "asFileSelector";
            this.asFileSelector.Size = new System.Drawing.Size(296, 43);
            this.asFileSelector.TabIndex = 4;
            // 
            // compareButton
            // 
            this.compareButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.compareButton.Enabled = false;
            this.compareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.Location = new System.Drawing.Point(108, 127);
            this.compareButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(186, 32);
            this.compareButton.TabIndex = 2;
            this.compareButton.TabStop = false;
            this.compareButton.Text = "Analyze";
            this.compareButton.UseVisualStyleBackColor = true;
            // 
            // synqFileSelector
            // 
            this.synqFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.synqFileSelector.ButtonText = "Select SynQ data";
            this.synqFileSelector.FileType = "Excel Files|*.xlsx";
            this.synqFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synqFileSelector.Location = new System.Drawing.Point(7, 7);
            this.synqFileSelector.Margin = new System.Windows.Forms.Padding(7);
            this.synqFileSelector.Name = "synqFileSelector";
            this.synqFileSelector.Size = new System.Drawing.Size(296, 43);
            this.synqFileSelector.TabIndex = 3;
            // 
            // TabbedMainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 444);
            this.Controls.Add(this.OuterTablePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabbedMainForm2";
            this.Text = "TabbedMainForm2";
            this.OuterTablePanel.ResumeLayout(false);
            this.ResultsGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OuterTablePanel;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox missingBinsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader binID;
        private System.Windows.Forms.ColumnHeader synqLocation;
        private System.Windows.Forms.ColumnHeader asLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FileSelector asFileSelector;
        private System.Windows.Forms.Button compareButton;
        private FileSelector synqFileSelector;
    }
}