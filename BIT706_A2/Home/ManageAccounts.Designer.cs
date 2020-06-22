namespace Home
{
    partial class ManageAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustDetails = new System.Windows.Forms.Label();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.buttonNewAccount = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonAddInterest = new System.Windows.Forms.Button();
            this.groupBoxAmounts = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.listBoxAccountsTransfer = new System.Windows.Forms.ListBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.groupBoxTransfer = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCancelTransfer = new System.Windows.Forms.Button();
            this.buttonTransf = new System.Windows.Forms.Button();
            this.textBoxTransfer = new System.Windows.Forms.TextBox();
            this.labelCustNum = new System.Windows.Forms.Label();
            this.textBoxEnteredID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxAmounts.SuspendLayout();
            this.groupBoxTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LLRT Bank";
            // 
            // labelCustDetails
            // 
            this.labelCustDetails.AutoSize = true;
            this.labelCustDetails.Location = new System.Drawing.Point(123, 138);
            this.labelCustDetails.Name = "labelCustDetails";
            this.labelCustDetails.Size = new System.Drawing.Size(46, 17);
            this.labelCustDetails.TabIndex = 2;
            this.labelCustDetails.Text = "label2";
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 16;
            this.listBoxAccounts.Location = new System.Drawing.Point(66, 216);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(252, 356);
            this.listBoxAccounts.TabIndex = 3;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // buttonNewAccount
            // 
            this.buttonNewAccount.Location = new System.Drawing.Point(621, 130);
            this.buttonNewAccount.Name = "buttonNewAccount";
            this.buttonNewAccount.Size = new System.Drawing.Size(156, 65);
            this.buttonNewAccount.TabIndex = 4;
            this.buttonNewAccount.Text = "Open New Account";
            this.buttonNewAccount.UseVisualStyleBackColor = true;
            this.buttonNewAccount.Click += new System.EventHandler(this.buttonNewAccount_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(363, 216);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(113, 52);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Visible = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(363, 305);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(113, 52);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Visible = false;
            // 
            // buttonAddInterest
            // 
            this.buttonAddInterest.Location = new System.Drawing.Point(363, 502);
            this.buttonAddInterest.Name = "buttonAddInterest";
            this.buttonAddInterest.Size = new System.Drawing.Size(113, 52);
            this.buttonAddInterest.TabIndex = 7;
            this.buttonAddInterest.Text = "Add Interest";
            this.buttonAddInterest.UseVisualStyleBackColor = true;
            this.buttonAddInterest.Visible = false;
            // 
            // groupBoxAmounts
            // 
            this.groupBoxAmounts.Controls.Add(this.buttonCancel);
            this.groupBoxAmounts.Controls.Add(this.buttonContinue);
            this.groupBoxAmounts.Controls.Add(this.textBoxAmount);
            this.groupBoxAmounts.Location = new System.Drawing.Point(520, 264);
            this.groupBoxAmounts.Name = "groupBoxAmounts";
            this.groupBoxAmounts.Size = new System.Drawing.Size(214, 105);
            this.groupBoxAmounts.TabIndex = 8;
            this.groupBoxAmounts.TabStop = false;
            this.groupBoxAmounts.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(117, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(19, 70);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Visible = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(19, 22);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(176, 22);
            this.textBoxAmount.TabIndex = 0;
            this.textBoxAmount.Visible = false;
            // 
            // listBoxAccountsTransfer
            // 
            this.listBoxAccountsTransfer.FormattingEnabled = true;
            this.listBoxAccountsTransfer.ItemHeight = 16;
            this.listBoxAccountsTransfer.Location = new System.Drawing.Point(539, 216);
            this.listBoxAccountsTransfer.Name = "listBoxAccountsTransfer";
            this.listBoxAccountsTransfer.Size = new System.Drawing.Size(238, 356);
            this.listBoxAccountsTransfer.TabIndex = 9;
            this.listBoxAccountsTransfer.Visible = false;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(363, 405);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(113, 52);
            this.buttonTransfer.TabIndex = 10;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Visible = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // groupBoxTransfer
            // 
            this.groupBoxTransfer.Controls.Add(this.labelError);
            this.groupBoxTransfer.Controls.Add(this.buttonCancelTransfer);
            this.groupBoxTransfer.Controls.Add(this.buttonTransf);
            this.groupBoxTransfer.Controls.Add(this.textBoxTransfer);
            this.groupBoxTransfer.Location = new System.Drawing.Point(318, 90);
            this.groupBoxTransfer.Name = "groupBoxTransfer";
            this.groupBoxTransfer.Size = new System.Drawing.Size(214, 105);
            this.groupBoxTransfer.TabIndex = 9;
            this.groupBoxTransfer.TabStop = false;
            this.groupBoxTransfer.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(88, 48);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 17);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "label2";
            // 
            // buttonCancelTransfer
            // 
            this.buttonCancelTransfer.Location = new System.Drawing.Point(117, 70);
            this.buttonCancelTransfer.Name = "buttonCancelTransfer";
            this.buttonCancelTransfer.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTransfer.TabIndex = 2;
            this.buttonCancelTransfer.Text = "Cancel";
            this.buttonCancelTransfer.UseVisualStyleBackColor = true;
            this.buttonCancelTransfer.Visible = false;
            // 
            // buttonTransf
            // 
            this.buttonTransf.Location = new System.Drawing.Point(19, 70);
            this.buttonTransf.Name = "buttonTransf";
            this.buttonTransf.Size = new System.Drawing.Size(75, 23);
            this.buttonTransf.TabIndex = 1;
            this.buttonTransf.Text = "Continue";
            this.buttonTransf.UseVisualStyleBackColor = true;
            this.buttonTransf.Visible = false;
            // 
            // textBoxTransfer
            // 
            this.textBoxTransfer.Location = new System.Drawing.Point(19, 22);
            this.textBoxTransfer.Name = "textBoxTransfer";
            this.textBoxTransfer.Size = new System.Drawing.Size(176, 22);
            this.textBoxTransfer.TabIndex = 0;
            this.textBoxTransfer.Visible = false;
            // 
            // labelCustNum
            // 
            this.labelCustNum.AutoSize = true;
            this.labelCustNum.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustNum.Location = new System.Drawing.Point(266, 53);
            this.labelCustNum.Name = "labelCustNum";
            this.labelCustNum.Size = new System.Drawing.Size(210, 21);
            this.labelCustNum.TabIndex = 11;
            this.labelCustNum.Text = "Customer Number: ";
            // 
            // textBoxEnteredID
            // 
            this.textBoxEnteredID.Location = new System.Drawing.Point(488, 52);
            this.textBoxEnteredID.Name = "textBoxEnteredID";
            this.textBoxEnteredID.Size = new System.Drawing.Size(270, 22);
            this.textBoxEnteredID.TabIndex = 12;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(804, 37);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(109, 52);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(946, 631);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxEnteredID);
            this.Controls.Add(this.labelCustNum);
            this.Controls.Add(this.groupBoxTransfer);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.groupBoxAmounts);
            this.Controls.Add(this.buttonAddInterest);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonNewAccount);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.labelCustDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAccountsTransfer);
            this.Name = "ManageAccounts";
            this.Text = "ManageAccounts";
            this.groupBoxAmounts.ResumeLayout(false);
            this.groupBoxAmounts.PerformLayout();
            this.groupBoxTransfer.ResumeLayout(false);
            this.groupBoxTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustDetails;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button buttonNewAccount;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonAddInterest;
        private System.Windows.Forms.GroupBox groupBoxAmounts;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ListBox listBoxAccountsTransfer;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.GroupBox groupBoxTransfer;
        private System.Windows.Forms.Button buttonCancelTransfer;
        private System.Windows.Forms.Button buttonTransf;
        private System.Windows.Forms.TextBox textBoxTransfer;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelCustNum;
        private System.Windows.Forms.TextBox textBoxEnteredID;
        private System.Windows.Forms.Button buttonSearch;
    }
}