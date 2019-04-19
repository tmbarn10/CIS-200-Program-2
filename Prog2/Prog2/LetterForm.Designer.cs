namespace Prog2
{
    partial class LetterForm
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
            this.lblOriginAddress = new System.Windows.Forms.Label();
            this.lblDestinationAddress = new System.Windows.Forms.Label();
            this.lblFixedCost = new System.Windows.Forms.Label();
            this.cbOriginAddress = new System.Windows.Forms.ComboBox();
            this.cbDestinationAddress = new System.Windows.Forms.ComboBox();
            this.txtFixedCost = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOriginAddress
            // 
            this.lblOriginAddress.AutoSize = true;
            this.lblOriginAddress.Location = new System.Drawing.Point(54, 43);
            this.lblOriginAddress.Name = "lblOriginAddress";
            this.lblOriginAddress.Size = new System.Drawing.Size(78, 13);
            this.lblOriginAddress.TabIndex = 0;
            this.lblOriginAddress.Text = "Origin Address:";
            // 
            // lblDestinationAddress
            // 
            this.lblDestinationAddress.AutoSize = true;
            this.lblDestinationAddress.Location = new System.Drawing.Point(39, 79);
            this.lblDestinationAddress.Name = "lblDestinationAddress";
            this.lblDestinationAddress.Size = new System.Drawing.Size(104, 13);
            this.lblDestinationAddress.TabIndex = 1;
            this.lblDestinationAddress.Text = "Destination Address:";
            // 
            // lblFixedCost
            // 
            this.lblFixedCost.AutoSize = true;
            this.lblFixedCost.Location = new System.Drawing.Point(81, 110);
            this.lblFixedCost.Name = "lblFixedCost";
            this.lblFixedCost.Size = new System.Drawing.Size(59, 13);
            this.lblFixedCost.TabIndex = 2;
            this.lblFixedCost.Text = "Fixed Cost:";
            // 
            // cbOriginAddress
            // 
            this.cbOriginAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginAddress.FormattingEnabled = true;
            this.cbOriginAddress.Location = new System.Drawing.Point(146, 40);
            this.cbOriginAddress.Name = "cbOriginAddress";
            this.cbOriginAddress.Size = new System.Drawing.Size(121, 21);
            this.cbOriginAddress.TabIndex = 3;
            // 
            // cbDestinationAddress
            // 
            this.cbDestinationAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationAddress.FormattingEnabled = true;
            this.cbDestinationAddress.Location = new System.Drawing.Point(146, 76);
            this.cbDestinationAddress.Name = "cbDestinationAddress";
            this.cbDestinationAddress.Size = new System.Drawing.Size(121, 21);
            this.cbDestinationAddress.TabIndex = 4;
            // 
            // txtFixedCost
            // 
            this.txtFixedCost.Location = new System.Drawing.Point(146, 107);
            this.txtFixedCost.Name = "txtFixedCost";
            this.txtFixedCost.Size = new System.Drawing.Size(121, 20);
            this.txtFixedCost.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(32, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFixedCost);
            this.Controls.Add(this.cbDestinationAddress);
            this.Controls.Add(this.cbOriginAddress);
            this.Controls.Add(this.lblFixedCost);
            this.Controls.Add(this.lblDestinationAddress);
            this.Controls.Add(this.lblOriginAddress);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginAddress;
        private System.Windows.Forms.Label lblDestinationAddress;
        private System.Windows.Forms.Label lblFixedCost;
        private System.Windows.Forms.ComboBox cbOriginAddress;
        private System.Windows.Forms.ComboBox cbDestinationAddress;
        private System.Windows.Forms.TextBox txtFixedCost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}