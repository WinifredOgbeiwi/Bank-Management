namespace _70126_SyntaxSyndicate_Project2
{
    partial class CustomerAccountControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerSavings = new System.Windows.Forms.Label();
            this.labelSavings = new System.Windows.Forms.Label();
            this.customerBalance = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.customerID1 = new System.Windows.Forms.Label();
            this.labelAcctNum = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.customerAcctNum = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxWithdraw = new System.Windows.Forms.GroupBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textBoxWithdraw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxSaving = new System.Windows.Forms.GroupBox();
            this.buttonSaving = new System.Windows.Forms.Button();
            this.textBoxSaving = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxWithdraw.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSavings);
            this.groupBox1.Controls.Add(this.labelSavings);
            this.groupBox1.Controls.Add(this.customerBalance);
            this.groupBox1.Controls.Add(this.labelBalance);
            this.groupBox1.Controls.Add(this.customerID1);
            this.groupBox1.Controls.Add(this.labelAcctNum);
            this.groupBox1.Controls.Add(this.labelCustomerID);
            this.groupBox1.Controls.Add(this.customerAcctNum);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // customerSavings
            // 
            this.customerSavings.AutoSize = true;
            this.customerSavings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSavings.Location = new System.Drawing.Point(205, 164);
            this.customerSavings.Name = "customerSavings";
            this.customerSavings.Size = new System.Drawing.Size(48, 28);
            this.customerSavings.TabIndex = 54;
            this.customerSavings.Text = "null";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSavings.Location = new System.Drawing.Point(6, 167);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(83, 28);
            this.labelSavings.TabIndex = 53;
            this.labelSavings.Text = "Savings:";
            this.labelSavings.Click += new System.EventHandler(this.labelSavings_Click);
            // 
            // customerBalance
            // 
            this.customerBalance.AutoSize = true;
            this.customerBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBalance.Location = new System.Drawing.Point(205, 118);
            this.customerBalance.Name = "customerBalance";
            this.customerBalance.Size = new System.Drawing.Size(48, 28);
            this.customerBalance.TabIndex = 52;
            this.customerBalance.Text = "null";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(6, 121);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(82, 28);
            this.labelBalance.TabIndex = 51;
            this.labelBalance.Text = "Balance:";
            this.labelBalance.Click += new System.EventHandler(this.labelBalance_Click);
            // 
            // customerID1
            // 
            this.customerID1.AutoSize = true;
            this.customerID1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID1.Location = new System.Drawing.Point(208, 74);
            this.customerID1.Name = "customerID1";
            this.customerID1.Size = new System.Drawing.Size(48, 28);
            this.customerID1.TabIndex = 50;
            this.customerID1.Text = "null";
            this.customerID1.Click += new System.EventHandler(this.customerID_Click);
            // 
            // labelAcctNum
            // 
            this.labelAcctNum.AutoSize = true;
            this.labelAcctNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcctNum.Location = new System.Drawing.Point(6, 36);
            this.labelAcctNum.Name = "labelAcctNum";
            this.labelAcctNum.Size = new System.Drawing.Size(165, 28);
            this.labelAcctNum.TabIndex = 47;
            this.labelAcctNum.Text = "Account Number:";
            this.labelAcctNum.Click += new System.EventHandler(this.labelAcctNum_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(6, 77);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(124, 28);
            this.labelCustomerID.TabIndex = 48;
            this.labelCustomerID.Text = "Customer ID:";
            this.labelCustomerID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // customerAcctNum
            // 
            this.customerAcctNum.AutoSize = true;
            this.customerAcctNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAcctNum.Location = new System.Drawing.Point(209, 33);
            this.customerAcctNum.Name = "customerAcctNum";
            this.customerAcctNum.Size = new System.Drawing.Size(48, 28);
            this.customerAcctNum.TabIndex = 49;
            this.customerAcctNum.Text = "null";
            // 
            // groupBoxWithdraw
            // 
            this.groupBoxWithdraw.Controls.Add(this.buttonWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.textBoxWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.label6);
            this.groupBoxWithdraw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWithdraw.Location = new System.Drawing.Point(12, 343);
            this.groupBoxWithdraw.Name = "groupBoxWithdraw";
            this.groupBoxWithdraw.Size = new System.Drawing.Size(657, 150);
            this.groupBoxWithdraw.TabIndex = 55;
            this.groupBoxWithdraw.TabStop = false;
            this.groupBoxWithdraw.Text = "Withdraw";
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.Indigo;
            this.buttonWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdraw.ForeColor = System.Drawing.Color.White;
            this.buttonWithdraw.Location = new System.Drawing.Point(448, 44);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(196, 54);
            this.buttonWithdraw.TabIndex = 49;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWithdraw.Location = new System.Drawing.Point(221, 56);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(197, 34);
            this.textBoxWithdraw.TabIndex = 48;
            this.textBoxWithdraw.TextChanged += new System.EventHandler(this.textBoxWithdraw_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 28);
            this.label6.TabIndex = 47;
            this.label6.Text = "Withdraw Amount:";
            // 
            // groupBoxSaving
            // 
            this.groupBoxSaving.Controls.Add(this.buttonSaving);
            this.groupBoxSaving.Controls.Add(this.textBoxSaving);
            this.groupBoxSaving.Controls.Add(this.label1);
            this.groupBoxSaving.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaving.Location = new System.Drawing.Point(12, 514);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.Size = new System.Drawing.Size(657, 150);
            this.groupBoxSaving.TabIndex = 56;
            this.groupBoxSaving.TabStop = false;
            this.groupBoxSaving.Text = "Move to Saving";
            // 
            // buttonSaving
            // 
            this.buttonSaving.BackColor = System.Drawing.Color.Indigo;
            this.buttonSaving.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonSaving.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonSaving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaving.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaving.ForeColor = System.Drawing.Color.White;
            this.buttonSaving.Location = new System.Drawing.Point(448, 44);
            this.buttonSaving.Name = "buttonSaving";
            this.buttonSaving.Size = new System.Drawing.Size(196, 54);
            this.buttonSaving.TabIndex = 49;
            this.buttonSaving.Text = "Move";
            this.buttonSaving.UseVisualStyleBackColor = false;
            this.buttonSaving.Click += new System.EventHandler(this.buttonSaving_Click);
            // 
            // textBoxSaving
            // 
            this.textBoxSaving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSaving.Location = new System.Drawing.Point(221, 56);
            this.textBoxSaving.Name = "textBoxSaving";
            this.textBoxSaving.Size = new System.Drawing.Size(197, 35);
            this.textBoxSaving.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Moving Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeposit);
            this.groupBox2.Controls.Add(this.textBoxDeposit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 685);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 150);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Indigo;
            this.buttonDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.White;
            this.buttonDeposit.Location = new System.Drawing.Point(448, 44);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(196, 54);
            this.buttonDeposit.TabIndex = 49;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeposit.Location = new System.Drawing.Point(221, 56);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(197, 35);
            this.textBoxDeposit.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Deposit Amount:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Indigo;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(12, 841);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(657, 54);
            this.buttonExit.TabIndex = 50;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-2, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(684, 94);
            this.button1.TabIndex = 55;
            this.button1.Text = "Account Control";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CustomerAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 932);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.groupBoxWithdraw);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerAccountControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerAccountControl";
            this.Load += new System.EventHandler(this.CustomerAccountControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxWithdraw.ResumeLayout(false);
            this.groupBoxWithdraw.PerformLayout();
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customerID1;
        private System.Windows.Forms.Label labelAcctNum;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label customerAcctNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label customerSavings;
        private System.Windows.Forms.Label labelSavings;
        private System.Windows.Forms.Label customerBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.GroupBox groupBoxWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.TextBox textBoxWithdraw;
        private System.Windows.Forms.GroupBox groupBoxSaving;
        private System.Windows.Forms.Button buttonSaving;
        private System.Windows.Forms.TextBox textBoxSaving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}