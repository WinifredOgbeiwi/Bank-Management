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
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // customerSavings
            // 
            this.customerSavings.AutoSize = true;
            this.customerSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSavings.Location = new System.Drawing.Point(208, 176);
            this.customerSavings.Name = "customerSavings";
            this.customerSavings.Size = new System.Drawing.Size(46, 25);
            this.customerSavings.TabIndex = 54;
            this.customerSavings.Text = "null";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSavings.Location = new System.Drawing.Point(6, 176);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(89, 25);
            this.labelSavings.TabIndex = 53;
            this.labelSavings.Text = "Savings:";
            // 
            // customerBalance
            // 
            this.customerBalance.AutoSize = true;
            this.customerBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBalance.Location = new System.Drawing.Point(208, 121);
            this.customerBalance.Name = "customerBalance";
            this.customerBalance.Size = new System.Drawing.Size(46, 25);
            this.customerBalance.TabIndex = 52;
            this.customerBalance.Text = "null";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(6, 121);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(89, 25);
            this.labelBalance.TabIndex = 51;
            this.labelBalance.Text = "Balance:";
            // 
            // customerID1
            // 
            this.customerID1.AutoSize = true;
            this.customerID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID1.Location = new System.Drawing.Point(210, 77);
            this.customerID1.Name = "customerID1";
            this.customerID1.Size = new System.Drawing.Size(46, 25);
            this.customerID1.TabIndex = 50;
            this.customerID1.Text = "null";
            this.customerID1.Click += new System.EventHandler(this.customerID_Click);
            // 
            // labelAcctNum
            // 
            this.labelAcctNum.AutoSize = true;
            this.labelAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcctNum.Location = new System.Drawing.Point(6, 36);
            this.labelAcctNum.Name = "labelAcctNum";
            this.labelAcctNum.Size = new System.Drawing.Size(164, 25);
            this.labelAcctNum.TabIndex = 47;
            this.labelAcctNum.Text = "Account Number:";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(6, 77);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(121, 25);
            this.labelCustomerID.TabIndex = 48;
            this.labelCustomerID.Text = "Customer ID";
            this.labelCustomerID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // customerAcctNum
            // 
            this.customerAcctNum.AutoSize = true;
            this.customerAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAcctNum.Location = new System.Drawing.Point(210, 36);
            this.customerAcctNum.Name = "customerAcctNum";
            this.customerAcctNum.Size = new System.Drawing.Size(46, 25);
            this.customerAcctNum.TabIndex = 49;
            this.customerAcctNum.Text = "null";
            // 
            // groupBoxWithdraw
            // 
            this.groupBoxWithdraw.Controls.Add(this.buttonWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.textBoxWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.label6);
            this.groupBoxWithdraw.Location = new System.Drawing.Point(12, 260);
            this.groupBoxWithdraw.Name = "groupBoxWithdraw";
            this.groupBoxWithdraw.Size = new System.Drawing.Size(657, 150);
            this.groupBoxWithdraw.TabIndex = 55;
            this.groupBoxWithdraw.TabStop = false;
            this.groupBoxWithdraw.Text = "Withdraw";
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(448, 44);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(196, 54);
            this.buttonWithdraw.TabIndex = 49;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textBoxWithdraw
            // 
            this.textBoxWithdraw.Location = new System.Drawing.Point(221, 56);
            this.textBoxWithdraw.Name = "textBoxWithdraw";
            this.textBoxWithdraw.Size = new System.Drawing.Size(197, 26);
            this.textBoxWithdraw.TabIndex = 48;
            this.textBoxWithdraw.TextChanged += new System.EventHandler(this.textBoxWithdraw_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Withdraw Amount:";
            // 
            // groupBoxSaving
            // 
            this.groupBoxSaving.Controls.Add(this.buttonSaving);
            this.groupBoxSaving.Controls.Add(this.textBoxSaving);
            this.groupBoxSaving.Controls.Add(this.label1);
            this.groupBoxSaving.Location = new System.Drawing.Point(12, 431);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.Size = new System.Drawing.Size(657, 150);
            this.groupBoxSaving.TabIndex = 56;
            this.groupBoxSaving.TabStop = false;
            this.groupBoxSaving.Text = "Move to Saving";
            // 
            // buttonSaving
            // 
            this.buttonSaving.Location = new System.Drawing.Point(448, 44);
            this.buttonSaving.Name = "buttonSaving";
            this.buttonSaving.Size = new System.Drawing.Size(196, 54);
            this.buttonSaving.TabIndex = 49;
            this.buttonSaving.Text = "Move";
            this.buttonSaving.UseVisualStyleBackColor = true;
            this.buttonSaving.Click += new System.EventHandler(this.buttonSaving_Click);
            // 
            // textBoxSaving
            // 
            this.textBoxSaving.Location = new System.Drawing.Point(221, 56);
            this.textBoxSaving.Name = "textBoxSaving";
            this.textBoxSaving.Size = new System.Drawing.Size(197, 26);
            this.textBoxSaving.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Moving Amount:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeposit);
            this.groupBox2.Controls.Add(this.textBoxDeposit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 602);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 150);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(448, 44);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(196, 54);
            this.buttonDeposit.TabIndex = 49;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(221, 56);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(197, 26);
            this.textBoxDeposit.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Deposit Amount:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 758);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(657, 54);
            this.buttonExit.TabIndex = 50;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CustomerAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 850);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.groupBoxWithdraw);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerAccountControl";
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
    }
}