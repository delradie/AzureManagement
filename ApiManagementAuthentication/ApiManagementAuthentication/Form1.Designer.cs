namespace ApiManagementAuthentication
{
    partial class Form1
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
            this.LTenant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBTenant = new System.Windows.Forms.TextBox();
            this.TBBearerToken = new System.Windows.Forms.TextBox();
            this.TBClientKey = new System.Windows.Forms.TextBox();
            this.TBClientId = new System.Windows.Forms.TextBox();
            this.BGetToken = new System.Windows.Forms.Button();
            this.TBResourceGroup = new System.Windows.Forms.TextBox();
            this.TBServiceName = new System.Windows.Forms.TextBox();
            this.TBSubscriptionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBAuthentication = new System.Windows.Forms.GroupBox();
            this.GBApiManagement = new System.Windows.Forms.GroupBox();
            this.BGetSubscriptions = new System.Windows.Forms.Button();
            this.DGVSubscriptions = new System.Windows.Forms.DataGridView();
            this.GBAuthentication.SuspendLayout();
            this.GBApiManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // LTenant
            // 
            this.LTenant.AutoSize = true;
            this.LTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTenant.Location = new System.Drawing.Point(6, 22);
            this.LTenant.Name = "LTenant";
            this.LTenant.Size = new System.Drawing.Size(200, 13);
            this.LTenant.TabIndex = 0;
            this.LTenant.Text = "Active Directory Tenant (Domain):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active Directory App ClientKey:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active Directory App ClientId:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Generated Active Directory Token:";
            // 
            // TBTenant
            // 
            this.TBTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTenant.Location = new System.Drawing.Point(214, 19);
            this.TBTenant.Name = "TBTenant";
            this.TBTenant.Size = new System.Drawing.Size(380, 20);
            this.TBTenant.TabIndex = 4;
            this.TBTenant.TextChanged += new System.EventHandler(this.CheckAuthenticationInputs);
            // 
            // TBBearerToken
            // 
            this.TBBearerToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBBearerToken.Location = new System.Drawing.Point(214, 126);
            this.TBBearerToken.Name = "TBBearerToken";
            this.TBBearerToken.ReadOnly = true;
            this.TBBearerToken.Size = new System.Drawing.Size(380, 20);
            this.TBBearerToken.TabIndex = 5;
            // 
            // TBClientKey
            // 
            this.TBClientKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBClientKey.Location = new System.Drawing.Point(214, 71);
            this.TBClientKey.Name = "TBClientKey";
            this.TBClientKey.Size = new System.Drawing.Size(380, 20);
            this.TBClientKey.TabIndex = 6;
            this.TBClientKey.TextChanged += new System.EventHandler(this.CheckAuthenticationInputs);
            // 
            // TBClientId
            // 
            this.TBClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBClientId.Location = new System.Drawing.Point(214, 45);
            this.TBClientId.Name = "TBClientId";
            this.TBClientId.Size = new System.Drawing.Size(380, 20);
            this.TBClientId.TabIndex = 7;
            this.TBClientId.TextChanged += new System.EventHandler(this.CheckAuthenticationInputs);
            // 
            // BGetToken
            // 
            this.BGetToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BGetToken.Enabled = false;
            this.BGetToken.Location = new System.Drawing.Point(10, 97);
            this.BGetToken.Name = "BGetToken";
            this.BGetToken.Size = new System.Drawing.Size(584, 23);
            this.BGetToken.TabIndex = 8;
            this.BGetToken.Text = "Get Token";
            this.BGetToken.UseVisualStyleBackColor = true;
            this.BGetToken.Click += new System.EventHandler(this.BGetToken_Click);
            // 
            // TBResourceGroup
            // 
            this.TBResourceGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBResourceGroup.Location = new System.Drawing.Point(219, 39);
            this.TBResourceGroup.Name = "TBResourceGroup";
            this.TBResourceGroup.Size = new System.Drawing.Size(375, 20);
            this.TBResourceGroup.TabIndex = 14;
            // 
            // TBServiceName
            // 
            this.TBServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBServiceName.Location = new System.Drawing.Point(219, 65);
            this.TBServiceName.Name = "TBServiceName";
            this.TBServiceName.Size = new System.Drawing.Size(375, 20);
            this.TBServiceName.TabIndex = 13;
            // 
            // TBSubscriptionId
            // 
            this.TBSubscriptionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSubscriptionId.Location = new System.Drawing.Point(219, 13);
            this.TBSubscriptionId.Name = "TBSubscriptionId";
            this.TBSubscriptionId.Size = new System.Drawing.Size(375, 20);
            this.TBSubscriptionId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Azure Resource Group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "API Management Service Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Azure Subscription ID:";
            // 
            // GBAuthentication
            // 
            this.GBAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBAuthentication.Controls.Add(this.LTenant);
            this.GBAuthentication.Controls.Add(this.label2);
            this.GBAuthentication.Controls.Add(this.label3);
            this.GBAuthentication.Controls.Add(this.label4);
            this.GBAuthentication.Controls.Add(this.TBTenant);
            this.GBAuthentication.Controls.Add(this.TBBearerToken);
            this.GBAuthentication.Controls.Add(this.TBClientKey);
            this.GBAuthentication.Controls.Add(this.BGetToken);
            this.GBAuthentication.Controls.Add(this.TBClientId);
            this.GBAuthentication.Location = new System.Drawing.Point(12, 12);
            this.GBAuthentication.Name = "GBAuthentication";
            this.GBAuthentication.Size = new System.Drawing.Size(600, 162);
            this.GBAuthentication.TabIndex = 15;
            this.GBAuthentication.TabStop = false;
            this.GBAuthentication.Text = "Active Directory Authentication";
            // 
            // GBApiManagement
            // 
            this.GBApiManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBApiManagement.Controls.Add(this.DGVSubscriptions);
            this.GBApiManagement.Controls.Add(this.BGetSubscriptions);
            this.GBApiManagement.Controls.Add(this.label6);
            this.GBApiManagement.Controls.Add(this.label5);
            this.GBApiManagement.Controls.Add(this.TBResourceGroup);
            this.GBApiManagement.Controls.Add(this.label1);
            this.GBApiManagement.Controls.Add(this.TBServiceName);
            this.GBApiManagement.Controls.Add(this.TBSubscriptionId);
            this.GBApiManagement.Enabled = false;
            this.GBApiManagement.Location = new System.Drawing.Point(12, 180);
            this.GBApiManagement.Name = "GBApiManagement";
            this.GBApiManagement.Size = new System.Drawing.Size(600, 289);
            this.GBApiManagement.TabIndex = 16;
            this.GBApiManagement.TabStop = false;
            this.GBApiManagement.Text = "API Management";
            // 
            // BGetSubscriptions
            // 
            this.BGetSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BGetSubscriptions.Location = new System.Drawing.Point(10, 91);
            this.BGetSubscriptions.Name = "BGetSubscriptions";
            this.BGetSubscriptions.Size = new System.Drawing.Size(584, 23);
            this.BGetSubscriptions.TabIndex = 15;
            this.BGetSubscriptions.Text = "Get Subscriptions";
            this.BGetSubscriptions.UseVisualStyleBackColor = true;
            this.BGetSubscriptions.Click += new System.EventHandler(this.BGetSubscriptions_Click);
            // 
            // DGVSubscriptions
            // 
            this.DGVSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubscriptions.Location = new System.Drawing.Point(10, 121);
            this.DGVSubscriptions.Name = "DGVSubscriptions";
            this.DGVSubscriptions.Size = new System.Drawing.Size(584, 162);
            this.DGVSubscriptions.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.GBApiManagement);
            this.Controls.Add(this.GBAuthentication);
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "Form1";
            this.Text = "API Management Sample";
            this.GBAuthentication.ResumeLayout(false);
            this.GBAuthentication.PerformLayout();
            this.GBApiManagement.ResumeLayout(false);
            this.GBApiManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBTenant;
        private System.Windows.Forms.TextBox TBBearerToken;
        private System.Windows.Forms.TextBox TBClientKey;
        private System.Windows.Forms.TextBox TBClientId;
        private System.Windows.Forms.Button BGetToken;
        private System.Windows.Forms.TextBox TBResourceGroup;
        private System.Windows.Forms.TextBox TBServiceName;
        private System.Windows.Forms.TextBox TBSubscriptionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBAuthentication;
        private System.Windows.Forms.GroupBox GBApiManagement;
        private System.Windows.Forms.Button BGetSubscriptions;
        private System.Windows.Forms.DataGridView DGVSubscriptions;
    }
}

