namespace Home
{
    partial class AddAccount
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.checkBoxOmni = new System.Windows.Forms.CheckBox();
            this.checkBoxEveryday = new System.Windows.Forms.CheckBox();
            this.checkBoxInvest = new System.Windows.Forms.CheckBox();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Gray;
            this.labelLogo.Location = new System.Drawing.Point(26, 35);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(189, 33);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "LLRT Bank";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(147, 188);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(142, 21);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "Customer ID:";
            // 
            // checkBoxOmni
            // 
            this.checkBoxOmni.AutoSize = true;
            this.checkBoxOmni.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOmni.Location = new System.Drawing.Point(151, 336);
            this.checkBoxOmni.Name = "checkBoxOmni";
            this.checkBoxOmni.Size = new System.Drawing.Size(84, 25);
            this.checkBoxOmni.TabIndex = 5;
            this.checkBoxOmni.Text = "Omni";
            this.checkBoxOmni.UseVisualStyleBackColor = true;
            this.checkBoxOmni.CheckedChanged += new System.EventHandler(this.checkBoxOmni_CheckedChanged);
            // 
            // checkBoxEveryday
            // 
            this.checkBoxEveryday.AutoSize = true;
            this.checkBoxEveryday.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEveryday.Location = new System.Drawing.Point(370, 336);
            this.checkBoxEveryday.Name = "checkBoxEveryday";
            this.checkBoxEveryday.Size = new System.Drawing.Size(133, 25);
            this.checkBoxEveryday.TabIndex = 6;
            this.checkBoxEveryday.Text = "Everyday";
            this.checkBoxEveryday.UseVisualStyleBackColor = true;
            this.checkBoxEveryday.CheckedChanged += new System.EventHandler(this.checkBoxEveryday_CheckedChanged);
            // 
            // checkBoxInvest
            // 
            this.checkBoxInvest.AutoSize = true;
            this.checkBoxInvest.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvest.Location = new System.Drawing.Point(608, 336);
            this.checkBoxInvest.Name = "checkBoxInvest";
            this.checkBoxInvest.Size = new System.Drawing.Size(151, 25);
            this.checkBoxInvest.TabIndex = 7;
            this.checkBoxInvest.Text = "Investment";
            this.checkBoxInvest.UseVisualStyleBackColor = true;
            this.checkBoxInvest.CheckedChanged += new System.EventHandler(this.checkBoxInvest_CheckedChanged);
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountType.Location = new System.Drawing.Point(325, 278);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(229, 21);
            this.labelAccountType.TabIndex = 8;
            this.labelAccountType.Text = "Select Account Type:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(55, 587);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 44);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAccount.Location = new System.Drawing.Point(360, 435);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(164, 70);
            this.buttonAddAccount.TabIndex = 10;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(434, 44);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(233, 24);
            this.labelAdd.TabIndex = 13;
            this.labelAdd.Text = "Add New Account";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(370, 188);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(406, 22);
            this.textBoxCustID.TabIndex = 14;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(438, 127);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 17);
            this.labelError.TabIndex = 15;
            this.labelError.Text = "label1";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(864, 672);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonAddAccount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAccountType);
            this.Controls.Add(this.checkBoxInvest);
            this.Controls.Add(this.checkBoxEveryday);
            this.Controls.Add(this.checkBoxOmni);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelLogo);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.CheckBox checkBoxOmni;
        private System.Windows.Forms.CheckBox checkBoxEveryday;
        private System.Windows.Forms.CheckBox checkBoxInvest;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label labelError;
    }
}