using System;

namespace Prog2
{
    partial class AddressForm
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
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressTwo = new System.Windows.Forms.TextBox();
            this.txtAddressOne = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressOne = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "KY",
            "TX",
            "CA",
            "TN",
            "IN",
            "ME",
            "MD"});
            this.cbState.Location = new System.Drawing.Point(126, 145);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(101, 21);
            this.cbState.TabIndex = 26;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(127, 176);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 25;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(127, 111);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 24;
            // 
            // txtAddressTwo
            // 
            this.txtAddressTwo.Location = new System.Drawing.Point(127, 81);
            this.txtAddressTwo.Name = "txtAddressTwo";
            this.txtAddressTwo.Size = new System.Drawing.Size(100, 20);
            this.txtAddressTwo.TabIndex = 23;
            // 
            // txtAddressOne
            // 
            this.txtAddressOne.Location = new System.Drawing.Point(127, 55);
            this.txtAddressOne.Name = "txtAddressOne";
            this.txtAddressOne.Size = new System.Drawing.Size(100, 20);
            this.txtAddressOne.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 21;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(96, 179);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 18;
            this.lblZip.Text = "Zip:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(86, 148);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 17;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(94, 114);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City:";
            // 
            // lblAddressOne
            // 
            this.lblAddressOne.AutoSize = true;
            this.lblAddressOne.Location = new System.Drawing.Point(73, 58);
            this.lblAddressOne.Name = "lblAddressOne";
            this.lblAddressOne.Size = new System.Drawing.Size(48, 13);
            this.lblAddressOne.TabIndex = 15;
            this.lblAddressOne.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressTwo);
            this.Controls.Add(this.txtAddressOne);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddressOne);
            this.Controls.Add(this.lblName);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressTwo;
        private System.Windows.Forms.TextBox txtAddressOne;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressOne;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
    }
}