namespace ImageEditor
{
    partial class ProcessFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessFile));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceImagePath = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DestinationImagePath = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTotalRowCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSourceLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinationLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editorProgress1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnColourPicker = new System.Windows.Forms.Button();
            this.chkNoColour = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.OPrice,
            this.DPrice,
            this.Status,
            this.SourceImagePath,
            this.DestinationImagePath});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(194, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ToolTipText = "Product Code";
            // 
            // OPrice
            // 
            this.OPrice.DataPropertyName = "OPrice";
            this.OPrice.HeaderText = "Original Price";
            this.OPrice.Name = "OPrice";
            // 
            // DPrice
            // 
            this.DPrice.DataPropertyName = "DPrice";
            this.DPrice.HeaderText = "Discount Price";
            this.DPrice.Name = "DPrice";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ToolTipText = "Status";
            this.Status.Width = 75;
            // 
            // SourceImagePath
            // 
            this.SourceImagePath.HeaderText = "Source Path";
            this.SourceImagePath.Name = "SourceImagePath";
            this.SourceImagePath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SourceImagePath.Text = "View";
            this.SourceImagePath.ToolTipText = "View Source Folder";
            this.SourceImagePath.UseColumnTextForButtonValue = true;
            // 
            // DestinationImagePath
            // 
            this.DestinationImagePath.HeaderText = "Destination Path";
            this.DestinationImagePath.Name = "DestinationImagePath";
            this.DestinationImagePath.Text = "View";
            this.DestinationImagePath.ToolTipText = "View Destination Folder";
            this.DestinationImagePath.UseColumnTextForButtonValue = true;
            // 
            // lblTotalRowCount
            // 
            this.lblTotalRowCount.AutoSize = true;
            this.lblTotalRowCount.Location = new System.Drawing.Point(194, 248);
            this.lblTotalRowCount.Name = "lblTotalRowCount";
            this.lblTotalRowCount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalRowCount.TabIndex = 29;
            this.lblTotalRowCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Powered By SHLOKLABS";
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(194, 29);
            this.txtLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(574, 23);
            this.txtLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datasource";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.FlatAppearance.BorderSize = 2;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(465, 166);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(147, 37);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "   Convert";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcessClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(620, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "  Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSourceLink
            // 
            this.txtSourceLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSourceLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceLink.Location = new System.Drawing.Point(194, 75);
            this.txtSourceLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtSourceLink.Name = "txtSourceLink";
            this.txtSourceLink.ReadOnly = true;
            this.txtSourceLink.Size = new System.Drawing.Size(575, 23);
            this.txtSourceLink.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Source Path";
            // 
            // txtDestinationLink
            // 
            this.txtDestinationLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDestinationLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationLink.Location = new System.Drawing.Point(194, 121);
            this.txtDestinationLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtDestinationLink.Name = "txtDestinationLink";
            this.txtDestinationLink.ReadOnly = true;
            this.txtDestinationLink.Size = new System.Drawing.Size(575, 23);
            this.txtDestinationLink.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Destination Path";
            // 
            // editorProgress1
            // 
            this.editorProgress1.BackColor = System.Drawing.SystemColors.Control;
            this.editorProgress1.Location = new System.Drawing.Point(194, 220);
            this.editorProgress1.Name = "editorProgress1";
            this.editorProgress1.Size = new System.Drawing.Size(575, 23);
            this.editorProgress1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(775, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(776, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnBrowseSourcePath);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(775, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnBrowseDestinationPath);
            // 
            // btnColourPicker
            // 
            this.btnColourPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColourPicker.FlatAppearance.BorderSize = 2;
            this.btnColourPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColourPicker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColourPicker.Location = new System.Drawing.Point(193, 166);
            this.btnColourPicker.Margin = new System.Windows.Forms.Padding(5);
            this.btnColourPicker.Name = "btnColourPicker";
            this.btnColourPicker.Size = new System.Drawing.Size(196, 37);
            this.btnColourPicker.TabIndex = 4;
            this.btnColourPicker.Text = "Color Picker";
            this.btnColourPicker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColourPicker.UseVisualStyleBackColor = true;
            this.btnColourPicker.Visible = false;
            this.btnColourPicker.Click += new System.EventHandler(this.btnColorDialog);
            // 
            // chkNoColour
            // 
            this.chkNoColour.AutoSize = true;
            this.chkNoColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkNoColour.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoColour.Location = new System.Drawing.Point(200, 173);
            this.chkNoColour.Name = "chkNoColour";
            this.chkNoColour.Size = new System.Drawing.Size(88, 24);
            this.chkNoColour.TabIndex = 28;
            this.chkNoColour.Text = "No Color";
            this.chkNoColour.UseVisualStyleBackColor = false;
            this.chkNoColour.Visible = false;
            this.chkNoColour.CheckedChanged += new System.EventHandler(this.chk_NoColorChecked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 423);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 47);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // ProcessFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 471);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRowCount);
            this.Controls.Add(this.chkNoColour);
            this.Controls.Add(this.btnColourPicker);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editorProgress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestinationLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSourceLink);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frshly\'s Image Stitcher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTotalRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSourceLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinationLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar editorProgress1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnColourPicker;
        private System.Windows.Forms.CheckBox chkNoColour;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn SourceImagePath;
        private System.Windows.Forms.DataGridViewButtonColumn DestinationImagePath;
    }
}

