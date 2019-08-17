namespace ManagementApiExecute
{
    partial class FormExecute
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BExecute = new System.Windows.Forms.Button();
            this.CBMethod = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // TBUrl
            // 
            this.TBUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUrl.Location = new System.Drawing.Point(41, 27);
            this.TBUrl.Name = "TBUrl";
            this.TBUrl.Size = new System.Drawing.Size(539, 20);
            this.TBUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url";
            // 
            // BExecute
            // 
            this.BExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BExecute.Location = new System.Drawing.Point(713, 27);
            this.BExecute.Name = "BExecute";
            this.BExecute.Size = new System.Drawing.Size(75, 23);
            this.BExecute.TabIndex = 4;
            this.BExecute.Text = "Execute";
            this.BExecute.UseVisualStyleBackColor = true;
            this.BExecute.Click += new System.EventHandler(this.BExecute_Click);
            // 
            // CBMethod
            // 
            this.CBMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMethod.FormattingEnabled = true;
            this.CBMethod.Items.AddRange(new object[] {
            "GET",
            "PUT",
            "POST",
            "DELETE"});
            this.CBMethod.Location = new System.Drawing.Point(586, 27);
            this.CBMethod.Name = "CBMethod";
            this.CBMethod.Size = new System.Drawing.Size(121, 21);
            this.CBMethod.TabIndex = 5;
            this.CBMethod.SelectedIndexChanged += new System.EventHandler(this.CBMethod_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 56);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TBInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TBOutput);
            this.splitContainer1.Size = new System.Drawing.Size(773, 382);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 6;
            // 
            // TBInput
            // 
            this.TBInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBInput.Location = new System.Drawing.Point(0, 0);
            this.TBInput.Multiline = true;
            this.TBInput.Name = "TBInput";
            this.TBInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBInput.Size = new System.Drawing.Size(773, 191);
            this.TBInput.TabIndex = 0;
            // 
            // TBOutput
            // 
            this.TBOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBOutput.Location = new System.Drawing.Point(0, 0);
            this.TBOutput.Multiline = true;
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBOutput.Size = new System.Drawing.Size(773, 187);
            this.TBOutput.TabIndex = 0;
            // 
            // FormExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CBMethod);
            this.Controls.Add(this.BExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBUrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormExecute";
            this.Text = "Management API";
            this.Load += new System.EventHandler(this.FormExecute_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox TBUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BExecute;
        private System.Windows.Forms.ComboBox CBMethod;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.TextBox TBOutput;
    }
}

