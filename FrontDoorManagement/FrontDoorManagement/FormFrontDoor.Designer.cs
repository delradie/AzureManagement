namespace FrontDoorManagement
{
    partial class FormFrontDoor
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
            this.tabControlAreas = new System.Windows.Forms.TabControl();
            this.tabPageFrontDoors = new System.Windows.Forms.TabPage();
            this.dataGridViewFrontDoors = new System.Windows.Forms.DataGridView();
            this.buttonLoadFrontDoors = new System.Windows.Forms.Button();
            this.tabPageFrontEnds = new System.Windows.Forms.TabPage();
            this.dataGridViewFrontEnds = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerFE = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerFE2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBackEnds = new System.Windows.Forms.DataGridView();
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.tabControlAreas.SuspendLayout();
            this.tabPageFrontDoors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontDoors)).BeginInit();
            this.tabPageFrontEnds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontEnds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFE)).BeginInit();
            this.splitContainerFE.Panel1.SuspendLayout();
            this.splitContainerFE.Panel2.SuspendLayout();
            this.splitContainerFE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFE2)).BeginInit();
            this.splitContainerFE2.Panel1.SuspendLayout();
            this.splitContainerFE2.Panel2.SuspendLayout();
            this.splitContainerFE2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackEnds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAreas
            // 
            this.tabControlAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAreas.Controls.Add(this.tabPageFrontDoors);
            this.tabControlAreas.Controls.Add(this.tabPageFrontEnds);
            this.tabControlAreas.Enabled = false;
            this.tabControlAreas.Location = new System.Drawing.Point(0, 29);
            this.tabControlAreas.Name = "tabControlAreas";
            this.tabControlAreas.SelectedIndex = 0;
            this.tabControlAreas.Size = new System.Drawing.Size(800, 421);
            this.tabControlAreas.TabIndex = 0;
            // 
            // tabPageFrontDoors
            // 
            this.tabPageFrontDoors.Controls.Add(this.dataGridViewFrontDoors);
            this.tabPageFrontDoors.Controls.Add(this.buttonLoadFrontDoors);
            this.tabPageFrontDoors.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrontDoors.Name = "tabPageFrontDoors";
            this.tabPageFrontDoors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrontDoors.Size = new System.Drawing.Size(792, 395);
            this.tabPageFrontDoors.TabIndex = 0;
            this.tabPageFrontDoors.Text = "Front Doors";
            this.tabPageFrontDoors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFrontDoors
            // 
            this.dataGridViewFrontDoors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFrontDoors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrontDoors.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewFrontDoors.Name = "dataGridViewFrontDoors";
            this.dataGridViewFrontDoors.Size = new System.Drawing.Size(776, 352);
            this.dataGridViewFrontDoors.TabIndex = 1;
            this.dataGridViewFrontDoors.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewFrontDoors_CellMouseDoubleClick);
            // 
            // buttonLoadFrontDoors
            // 
            this.buttonLoadFrontDoors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadFrontDoors.Location = new System.Drawing.Point(709, 364);
            this.buttonLoadFrontDoors.Name = "buttonLoadFrontDoors";
            this.buttonLoadFrontDoors.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFrontDoors.TabIndex = 0;
            this.buttonLoadFrontDoors.Text = "Load";
            this.buttonLoadFrontDoors.UseVisualStyleBackColor = true;
            this.buttonLoadFrontDoors.Click += new System.EventHandler(this.buttonLoadFrontDoors_Click);
            // 
            // tabPageFrontEnds
            // 
            this.tabPageFrontEnds.Controls.Add(this.splitContainerFE);
            this.tabPageFrontEnds.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrontEnds.Name = "tabPageFrontEnds";
            this.tabPageFrontEnds.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrontEnds.Size = new System.Drawing.Size(792, 395);
            this.tabPageFrontEnds.TabIndex = 1;
            this.tabPageFrontEnds.Text = "Config";
            this.tabPageFrontEnds.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFrontEnds
            // 
            this.dataGridViewFrontEnds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFrontEnds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFrontEnds.Location = new System.Drawing.Point(9, 20);
            this.dataGridViewFrontEnds.Name = "dataGridViewFrontEnds";
            this.dataGridViewFrontEnds.Size = new System.Drawing.Size(772, 62);
            this.dataGridViewFrontEnds.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // splitContainerFE
            // 
            this.splitContainerFE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFE.Location = new System.Drawing.Point(3, 3);
            this.splitContainerFE.Name = "splitContainerFE";
            this.splitContainerFE.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFE.Panel1
            // 
            this.splitContainerFE.Panel1.Controls.Add(this.label1);
            this.splitContainerFE.Panel1.Controls.Add(this.dataGridViewFrontEnds);
            // 
            // splitContainerFE.Panel2
            // 
            this.splitContainerFE.Panel2.Controls.Add(this.splitContainerFE2);
            this.splitContainerFE.Size = new System.Drawing.Size(786, 389);
            this.splitContainerFE.SplitterDistance = 85;
            this.splitContainerFE.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Front Ends";
            // 
            // splitContainerFE2
            // 
            this.splitContainerFE2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFE2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFE2.Name = "splitContainerFE2";
            this.splitContainerFE2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFE2.Panel1
            // 
            this.splitContainerFE2.Panel1.Controls.Add(this.dataGridViewBackEnds);
            this.splitContainerFE2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainerFE2.Panel2
            // 
            this.splitContainerFE2.Panel2.Controls.Add(this.dataGridViewRules);
            this.splitContainerFE2.Panel2.Controls.Add(this.label3);
            this.splitContainerFE2.Size = new System.Drawing.Size(786, 300);
            this.splitContainerFE2.SplitterDistance = 141;
            this.splitContainerFE2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Back Ends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rules";
            // 
            // dataGridViewBackEnds
            // 
            this.dataGridViewBackEnds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBackEnds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackEnds.Location = new System.Drawing.Point(9, 26);
            this.dataGridViewBackEnds.Name = "dataGridViewBackEnds";
            this.dataGridViewBackEnds.Size = new System.Drawing.Size(772, 112);
            this.dataGridViewBackEnds.TabIndex = 1;
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.dataGridViewRules.Size = new System.Drawing.Size(772, 125);
            this.dataGridViewRules.TabIndex = 1;
            // 
            // FormFrontDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAreas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFrontDoor";
            this.Text = "Azure Front Door Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlAreas.ResumeLayout(false);
            this.tabPageFrontDoors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontDoors)).EndInit();
            this.tabPageFrontEnds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontEnds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerFE.Panel1.ResumeLayout(false);
            this.splitContainerFE.Panel1.PerformLayout();
            this.splitContainerFE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFE)).EndInit();
            this.splitContainerFE.ResumeLayout(false);
            this.splitContainerFE2.Panel1.ResumeLayout(false);
            this.splitContainerFE2.Panel1.PerformLayout();
            this.splitContainerFE2.Panel2.ResumeLayout(false);
            this.splitContainerFE2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFE2)).EndInit();
            this.splitContainerFE2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackEnds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAreas;
        private System.Windows.Forms.TabPage tabPageFrontDoors;
        private System.Windows.Forms.Button buttonLoadFrontDoors;
        private System.Windows.Forms.DataGridView dataGridViewFrontDoors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageFrontEnds;
        private System.Windows.Forms.DataGridView dataGridViewFrontEnds;
        private System.Windows.Forms.SplitContainer splitContainerFE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainerFE2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBackEnds;
        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.Label label3;
    }
}

