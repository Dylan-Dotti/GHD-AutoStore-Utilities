namespace GhdAutoStoreUtilities.GUI
{
    partial class MissingBinFinderControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.asFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.compareButton = new System.Windows.Forms.Button();
            this.synqFileSelector = new GhdAutoStoreUtilities.GUI.FileSelector();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.maxLenInput = new System.Windows.Forms.NumericUpDown();
            this.missingBinsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.53098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.46902F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 250);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.asFileSelector, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.compareButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.synqFileSelector, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(331, 210);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // asFileSelector
            // 
            this.asFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.asFileSelector.ButtonText = "Select AS data";
            this.asFileSelector.FileType = "CSV Files|*.csv";
            this.asFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asFileSelector.Location = new System.Drawing.Point(7, 79);
            this.asFileSelector.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            this.asFileSelector.Name = "asFileSelector";
            this.asFileSelector.Size = new System.Drawing.Size(317, 43);
            this.asFileSelector.TabIndex = 4;
            this.asFileSelector.SelectedFile += new System.EventHandler(this.asFileSelector_SelectedFile);
            // 
            // compareButton
            // 
            this.compareButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.compareButton.Enabled = false;
            this.compareButton.Location = new System.Drawing.Point(66, 157);
            this.compareButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(198, 40);
            this.compareButton.TabIndex = 2;
            this.compareButton.TabStop = false;
            this.compareButton.Text = "Find Missing Bins";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // synqFileSelector
            // 
            this.synqFileSelector.ButtonSize = new System.Drawing.Size(125, 35);
            this.synqFileSelector.ButtonText = "Select SynQ data";
            this.synqFileSelector.FileType = "Excel Files|*.xlsx";
            this.synqFileSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synqFileSelector.Location = new System.Drawing.Point(7, 12);
            this.synqFileSelector.Margin = new System.Windows.Forms.Padding(7, 12, 7, 12);
            this.synqFileSelector.Name = "synqFileSelector";
            this.synqFileSelector.Size = new System.Drawing.Size(317, 43);
            this.synqFileSelector.TabIndex = 3;
            this.synqFileSelector.SelectedFile += new System.EventHandler(this.synqFileSelector_SelectedFile);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.missingBinsTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(355, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 236);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.maxLenInput, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(9, 206);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(198, 30);
            this.tableLayoutPanel6.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max bin ID length:";
            // 
            // maxLenInput
            // 
            this.maxLenInput.AutoSize = true;
            this.maxLenInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLenInput.Location = new System.Drawing.Point(119, 3);
            this.maxLenInput.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.maxLenInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxLenInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxLenInput.Name = "maxLenInput";
            this.maxLenInput.Size = new System.Drawing.Size(72, 24);
            this.maxLenInput.TabIndex = 1;
            this.maxLenInput.TabStop = false;
            this.maxLenInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxLenInput.ValueChanged += new System.EventHandler(this.maxLenInput_ValueChanged);
            this.maxLenInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxLenInput_KeyDown);
            this.maxLenInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maxLenInput_KeyUp);
            this.maxLenInput.Leave += new System.EventHandler(this.maxLenInput_Leave);
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
            this.missingBinsTextBox.Size = new System.Drawing.Size(212, 161);
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
            // MissingBinFinderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MissingBinFinderControl";
            this.Size = new System.Drawing.Size(581, 250);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxLenInput;
        private System.Windows.Forms.TextBox missingBinsTextBox;
        private System.Windows.Forms.Label label1;
        private FileSelector synqFileSelector;
        private FileSelector asFileSelector;
    }
}
