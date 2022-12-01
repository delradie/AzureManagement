namespace LogicWorkflowManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubscriptionId = new System.Windows.Forms.TextBox();
            this.textBoxResourceGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWorkflow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthTenant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxAuthAppId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAuthAppKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxWorkflows = new System.Windows.Forms.ListBox();
            this.buttonAddWorkflow = new System.Windows.Forms.Button();
            this.buttonDeleteWorkflow = new System.Windows.Forms.Button();
            this.buttonEditWorkflow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subscription Id";
            // 
            // textBoxSubscriptionId
            // 
            this.textBoxSubscriptionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubscriptionId.Location = new System.Drawing.Point(104, 7);
            this.textBoxSubscriptionId.Name = "textBoxSubscriptionId";
            this.textBoxSubscriptionId.Size = new System.Drawing.Size(684, 23);
            this.textBoxSubscriptionId.TabIndex = 1;
            // 
            // textBoxResourceGroup
            // 
            this.textBoxResourceGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResourceGroup.Location = new System.Drawing.Point(104, 36);
            this.textBoxResourceGroup.Name = "textBoxResourceGroup";
            this.textBoxResourceGroup.Size = new System.Drawing.Size(684, 23);
            this.textBoxResourceGroup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resource Group";
            // 
            // textBoxWorkflow
            // 
            this.textBoxWorkflow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkflow.Location = new System.Drawing.Point(104, 65);
            this.textBoxWorkflow.Name = "textBoxWorkflow";
            this.textBoxWorkflow.Size = new System.Drawing.Size(684, 23);
            this.textBoxWorkflow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Workflow";
            // 
            // textBoxAuthTenant
            // 
            this.textBoxAuthTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthTenant.Location = new System.Drawing.Point(104, 94);
            this.textBoxAuthTenant.Name = "textBoxAuthTenant";
            this.textBoxAuthTenant.Size = new System.Drawing.Size(684, 23);
            this.textBoxAuthTenant.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Auth Tenant";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(104, 181);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 8;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.Location = new System.Drawing.Point(104, 210);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOut.Size = new System.Drawing.Size(684, 58);
            this.textBoxOut.TabIndex = 9;
            // 
            // textBoxAuthAppId
            // 
            this.textBoxAuthAppId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthAppId.Location = new System.Drawing.Point(104, 123);
            this.textBoxAuthAppId.Name = "textBoxAuthAppId";
            this.textBoxAuthAppId.Size = new System.Drawing.Size(684, 23);
            this.textBoxAuthAppId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Auth App Id";
            // 
            // textBoxAuthAppKey
            // 
            this.textBoxAuthAppKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthAppKey.Location = new System.Drawing.Point(104, 152);
            this.textBoxAuthAppKey.Name = "textBoxAuthAppKey";
            this.textBoxAuthAppKey.Size = new System.Drawing.Size(684, 23);
            this.textBoxAuthAppKey.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Auth App Key";
            // 
            // listBoxWorkflows
            // 
            this.listBoxWorkflows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWorkflows.FormattingEnabled = true;
            this.listBoxWorkflows.ItemHeight = 15;
            this.listBoxWorkflows.Location = new System.Drawing.Point(104, 274);
            this.listBoxWorkflows.Name = "listBoxWorkflows";
            this.listBoxWorkflows.Size = new System.Drawing.Size(684, 139);
            this.listBoxWorkflows.TabIndex = 14;
            // 
            // buttonAddWorkflow
            // 
            this.buttonAddWorkflow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddWorkflow.Location = new System.Drawing.Point(104, 415);
            this.buttonAddWorkflow.Name = "buttonAddWorkflow";
            this.buttonAddWorkflow.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWorkflow.TabIndex = 15;
            this.buttonAddWorkflow.Text = "Add";
            this.buttonAddWorkflow.UseVisualStyleBackColor = true;
            this.buttonAddWorkflow.Click += new System.EventHandler(this.buttonAddWorkflow_Click);
            // 
            // buttonDeleteWorkflow
            // 
            this.buttonDeleteWorkflow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteWorkflow.Location = new System.Drawing.Point(266, 415);
            this.buttonDeleteWorkflow.Name = "buttonDeleteWorkflow";
            this.buttonDeleteWorkflow.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWorkflow.TabIndex = 16;
            this.buttonDeleteWorkflow.Text = "Delete";
            this.buttonDeleteWorkflow.UseVisualStyleBackColor = true;
            // 
            // buttonEditWorkflow
            // 
            this.buttonEditWorkflow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditWorkflow.Location = new System.Drawing.Point(185, 415);
            this.buttonEditWorkflow.Name = "buttonEditWorkflow";
            this.buttonEditWorkflow.Size = new System.Drawing.Size(75, 23);
            this.buttonEditWorkflow.TabIndex = 17;
            this.buttonEditWorkflow.Text = "Edit";
            this.buttonEditWorkflow.UseVisualStyleBackColor = true;
            this.buttonEditWorkflow.Click += new System.EventHandler(this.buttonEditWorkflow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditWorkflow);
            this.Controls.Add(this.buttonDeleteWorkflow);
            this.Controls.Add(this.buttonAddWorkflow);
            this.Controls.Add(this.listBoxWorkflows);
            this.Controls.Add(this.textBoxAuthAppKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAuthAppId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textBoxAuthTenant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWorkflow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResourceGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubscriptionId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxSubscriptionId;
        private TextBox textBoxResourceGroup;
        private Label label2;
        private TextBox textBoxWorkflow;
        private Label label3;
        private TextBox textBoxAuthTenant;
        private Label label4;
        private Button buttonGet;
        private TextBox textBoxOut;
        private TextBox textBoxAuthAppId;
        private Label label5;
        private TextBox textBoxAuthAppKey;
        private Label label6;
        private ListBox listBoxWorkflows;
        private Button buttonAddWorkflow;
        private Button buttonDeleteWorkflow;
        private Button buttonEditWorkflow;
    }
}