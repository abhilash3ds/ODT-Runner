namespace ODT_Runner
{
    partial class FormODTRunner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_OdtList = new System.Windows.Forms.TextBox();
            this.btn_browseOdtList = new System.Windows.Forms.Button();
            this.cb_withBsf = new System.Windows.Forms.CheckBox();
            this.cb_OdtJobs = new System.Windows.Forms.CheckBox();
            this.lbl_noOfJobs = new System.Windows.Forms.Label();
            this.tb_noOfOdts = new System.Windows.Forms.TextBox();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_scmPath = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.btn_browseOutputPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_OdtList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_browseOdtList, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_withBsf, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_OdtJobs, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_noOfJobs, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_noOfOdts, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_Level, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_scmPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_outputPath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_browseOutputPath, 5, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1377, 482);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ODT List";
            // 
            // tb_OdtList
            // 
            this.tb_OdtList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_OdtList, 4);
            this.tb_OdtList.Location = new System.Drawing.Point(232, 32);
            this.tb_OdtList.Name = "tb_OdtList";
            this.tb_OdtList.Size = new System.Drawing.Size(910, 32);
            this.tb_OdtList.TabIndex = 0;
            // 
            // btn_browseOdtList
            // 
            this.btn_browseOdtList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_browseOdtList.Location = new System.Drawing.Point(1148, 22);
            this.btn_browseOdtList.Name = "btn_browseOdtList";
            this.btn_browseOdtList.Size = new System.Drawing.Size(152, 51);
            this.btn_browseOdtList.TabIndex = 1;
            this.btn_browseOdtList.Text = "Browse";
            this.btn_browseOdtList.UseVisualStyleBackColor = true;
            this.btn_browseOdtList.Click += new System.EventHandler(this.btn_browseOdtList_Click);
            // 
            // cb_withBsf
            // 
            this.cb_withBsf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_withBsf.Location = new System.Drawing.Point(461, 125);
            this.cb_withBsf.Name = "cb_withBsf";
            this.cb_withBsf.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cb_withBsf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_withBsf.Size = new System.Drawing.Size(223, 38);
            this.cb_withBsf.TabIndex = 4;
            this.cb_withBsf.Text = "With BSF";
            this.cb_withBsf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_withBsf.UseVisualStyleBackColor = true;
            this.cb_withBsf.CheckStateChanged += new System.EventHandler(this.cb_withBsf_CheckStateChanged);
            // 
            // cb_OdtJobs
            // 
            this.cb_OdtJobs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_OdtJobs.Location = new System.Drawing.Point(690, 125);
            this.cb_OdtJobs.Name = "cb_OdtJobs";
            this.cb_OdtJobs.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cb_OdtJobs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_OdtJobs.Size = new System.Drawing.Size(223, 38);
            this.cb_OdtJobs.TabIndex = 5;
            this.cb_OdtJobs.Text = "ODT Jobs";
            this.cb_OdtJobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_OdtJobs.UseVisualStyleBackColor = true;
            this.cb_OdtJobs.CheckStateChanged += new System.EventHandler(this.cb_OdtJobs_CheckStateChanged);
            // 
            // lbl_noOfJobs
            // 
            this.lbl_noOfJobs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_noOfJobs.AutoSize = true;
            this.lbl_noOfJobs.Location = new System.Drawing.Point(1038, 131);
            this.lbl_noOfJobs.Name = "lbl_noOfJobs";
            this.lbl_noOfJobs.Size = new System.Drawing.Size(104, 25);
            this.lbl_noOfJobs.TabIndex = 6;
            this.lbl_noOfJobs.Text = "No Of Jobs";
            // 
            // tb_noOfOdts
            // 
            this.tb_noOfOdts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_noOfOdts.Location = new System.Drawing.Point(1148, 128);
            this.tb_noOfOdts.Name = "tb_noOfOdts";
            this.tb_noOfOdts.Size = new System.Drawing.Size(135, 32);
            this.tb_noOfOdts.TabIndex = 7;
            this.tb_noOfOdts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_noOfOdts_KeyPress);
            // 
            // cb_Level
            // 
            this.cb_Level.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Items.AddRange(new object[] {
            "R425",
            "R424",
            "R423",
            "R422",
            "R421"});
            this.cb_Level.Location = new System.Drawing.Point(232, 127);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(193, 33);
            this.cb_Level.TabIndex = 3;
            this.cb_Level.SelectedIndexChanged += new System.EventHandler(this.cb_Level_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SCM Path";
            // 
            // cb_scmPath
            // 
            this.cb_scmPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_scmPath, 4);
            this.cb_scmPath.FormattingEnabled = true;
            this.cb_scmPath.Location = new System.Drawing.Point(232, 228);
            this.cb_scmPath.Name = "cb_scmPath";
            this.cb_scmPath.Size = new System.Drawing.Size(910, 33);
            this.cb_scmPath.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "SCM Path";
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_outputPath, 4);
            this.tb_outputPath.Location = new System.Drawing.Point(232, 320);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.Size = new System.Drawing.Size(910, 32);
            this.tb_outputPath.TabIndex = 13;
            // 
            // btn_browseOutputPath
            // 
            this.btn_browseOutputPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_browseOutputPath.Location = new System.Drawing.Point(1148, 310);
            this.btn_browseOutputPath.Name = "btn_browseOutputPath";
            this.btn_browseOutputPath.Size = new System.Drawing.Size(152, 51);
            this.btn_browseOutputPath.TabIndex = 14;
            this.btn_browseOutputPath.Text = "Browse";
            this.btn_browseOutputPath.UseVisualStyleBackColor = true;
            this.btn_browseOutputPath.Click += new System.EventHandler(this.btn_browseOutputPath_Click);
            // 
            // FormODTRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormODTRunner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODT Runner";
            this.Load += new System.EventHandler(this.FormODTRunner_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tb_OdtList;
        private Button btn_browseOdtList;
        private Label label2;
        private ComboBox cb_Level;
        private CheckBox cb_withBsf;
        private CheckBox cb_OdtJobs;
        private Label lbl_noOfJobs;
        private TextBox tb_noOfOdts;
        private Label label3;
        private ComboBox cb_scmPath;
        private Label label4;
        private TextBox tb_outputPath;
        private Button btn_browseOutputPath;
    }
}