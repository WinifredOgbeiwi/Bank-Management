namespace _70126_SyntaxSyndicate_Project2
{
    partial class Menu
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
            this.exitButton = new System.Windows.Forms.Button();
            this.addStaffbutton = new System.Windows.Forms.Button();
            this.showStaffbutton = new System.Windows.Forms.Button();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomerbutton = new System.Windows.Forms.Button();
            this.showCustomerbutton = new System.Windows.Forms.Button();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.staffGroupBox.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Indigo;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(21, 620);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(453, 68);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // addStaffbutton
            // 
            this.addStaffbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.addStaffbutton.FlatAppearance.BorderSize = 2;
            this.addStaffbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.addStaffbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.addStaffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffbutton.Location = new System.Drawing.Point(66, 50);
            this.addStaffbutton.Name = "addStaffbutton";
            this.addStaffbutton.Size = new System.Drawing.Size(336, 68);
            this.addStaffbutton.TabIndex = 0;
            this.addStaffbutton.Text = "Add Staff";
            this.addStaffbutton.UseVisualStyleBackColor = true;
            this.addStaffbutton.Click += new System.EventHandler(this.addStaffbutton_Click);
            // 
            // showStaffbutton
            // 
            this.showStaffbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.showStaffbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.showStaffbutton.FlatAppearance.BorderSize = 2;
            this.showStaffbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.showStaffbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.showStaffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showStaffbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStaffbutton.Location = new System.Drawing.Point(66, 134);
            this.showStaffbutton.Name = "showStaffbutton";
            this.showStaffbutton.Size = new System.Drawing.Size(336, 68);
            this.showStaffbutton.TabIndex = 1;
            this.showStaffbutton.Text = "Show Staff";
            this.showStaffbutton.UseVisualStyleBackColor = true;
            this.showStaffbutton.Click += new System.EventHandler(this.showStaffbutton_Click);
            // 
            // staffGroupBox
            // 
            this.staffGroupBox.BackColor = System.Drawing.Color.White;
            this.staffGroupBox.Controls.Add(this.showStaffbutton);
            this.staffGroupBox.Controls.Add(this.addStaffbutton);
            this.staffGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGroupBox.Location = new System.Drawing.Point(21, 363);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(453, 217);
            this.staffGroupBox.TabIndex = 6;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "Staff Control";
            // 
            // addCustomerbutton
            // 
            this.addCustomerbutton.BackColor = System.Drawing.Color.White;
            this.addCustomerbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addCustomerbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.addCustomerbutton.FlatAppearance.BorderSize = 2;
            this.addCustomerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.addCustomerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.addCustomerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerbutton.Location = new System.Drawing.Point(66, 46);
            this.addCustomerbutton.Name = "addCustomerbutton";
            this.addCustomerbutton.Size = new System.Drawing.Size(336, 68);
            this.addCustomerbutton.TabIndex = 0;
            this.addCustomerbutton.Text = "Add Customer";
            this.addCustomerbutton.UseVisualStyleBackColor = false;
            this.addCustomerbutton.Click += new System.EventHandler(this.addCustomerbutton_Click_1);
            // 
            // showCustomerbutton
            // 
            this.showCustomerbutton.BackColor = System.Drawing.Color.White;
            this.showCustomerbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.showCustomerbutton.FlatAppearance.BorderSize = 2;
            this.showCustomerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.showCustomerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.showCustomerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCustomerbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomerbutton.Location = new System.Drawing.Point(66, 127);
            this.showCustomerbutton.Name = "showCustomerbutton";
            this.showCustomerbutton.Size = new System.Drawing.Size(336, 68);
            this.showCustomerbutton.TabIndex = 1;
            this.showCustomerbutton.Text = "Show Customer";
            this.showCustomerbutton.UseVisualStyleBackColor = false;
            this.showCustomerbutton.Click += new System.EventHandler(this.showCustomerbutton_Click_1);
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.BackColor = System.Drawing.Color.White;
            this.customerGroupBox.Controls.Add(this.showCustomerbutton);
            this.customerGroupBox.Controls.Add(this.addCustomerbutton);
            this.customerGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox.Location = new System.Drawing.Point(21, 99);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(453, 217);
            this.customerGroupBox.TabIndex = 4;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Control";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.staffGroupBox.ResumeLayout(false);
            this.customerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addStaffbutton;
        private System.Windows.Forms.Button showStaffbutton;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.Button addCustomerbutton;
        private System.Windows.Forms.Button showCustomerbutton;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Button button1;
    }
}