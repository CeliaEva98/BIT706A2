namespace BIT706_A2_PartB
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
            this.labelError = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.checkBoxInvest = new System.Windows.Forms.CheckBox();
            this.checkBoxEveryday = new System.Windows.Forms.CheckBox();
            this.checkBoxOmni = new System.Windows.Forms.CheckBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTransactions = new System.Windows.Forms.ListBox();
            this.labelAccInfo = new System.Windows.Forms.Label();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.groupBoxAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(444, 439);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 17);
            this.labelError.TabIndex = 28;
            this.labelError.Text = "label2";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(44, 470);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(90, 17);
            this.infoLabel.TabIndex = 27;
            this.infoLabel.Text = "Account Info:";
            // 
            // groupBoxAccounts
            // 
            this.groupBoxAccounts.Controls.Add(this.checkBoxInvest);
            this.groupBoxAccounts.Controls.Add(this.checkBoxEveryday);
            this.groupBoxAccounts.Controls.Add(this.checkBoxOmni);
            this.groupBoxAccounts.Location = new System.Drawing.Point(47, 88);
            this.groupBoxAccounts.Name = "groupBoxAccounts";
            this.groupBoxAccounts.Size = new System.Drawing.Size(808, 100);
            this.groupBoxAccounts.TabIndex = 26;
            this.groupBoxAccounts.TabStop = false;
            // 
            // checkBoxInvest
            // 
            this.checkBoxInvest.AutoSize = true;
            this.checkBoxInvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvest.Location = new System.Drawing.Point(549, 43);
            this.checkBoxInvest.Name = "checkBoxInvest";
            this.checkBoxInvest.Size = new System.Drawing.Size(150, 33);
            this.checkBoxInvest.TabIndex = 2;
            this.checkBoxInvest.Text = "Investment";
            this.checkBoxInvest.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxInvest.UseVisualStyleBackColor = true;
            // 
            // checkBoxEveryday
            // 
            this.checkBoxEveryday.AutoSize = true;
            this.checkBoxEveryday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEveryday.Location = new System.Drawing.Point(310, 43);
            this.checkBoxEveryday.Name = "checkBoxEveryday";
            this.checkBoxEveryday.Size = new System.Drawing.Size(133, 33);
            this.checkBoxEveryday.TabIndex = 1;
            this.checkBoxEveryday.Text = "Everyday";
            this.checkBoxEveryday.UseVisualStyleBackColor = true;
            // 
            // checkBoxOmni
            // 
            this.checkBoxOmni.AutoSize = true;
            this.checkBoxOmni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOmni.Location = new System.Drawing.Point(87, 43);
            this.checkBoxOmni.Name = "checkBoxOmni";
            this.checkBoxOmni.Size = new System.Drawing.Size(93, 33);
            this.checkBoxOmni.TabIndex = 0;
            this.checkBoxOmni.Tag = "   ";
            this.checkBoxOmni.Text = "Omni";
            this.checkBoxOmni.UseVisualStyleBackColor = true;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(221, 290);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(634, 22);
            this.textBoxAmount.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter amount:";
            // 
            // listBoxTransactions
            // 
            this.listBoxTransactions.FormattingEnabled = true;
            this.listBoxTransactions.ItemHeight = 16;
            this.listBoxTransactions.Location = new System.Drawing.Point(47, 638);
            this.listBoxTransactions.Name = "listBoxTransactions";
            this.listBoxTransactions.Size = new System.Drawing.Size(808, 84);
            this.listBoxTransactions.TabIndex = 23;
            // 
            // labelAccInfo
            // 
            this.labelAccInfo.AutoSize = true;
            this.labelAccInfo.Location = new System.Drawing.Point(427, 403);
            this.labelAccInfo.Name = "labelAccInfo";
            this.labelAccInfo.Size = new System.Drawing.Size(0, 17);
            this.labelAccInfo.TabIndex = 22;
            // 
            // buttonInterest
            // 
            this.buttonInterest.Location = new System.Drawing.Point(456, 194);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(399, 68);
            this.buttonInterest.TabIndex = 21;
            this.buttonInterest.Text = "Calculate and Add Interest";
            this.buttonInterest.UseVisualStyleBackColor = true;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(504, 341);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(351, 68);
            this.buttonDeposit.TabIndex = 20;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(56, 341);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(351, 68);
            this.buttonWithdraw.TabIndex = 19;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(418, 290);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelInfo.TabIndex = 18;
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Location = new System.Drawing.Point(47, 194);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(347, 68);
            this.buttonAccountInfo.TabIndex = 17;
            this.buttonAccountInfo.Text = "Request Account Information";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccounts.Location = new System.Drawing.Point(369, 59);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(178, 29);
            this.labelAccounts.TabIndex = 16;
            this.labelAccounts.Text = "Select Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 782);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.groupBoxAccounts);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTransactions);
            this.Controls.Add(this.labelAccInfo);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.labelAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAccounts.ResumeLayout(false);
            this.groupBoxAccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBoxAccounts;
        private System.Windows.Forms.CheckBox checkBoxInvest;
        private System.Windows.Forms.CheckBox checkBoxEveryday;
        private System.Windows.Forms.CheckBox checkBoxOmni;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTransactions;
        private System.Windows.Forms.Label labelAccInfo;
        private System.Windows.Forms.Button buttonInterest;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Label labelAccounts;
    }
}

