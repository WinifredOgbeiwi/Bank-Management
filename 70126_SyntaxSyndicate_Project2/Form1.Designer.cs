namespace _70126_SyntaxSyndicate_Project2
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
            this.headinglabel = new System.Windows.Forms.Label();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomerbutton = new System.Windows.Forms.Button();
            this.showCustomerbutton = new System.Windows.Forms.Button();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.showStaffbutton = new System.Windows.Forms.Button();
            this.addStaffbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerGroupBox.SuspendLayout();
            this.staffGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headinglabel
            // 
            this.headinglabel.AutoSize = true;
            this.headinglabel.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglabel.ForeColor = System.Drawing.Color.Black;
            this.headinglabel.Location = new System.Drawing.Point(294, 9);
            this.headinglabel.Name = "headinglabel";
            this.headinglabel.Size = new System.Drawing.Size(415, 86);
            this.headinglabel.TabIndex = 0;
            this.headinglabel.Text = "Syndicate Bank";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.BackColor = System.Drawing.Color.White;
            this.customerGroupBox.Controls.Add(this.showCustomerbutton);
            this.customerGroupBox.Controls.Add(this.addCustomerbutton);
            this.customerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox.Location = new System.Drawing.Point(13, 107);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(925, 191);
            this.customerGroupBox.TabIndex = 2;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Control";
            // 
            // addCustomerbutton
            // 
            this.addCustomerbutton.BackColor = System.Drawing.Color.White;
            this.addCustomerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addCustomerbutton.FlatAppearance.BorderSize = 3;
            this.addCustomerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addCustomerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addCustomerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerbutton.Location = new System.Drawing.Point(291, 32);
            this.addCustomerbutton.Name = "addCustomerbutton";
            this.addCustomerbutton.Size = new System.Drawing.Size(336, 65);
            this.addCustomerbutton.TabIndex = 0;
            this.addCustomerbutton.Text = "Add Customer";
            this.addCustomerbutton.UseVisualStyleBackColor = false;
            this.addCustomerbutton.Click += new System.EventHandler(this.addCustomerbutton_Click);
            // 
            // showCustomerbutton
            // 
            this.showCustomerbutton.BackColor = System.Drawing.Color.White;
            this.showCustomerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showCustomerbutton.FlatAppearance.BorderSize = 3;
            this.showCustomerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.showCustomerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.showCustomerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCustomerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomerbutton.Location = new System.Drawing.Point(290, 104);
            this.showCustomerbutton.Name = "showCustomerbutton";
            this.showCustomerbutton.Size = new System.Drawing.Size(336, 65);
            this.showCustomerbutton.TabIndex = 1;
            this.showCustomerbutton.Text = "Show Customer";
            this.showCustomerbutton.UseVisualStyleBackColor = false;
            this.showCustomerbutton.Click += new System.EventHandler(this.showCustomerbutton_Click);
            // 
            // staffGroupBox
            // 
            this.staffGroupBox.BackColor = System.Drawing.Color.White;
            this.staffGroupBox.Controls.Add(this.showStaffbutton);
            this.staffGroupBox.Controls.Add(this.addStaffbutton);
            this.staffGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGroupBox.Location = new System.Drawing.Point(13, 358);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(925, 199);
            this.staffGroupBox.TabIndex = 3;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "Staff Control";
            // 
            // showStaffbutton
            // 
            this.showStaffbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showStaffbutton.FlatAppearance.BorderSize = 3;
            this.showStaffbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.showStaffbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.showStaffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showStaffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStaffbutton.Location = new System.Drawing.Point(319, 118);
            this.showStaffbutton.Name = "showStaffbutton";
            this.showStaffbutton.Size = new System.Drawing.Size(336, 65);
            this.showStaffbutton.TabIndex = 1;
            this.showStaffbutton.Text = "Show Staff";
            this.showStaffbutton.UseVisualStyleBackColor = true;
            this.showStaffbutton.Click += new System.EventHandler(this.showStaffbutton_Click);
            // 
            // addStaffbutton
            // 
            this.addStaffbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addStaffbutton.FlatAppearance.BorderSize = 3;
            this.addStaffbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addStaffbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.addStaffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffbutton.Location = new System.Drawing.Point(319, 39);
            this.addStaffbutton.Name = "addStaffbutton";
            this.addStaffbutton.Size = new System.Drawing.Size(336, 65);
            this.addStaffbutton.TabIndex = 0;
            this.addStaffbutton.Text = "Add Staff";
            this.addStaffbutton.UseVisualStyleBackColor = true;
            this.addStaffbutton.Click += new System.EventHandler(this.addStaffbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 603);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(926, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 877);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.headinglabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Syndicate Bank";
            this.customerGroupBox.ResumeLayout(false);
            this.staffGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglabel;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Button addCustomerbutton;
        private System.Windows.Forms.Button showCustomerbutton;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.Button showStaffbutton;
        private System.Windows.Forms.Button addStaffbutton;
        private System.Windows.Forms.Button exitButton;
    }
}

