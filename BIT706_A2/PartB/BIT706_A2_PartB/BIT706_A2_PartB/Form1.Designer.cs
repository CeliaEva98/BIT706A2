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
            this.labelAccounts = new System.Windows.Forms.Label();
            this.groupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.checkBoxOmni = new System.Windows.Forms.CheckBox();
            this.checkBoxEveryday = new System.Windows.Forms.CheckBox();
            this.checkBoxInvest = new System.Windows.Forms.CheckBox();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBoxAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccounts.Location = new System.Drawing.Point(372, 36);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(178, 29);
            this.labelAccounts.TabIndex = 0;
            this.labelAccounts.Text = "Select Account:";
            // 
            // groupBoxAccounts
            // 
            this.groupBoxAccounts.Controls.Add(this.checkBoxInvest);
            this.groupBoxAccounts.Controls.Add(this.checkBoxEveryday);
            this.groupBoxAccounts.Controls.Add(this.checkBoxOmni);
            this.groupBoxAccounts.Location = new System.Drawing.Point(50, 65);
            this.groupBoxAccounts.Name = "groupBoxAccounts";
            this.groupBoxAccounts.Size = new System.Drawing.Size(808, 100);
            this.groupBoxAccounts.TabIndex = 1;
            this.groupBoxAccounts.TabStop = false;
            // 
            // checkBoxOmni
            // 
            this.checkBoxOmni.AutoSize = true;
            this.checkBoxOmni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOmni.Location = new System.Drawing.Point(87, 43);
            this.checkBoxOmni.Name = "checkBoxOmni";
            this.checkBoxOmni.Size = new System.Drawing.Size(93, 33);
            this.checkBoxOmni.TabIndex = 0;
            this.checkBoxOmni.Text = "Omni";
            this.checkBoxOmni.UseVisualStyleBackColor = true;
            this.checkBoxOmni.CheckedChanged += new System.EventHandler(this.checkBoxOmni_CheckedChanged);
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
            this.checkBoxEveryday.CheckedChanged += new System.EventHandler(this.checkBoxEveryday_CheckedChanged);
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
            this.checkBoxInvest.UseVisualStyleBackColor = true;
            this.checkBoxInvest.CheckedChanged += new System.EventHandler(this.checkBoxInvest_CheckedChanged);
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Location = new System.Drawing.Point(50, 171);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(347, 68);
            this.buttonAccountInfo.TabIndex = 2;
            this.buttonAccountInfo.Text = "Request Account Information";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click);
            // 
            // buttonInterest
            // 
            this.buttonInterest.Location = new System.Drawing.Point(459, 171);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(399, 68);
            this.buttonInterest.TabIndex = 3;
            this.buttonInterest.Text = "Calculate and Add Interest";
            this.buttonInterest.UseVisualStyleBackColor = true;
            this.buttonInterest.Click += new System.EventHandler(this.buttonInterest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(224, 267);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(634, 22);
            this.textBoxAmount.TabIndex = 5;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(59, 318);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(351, 68);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(507, 318);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(351, 68);
            this.buttonDeposit.TabIndex = 7;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(447, 416);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 17);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "label2";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(47, 447);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(90, 17);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Account Info:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 782);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.groupBoxAccounts);
            this.Controls.Add(this.labelAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAccounts.ResumeLayout(false);
            this.groupBoxAccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.GroupBox groupBoxAccounts;
        private System.Windows.Forms.CheckBox checkBoxInvest;
        private System.Windows.Forms.CheckBox checkBoxEveryday;
        private System.Windows.Forms.CheckBox checkBoxOmni;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Button buttonInterest;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label infoLabel;
    }
}

