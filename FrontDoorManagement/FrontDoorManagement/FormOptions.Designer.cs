namespace FrontDoorManagement
{
    partial class FormOptions
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
            this.textBoxSubscription = new System.Windows.Forms.TextBox();
            this.labelSubscription = new System.Windows.Forms.Label();
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.textBoxAadTenant = new System.Windows.Forms.TextBox();
            this.labelAadTenant = new System.Windows.Forms.Label();
            this.textBoxClientSecret = new System.Windows.Forms.TextBox();
            this.labelClientSecret = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.radioButtonAuthServicePrincipal = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthLogIn = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthManagedIdentity = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSubscription
            // 
            this.textBoxSubscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubscription.Location = new System.Drawing.Point(130, 6);
            this.textBoxSubscription.Name = "textBoxSubscription";
            this.textBoxSubscription.Size = new System.Drawing.Size(393, 20);
            this.textBoxSubscription.TabIndex = 1;
            // 
            // labelSubscription
            // 
            this.labelSubscription.AutoSize = true;
            this.labelSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubscription.Location = new System.Drawing.Point(8, 9);
            this.labelSubscription.Name = "labelSubscription";
            this.labelSubscription.Size = new System.Drawing.Size(98, 13);
            this.labelSubscription.TabIndex = 3;
            this.labelSubscription.Text = "Subscription ID:";
            // 
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.textBoxAadTenant);
            this.groupBoxAuthentication.Controls.Add(this.labelAadTenant);
            this.groupBoxAuthentication.Controls.Add(this.textBoxClientSecret);
            this.groupBoxAuthentication.Controls.Add(this.labelClientSecret);
            this.groupBoxAuthentication.Controls.Add(this.textBoxClientId);
            this.groupBoxAuthentication.Controls.Add(this.labelClientId);
            this.groupBoxAuthentication.Controls.Add(this.radioButtonAuthServicePrincipal);
            this.groupBoxAuthentication.Controls.Add(this.radioButtonAuthLogIn);
            this.groupBoxAuthentication.Controls.Add(this.radioButtonAuthManagedIdentity);
            this.groupBoxAuthentication.Location = new System.Drawing.Point(11, 32);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(512, 176);
            this.groupBoxAuthentication.TabIndex = 6;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // textBoxAadTenant
            // 
            this.textBoxAadTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAadTenant.Enabled = false;
            this.textBoxAadTenant.Location = new System.Drawing.Point(108, 94);
            this.textBoxAadTenant.Name = "textBoxAadTenant";
            this.textBoxAadTenant.Size = new System.Drawing.Size(398, 20);
            this.textBoxAadTenant.TabIndex = 3;
            // 
            // labelAadTenant
            // 
            this.labelAadTenant.AutoSize = true;
            this.labelAadTenant.Enabled = false;
            this.labelAadTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAadTenant.Location = new System.Drawing.Point(4, 97);
            this.labelAadTenant.Name = "labelAadTenant";
            this.labelAadTenant.Size = new System.Drawing.Size(80, 13);
            this.labelAadTenant.TabIndex = 9;
            this.labelAadTenant.Text = "AAD Tenant:";
            // 
            // textBoxClientSecret
            // 
            this.textBoxClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientSecret.Enabled = false;
            this.textBoxClientSecret.Location = new System.Drawing.Point(108, 146);
            this.textBoxClientSecret.Name = "textBoxClientSecret";
            this.textBoxClientSecret.Size = new System.Drawing.Size(398, 20);
            this.textBoxClientSecret.TabIndex = 5;
            // 
            // labelClientSecret
            // 
            this.labelClientSecret.AutoSize = true;
            this.labelClientSecret.Enabled = false;
            this.labelClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSecret.Location = new System.Drawing.Point(4, 149);
            this.labelClientSecret.Name = "labelClientSecret";
            this.labelClientSecret.Size = new System.Drawing.Size(84, 13);
            this.labelClientSecret.TabIndex = 7;
            this.labelClientSecret.Text = "Client Secret:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientId.Enabled = false;
            this.textBoxClientId.Location = new System.Drawing.Point(108, 120);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(398, 20);
            this.textBoxClientId.TabIndex = 4;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Enabled = false;
            this.labelClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.Location = new System.Drawing.Point(4, 123);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(60, 13);
            this.labelClientId.TabIndex = 5;
            this.labelClientId.Text = "Client ID:";
            // 
            // radioButtonAuthServicePrincipal
            // 
            this.radioButtonAuthServicePrincipal.AutoSize = true;
            this.radioButtonAuthServicePrincipal.Location = new System.Drawing.Point(7, 43);
            this.radioButtonAuthServicePrincipal.Name = "radioButtonAuthServicePrincipal";
            this.radioButtonAuthServicePrincipal.Size = new System.Drawing.Size(126, 17);
            this.radioButtonAuthServicePrincipal.TabIndex = 2;
            this.radioButtonAuthServicePrincipal.Text = "Use Service Principal";
            this.radioButtonAuthServicePrincipal.UseVisualStyleBackColor = true;
            this.radioButtonAuthServicePrincipal.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonAuthLogIn
            // 
            this.radioButtonAuthLogIn.AutoSize = true;
            this.radioButtonAuthLogIn.Location = new System.Drawing.Point(7, 66);
            this.radioButtonAuthLogIn.Name = "radioButtonAuthLogIn";
            this.radioButtonAuthLogIn.Size = new System.Drawing.Size(55, 17);
            this.radioButtonAuthLogIn.TabIndex = 2;
            this.radioButtonAuthLogIn.Text = "Log In";
            this.radioButtonAuthLogIn.UseVisualStyleBackColor = true;
            this.radioButtonAuthLogIn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonAuthManagedIdentity
            // 
            this.radioButtonAuthManagedIdentity.AutoSize = true;
            this.radioButtonAuthManagedIdentity.Checked = true;
            this.radioButtonAuthManagedIdentity.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAuthManagedIdentity.Name = "radioButtonAuthManagedIdentity";
            this.radioButtonAuthManagedIdentity.Size = new System.Drawing.Size(129, 17);
            this.radioButtonAuthManagedIdentity.TabIndex = 2;
            this.radioButtonAuthManagedIdentity.TabStop = true;
            this.radioButtonAuthManagedIdentity.Text = "Use Managed Identity";
            this.radioButtonAuthManagedIdentity.UseVisualStyleBackColor = true;
            this.radioButtonAuthManagedIdentity.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(367, 217);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(448, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 252);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxAuthentication);
            this.Controls.Add(this.textBoxSubscription);
            this.Controls.Add(this.labelSubscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.groupBoxAuthentication.ResumeLayout(false);
            this.groupBoxAuthentication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubscription;
        private System.Windows.Forms.Label labelSubscription;
        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private System.Windows.Forms.RadioButton radioButtonAuthServicePrincipal;
        private System.Windows.Forms.RadioButton radioButtonAuthLogIn;
        private System.Windows.Forms.RadioButton radioButtonAuthManagedIdentity;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox textBoxClientSecret;
        private System.Windows.Forms.Label labelClientSecret;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxAadTenant;
        private System.Windows.Forms.Label labelAadTenant;
    }
}