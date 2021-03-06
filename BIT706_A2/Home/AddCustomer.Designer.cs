﻿namespace Home
{
    partial class AddCustomer
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelAddNew = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxStaff = new System.Windows.Forms.CheckBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "LLRT Bank";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(77, 283);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(125, 21);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(303, 282);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(436, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(77, 350);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(119, 21);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(303, 349);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(436, 22);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(77, 416);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(192, 21);
            this.labelContact.TabIndex = 7;
            this.labelContact.Text = "Contact Number:";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(303, 417);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(436, 22);
            this.textBoxContact.TabIndex = 8;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // labelAddNew
            // 
            this.labelAddNew.AutoSize = true;
            this.labelAddNew.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNew.Location = new System.Drawing.Point(242, 123);
            this.labelAddNew.Name = "labelAddNew";
            this.labelAddNew.Size = new System.Drawing.Size(291, 29);
            this.labelAddNew.TabIndex = 9;
            this.labelAddNew.Text = "Add New Customer";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(47, 564);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 63);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Return";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.Location = new System.Drawing.Point(377, 482);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(273, 57);
            this.buttonAddNew.TabIndex = 11;
            this.buttonAddNew.Text = "Add Customer";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(351, 179);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 17);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "label2";
            // 
            // checkBoxStaff
            // 
            this.checkBoxStaff.AutoSize = true;
            this.checkBoxStaff.Location = new System.Drawing.Point(303, 233);
            this.checkBoxStaff.Name = "checkBoxStaff";
            this.checkBoxStaff.Size = new System.Drawing.Size(95, 21);
            this.checkBoxStaff.TabIndex = 13;
            this.checkBoxStaff.Text = "Bank Staff";
            this.checkBoxStaff.UseVisualStyleBackColor = true;
            this.checkBoxStaff.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Location = new System.Drawing.Point(503, 233);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(130, 21);
            this.checkBoxOther.TabIndex = 14;
            this.checkBoxOther.Text = "Other Customer";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.CheckedChanged += new System.EventHandler(this.checkBoxOther_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer Type:";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxOther);
            this.Controls.Add(this.checkBoxStaff);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAddNew);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelAddNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxStaff;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.Label label2;
    }
}