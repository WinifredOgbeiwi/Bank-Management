namespace _70126_SyntaxSyndicate_Project2
{
    partial class PasswordForm
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
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Indigo;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(79, 299);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(467, 62);
            this.buttonPay.TabIndex = 57;
            this.buttonPay.Text = "Submit";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(74, 219);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(147, 28);
            this.labelCustomerID.TabIndex = 48;
            this.labelCustomerID.Text = "Enter Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(244, 208);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(296, 46);
            this.textBoxPassword.TabIndex = 73;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(546, 21);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(14, 20);
            this.passwordlabel.TabIndex = 74;
            this.passwordlabel.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(657, 94);
            this.button1.TabIndex = 75;
            this.button1.Text = "Password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonExit_Add
            // 
            this.buttonExit_Add.BackColor = System.Drawing.Color.White;
            this.buttonExit_Add.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonExit_Add.FlatAppearance.BorderSize = 2;
            this.buttonExit_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.buttonExit_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonExit_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit_Add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit_Add.ForeColor = System.Drawing.Color.Indigo;
            this.buttonExit_Add.Location = new System.Drawing.Point(79, 376);
            this.buttonExit_Add.Name = "buttonExit_Add";
            this.buttonExit_Add.Size = new System.Drawing.Size(467, 62);
            this.buttonExit_Add.TabIndex = 76;
            this.buttonExit_Add.Text = "Exit";
            this.buttonExit_Add.UseVisualStyleBackColor = false;
            this.buttonExit_Add.Click += new System.EventHandler(this.buttonExit_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 41);
            this.label1.TabIndex = 77;
            this.label1.Text = "Enter Password to Edit Account";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit_Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelCustomerID);
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit_Add;
        private System.Windows.Forms.Label label1;
    }
}