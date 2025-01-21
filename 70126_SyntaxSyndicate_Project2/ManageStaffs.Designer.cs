namespace _70126_SyntaxSyndicate_Project2
{
    partial class ManageStaffs
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
            this.textBoxExtraHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.staffExtraHours = new System.Windows.Forms.Label();
            this.labelExtraHours = new System.Windows.Forms.Label();
            this.staffHours = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.staffID1 = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.groupBoxWithdraw = new System.Windows.Forms.GroupBox();
            this.buttonAddHours = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sph = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.staffUnpaidBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.esph = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hr = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.Label();
            this.extra = new System.Windows.Forms.Label();
            this.unbal = new System.Windows.Forms.Label();
            this.toSavehr = new System.Windows.Forms.Label();
            this.toSaveextra = new System.Windows.Forms.Label();
            this.groupBoxWithdraw.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxExtraHours
            // 
            this.textBoxExtraHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExtraHours.Location = new System.Drawing.Point(221, 109);
            this.textBoxExtraHours.Name = "textBoxExtraHours";
            this.textBoxExtraHours.Size = new System.Drawing.Size(197, 34);
            this.textBoxExtraHours.TabIndex = 48;
            this.textBoxExtraHours.TextChanged += new System.EventHandler(this.textBoxExtraHours_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Extra Hours:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(10, 533);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(657, 54);
            this.buttonExit.TabIndex = 59;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBoxHours
            // 
            this.textBoxHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHours.Location = new System.Drawing.Point(221, 56);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(197, 34);
            this.textBoxHours.TabIndex = 48;
            this.textBoxHours.TextChanged += new System.EventHandler(this.textBoxHours_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 47;
            this.label6.Text = "Normal Hour:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // staffExtraHours
            // 
            this.staffExtraHours.AutoSize = true;
            this.staffExtraHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffExtraHours.Location = new System.Drawing.Point(205, 129);
            this.staffExtraHours.Name = "staffExtraHours";
            this.staffExtraHours.Size = new System.Drawing.Size(24, 28);
            this.staffExtraHours.TabIndex = 54;
            this.staffExtraHours.Text = "0";
            this.staffExtraHours.Click += new System.EventHandler(this.staffExtraHours_Click);
            // 
            // labelExtraHours
            // 
            this.labelExtraHours.AutoSize = true;
            this.labelExtraHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraHours.Location = new System.Drawing.Point(6, 132);
            this.labelExtraHours.Name = "labelExtraHours";
            this.labelExtraHours.Size = new System.Drawing.Size(116, 28);
            this.labelExtraHours.TabIndex = 53;
            this.labelExtraHours.Text = "Extra Hours:";
            this.labelExtraHours.Click += new System.EventHandler(this.labelExtraHours_Click);
            // 
            // staffHours
            // 
            this.staffHours.AutoSize = true;
            this.staffHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffHours.Location = new System.Drawing.Point(205, 83);
            this.staffHours.Name = "staffHours";
            this.staffHours.Size = new System.Drawing.Size(24, 28);
            this.staffHours.TabIndex = 52;
            this.staffHours.Text = "0";
            this.staffHours.Click += new System.EventHandler(this.unpaidHours_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(6, 86);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(137, 28);
            this.labelBalance.TabIndex = 51;
            this.labelBalance.Text = "Unpaid Hours:";
            this.labelBalance.Click += new System.EventHandler(this.labelBalance_Click);
            // 
            // staffID1
            // 
            this.staffID1.AutoSize = true;
            this.staffID1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID1.Location = new System.Drawing.Point(208, 39);
            this.staffID1.Name = "staffID1";
            this.staffID1.Size = new System.Drawing.Size(48, 28);
            this.staffID1.TabIndex = 50;
            this.staffID1.Text = "null";
            this.staffID1.Click += new System.EventHandler(this.staffID1_Click);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(6, 42);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(79, 28);
            this.labelCustomerID.TabIndex = 48;
            this.labelCustomerID.Text = "Staff ID:";
            this.labelCustomerID.Click += new System.EventHandler(this.labelCustomerID_Click);
            // 
            // groupBoxWithdraw
            // 
            this.groupBoxWithdraw.Controls.Add(this.buttonAddHours);
            this.groupBoxWithdraw.Controls.Add(this.textBoxExtraHours);
            this.groupBoxWithdraw.Controls.Add(this.label1);
            this.groupBoxWithdraw.Controls.Add(this.textBoxHours);
            this.groupBoxWithdraw.Controls.Add(this.label6);
            this.groupBoxWithdraw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWithdraw.Location = new System.Drawing.Point(12, 349);
            this.groupBoxWithdraw.Name = "groupBoxWithdraw";
            this.groupBoxWithdraw.Size = new System.Drawing.Size(657, 150);
            this.groupBoxWithdraw.TabIndex = 61;
            this.groupBoxWithdraw.TabStop = false;
            this.groupBoxWithdraw.Text = "Add Hours";
            this.groupBoxWithdraw.Enter += new System.EventHandler(this.groupBoxWithdraw_Enter);
            // 
            // buttonAddHours
            // 
            this.buttonAddHours.BackColor = System.Drawing.Color.White;
            this.buttonAddHours.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonAddHours.FlatAppearance.BorderSize = 2;
            this.buttonAddHours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonAddHours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonAddHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddHours.ForeColor = System.Drawing.Color.Indigo;
            this.buttonAddHours.Location = new System.Drawing.Point(449, 70);
            this.buttonAddHours.Name = "buttonAddHours";
            this.buttonAddHours.Size = new System.Drawing.Size(196, 54);
            this.buttonAddHours.TabIndex = 50;
            this.buttonAddHours.Text = "Add Hours";
            this.buttonAddHours.UseVisualStyleBackColor = false;
            this.buttonAddHours.Click += new System.EventHandler(this.buttonAddHours_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPay);
            this.groupBox1.Controls.Add(this.staffUnpaidBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.staffExtraHours);
            this.groupBox1.Controls.Add(this.labelExtraHours);
            this.groupBox1.Controls.Add(this.staffHours);
            this.groupBox1.Controls.Add(this.labelBalance);
            this.groupBox1.Controls.Add(this.staffID1);
            this.groupBox1.Controls.Add(this.labelCustomerID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 222);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sph
            // 
            this.sph.AutoSize = true;
            this.sph.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sph.Location = new System.Drawing.Point(621, 55);
            this.sph.Name = "sph";
            this.sph.Size = new System.Drawing.Size(16, 21);
            this.sph.TabIndex = 58;
            this.sph.Text = "-";
            this.sph.Click += new System.EventHandler(this.sph_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Indigo;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(449, 83);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(196, 54);
            this.buttonPay.TabIndex = 57;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // staffUnpaidBalance
            // 
            this.staffUnpaidBalance.AutoSize = true;
            this.staffUnpaidBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUnpaidBalance.Location = new System.Drawing.Point(208, 176);
            this.staffUnpaidBalance.Name = "staffUnpaidBalance";
            this.staffUnpaidBalance.Size = new System.Drawing.Size(24, 28);
            this.staffUnpaidBalance.TabIndex = 56;
            this.staffUnpaidBalance.Text = "0";
            this.staffUnpaidBalance.Click += new System.EventHandler(this.staffUnpaidBalance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Unpaid Balance:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // esph
            // 
            this.esph.AutoSize = true;
            this.esph.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esph.Location = new System.Drawing.Point(621, 27);
            this.esph.Name = "esph";
            this.esph.Size = new System.Drawing.Size(16, 21);
            this.esph.TabIndex = 62;
            this.esph.Text = "-";
            this.esph.Click += new System.EventHandler(this.esph_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(684, 94);
            this.button1.TabIndex = 63;
            this.button1.Text = "Staff Control";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hr
            // 
            this.hr.AutoSize = true;
            this.hr.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr.Location = new System.Drawing.Point(621, 34);
            this.hr.Name = "hr";
            this.hr.Size = new System.Drawing.Size(16, 21);
            this.hr.TabIndex = 64;
            this.hr.Text = "-";
            this.hr.Click += new System.EventHandler(this.hr_Click);
            // 
            // bal
            // 
            this.bal.AutoSize = true;
            this.bal.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal.Location = new System.Drawing.Point(621, 48);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(16, 21);
            this.bal.TabIndex = 63;
            this.bal.Text = "-";
            this.bal.Click += new System.EventHandler(this.bal_Click);
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra.Location = new System.Drawing.Point(621, 48);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(16, 21);
            this.extra.TabIndex = 65;
            this.extra.Text = "-";
            this.extra.Click += new System.EventHandler(this.extra_Click);
            // 
            // unbal
            // 
            this.unbal.AutoSize = true;
            this.unbal.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbal.Location = new System.Drawing.Point(609, 48);
            this.unbal.Name = "unbal";
            this.unbal.Size = new System.Drawing.Size(16, 21);
            this.unbal.TabIndex = 66;
            this.unbal.Text = "-";
            this.unbal.Click += new System.EventHandler(this.unbal_Click);
            // 
            // toSavehr
            // 
            this.toSavehr.AutoSize = true;
            this.toSavehr.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSavehr.Location = new System.Drawing.Point(587, 48);
            this.toSavehr.Name = "toSavehr";
            this.toSavehr.Size = new System.Drawing.Size(16, 21);
            this.toSavehr.TabIndex = 67;
            this.toSavehr.Text = "-";
            this.toSavehr.Click += new System.EventHandler(this.toSavehr_Click);
            // 
            // toSaveextra
            // 
            this.toSaveextra.AutoSize = true;
            this.toSaveextra.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSaveextra.Location = new System.Drawing.Point(609, 48);
            this.toSaveextra.Name = "toSaveextra";
            this.toSaveextra.Size = new System.Drawing.Size(16, 21);
            this.toSaveextra.TabIndex = 68;
            this.toSaveextra.Text = "-";
            this.toSaveextra.Click += new System.EventHandler(this.toSaveextra_Click);
            // 
            // ManageStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toSaveextra);
            this.Controls.Add(this.toSavehr);
            this.Controls.Add(this.unbal);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.hr);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.esph);
            this.Controls.Add(this.sph);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxWithdraw);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageStaffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStaffs";
            this.groupBoxWithdraw.ResumeLayout(false);
            this.groupBoxWithdraw.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxExtraHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label staffExtraHours;
        private System.Windows.Forms.Label labelExtraHours;
        private System.Windows.Forms.Label staffHours;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label staffID1;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.GroupBox groupBoxWithdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label staffUnpaidBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddHours;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label sph;
        private System.Windows.Forms.Label esph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hr;
        private System.Windows.Forms.Label bal;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.Label unbal;
        private System.Windows.Forms.Label toSavehr;
        private System.Windows.Forms.Label toSaveextra;
    }
}