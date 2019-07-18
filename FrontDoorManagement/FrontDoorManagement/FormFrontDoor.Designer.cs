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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlAreas.SuspendLayout();
            this.tabPageFrontDoors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontDoors)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAreas
            // 
            this.tabControlAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAreas.Controls.Add(this.tabPageFrontDoors);
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
            // FormFrontDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAreas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFrontDoor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlAreas.ResumeLayout(false);
            this.tabPageFrontDoors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrontDoors)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

