namespace Finances
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lbOwnerNameInfo = new System.Windows.Forms.Label();
            this.lbOwnerAmountInfo = new System.Windows.Forms.Label();
            this.btnSetOwnerName = new System.Windows.Forms.Button();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetName = new System.Windows.Forms.TextBox();
            this.tbAddMoney = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSetName2 = new System.Windows.Forms.TextBox();
            this.btnAddMoney2 = new System.Windows.Forms.Button();
            this.btnSetOwnerName2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOwnerAmountInfo2 = new System.Windows.Forms.Label();
            this.lbOwnerNameInfo2 = new System.Windows.Forms.Label();
            this.btnShowInfo2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAddMoney2 = new System.Windows.Forms.TextBox();
            this.btnWithdraw1to2 = new System.Windows.Forms.Button();
            this.btnWithdraw2to1 = new System.Windows.Forms.Button();
            this.tbWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lbWithdrawInfo = new System.Windows.Forms.Label();
            this.lbWithdrawInfo2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowInfo.Location = new System.Drawing.Point(51, 58);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(121, 42);
            this.btnShowInfo.TabIndex = 0;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lbOwnerNameInfo
            // 
            this.lbOwnerNameInfo.AutoSize = true;
            this.lbOwnerNameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbOwnerNameInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOwnerNameInfo.Location = new System.Drawing.Point(207, 49);
            this.lbOwnerNameInfo.Name = "lbOwnerNameInfo";
            this.lbOwnerNameInfo.Size = new System.Drawing.Size(149, 21);
            this.lbOwnerNameInfo.TabIndex = 1;
            this.lbOwnerNameInfo.Text = "Wallet belongs to .....";
            // 
            // lbOwnerAmountInfo
            // 
            this.lbOwnerAmountInfo.AutoSize = true;
            this.lbOwnerAmountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbOwnerAmountInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOwnerAmountInfo.Location = new System.Drawing.Point(207, 89);
            this.lbOwnerAmountInfo.Name = "lbOwnerAmountInfo";
            this.lbOwnerAmountInfo.Size = new System.Drawing.Size(200, 21);
            this.lbOwnerAmountInfo.TabIndex = 2;
            this.lbOwnerAmountInfo.Text = "Amount of money is ... euro";
            // 
            // btnSetOwnerName
            // 
            this.btnSetOwnerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetOwnerName.Location = new System.Drawing.Point(51, 176);
            this.btnSetOwnerName.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetOwnerName.Name = "btnSetOwnerName";
            this.btnSetOwnerName.Size = new System.Drawing.Size(156, 48);
            this.btnSetOwnerName.TabIndex = 3;
            this.btnSetOwnerName.Text = "Set owner\'s name";
            this.btnSetOwnerName.UseVisualStyleBackColor = true;
            this.btnSetOwnerName.Click += new System.EventHandler(this.btnSetOwnerName_Click);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMoney.Location = new System.Drawing.Point(51, 253);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(156, 44);
            this.btnAddMoney.TabIndex = 4;
            this.btnAddMoney.Text = "Add money ";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(236, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "amount to add:";
            // 
            // tbSetName
            // 
            this.tbSetName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSetName.Location = new System.Drawing.Point(236, 187);
            this.tbSetName.Name = "tbSetName";
            this.tbSetName.Size = new System.Drawing.Size(180, 29);
            this.tbSetName.TabIndex = 6;
            // 
            // tbAddMoney
            // 
            this.tbAddMoney.Location = new System.Drawing.Point(315, 115);
            this.tbAddMoney.Name = "tbAddMoney";
            this.tbAddMoney.Size = new System.Drawing.Size(59, 23);
            this.tbAddMoney.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lbWithdrawInfo);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.tbAddMoney);
            this.groupBox2.Location = new System.Drawing.Point(42, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(461, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "amount to withdraw: ";
            // 
            // tbSetName2
            // 
            this.tbSetName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSetName2.Location = new System.Drawing.Point(782, 187);
            this.tbSetName2.Name = "tbSetName2";
            this.tbSetName2.Size = new System.Drawing.Size(180, 29);
            this.tbSetName2.TabIndex = 16;
            // 
            // btnAddMoney2
            // 
            this.btnAddMoney2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMoney2.Location = new System.Drawing.Point(597, 253);
            this.btnAddMoney2.Name = "btnAddMoney2";
            this.btnAddMoney2.Size = new System.Drawing.Size(156, 44);
            this.btnAddMoney2.TabIndex = 14;
            this.btnAddMoney2.Text = "Add money ";
            this.btnAddMoney2.UseVisualStyleBackColor = true;
            this.btnAddMoney2.Click += new System.EventHandler(this.btnAddMoney2_Click);
            // 
            // btnSetOwnerName2
            // 
            this.btnSetOwnerName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetOwnerName2.Location = new System.Drawing.Point(597, 176);
            this.btnSetOwnerName2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetOwnerName2.Name = "btnSetOwnerName2";
            this.btnSetOwnerName2.Size = new System.Drawing.Size(156, 48);
            this.btnSetOwnerName2.TabIndex = 13;
            this.btnSetOwnerName2.Text = "Set owner\'s name";
            this.btnSetOwnerName2.UseVisualStyleBackColor = true;
            this.btnSetOwnerName2.Click += new System.EventHandler(this.btnSetOwnerName2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(782, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "amount to add:";
            // 
            // lbOwnerAmountInfo2
            // 
            this.lbOwnerAmountInfo2.AutoSize = true;
            this.lbOwnerAmountInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbOwnerAmountInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOwnerAmountInfo2.Location = new System.Drawing.Point(753, 89);
            this.lbOwnerAmountInfo2.Name = "lbOwnerAmountInfo2";
            this.lbOwnerAmountInfo2.Size = new System.Drawing.Size(200, 21);
            this.lbOwnerAmountInfo2.TabIndex = 12;
            this.lbOwnerAmountInfo2.Text = "Amount of money is ... euro";
            // 
            // lbOwnerNameInfo2
            // 
            this.lbOwnerNameInfo2.AutoSize = true;
            this.lbOwnerNameInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbOwnerNameInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOwnerNameInfo2.Location = new System.Drawing.Point(753, 49);
            this.lbOwnerNameInfo2.Name = "lbOwnerNameInfo2";
            this.lbOwnerNameInfo2.Size = new System.Drawing.Size(149, 21);
            this.lbOwnerNameInfo2.TabIndex = 11;
            this.lbOwnerNameInfo2.Text = "Wallet belongs to .....";
            // 
            // btnShowInfo2
            // 
            this.btnShowInfo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowInfo2.Location = new System.Drawing.Point(597, 58);
            this.btnShowInfo2.Name = "btnShowInfo2";
            this.btnShowInfo2.Size = new System.Drawing.Size(121, 42);
            this.btnShowInfo2.TabIndex = 10;
            this.btnShowInfo2.Text = "Show info";
            this.btnShowInfo2.UseVisualStyleBackColor = true;
            this.btnShowInfo2.Click += new System.EventHandler(this.btnShowInfo2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.lbWithdrawInfo2);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(588, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 125);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox4.Controls.Add(this.tbAddMoney2);
            this.groupBox4.Location = new System.Drawing.Point(588, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 172);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // tbAddMoney2
            // 
            this.tbAddMoney2.Location = new System.Drawing.Point(315, 115);
            this.tbAddMoney2.Name = "tbAddMoney2";
            this.tbAddMoney2.Size = new System.Drawing.Size(59, 23);
            this.tbAddMoney2.TabIndex = 7;
            // 
            // btnWithdraw1to2
            // 
            this.btnWithdraw1to2.Location = new System.Drawing.Point(492, 176);
            this.btnWithdraw1to2.Name = "btnWithdraw1to2";
            this.btnWithdraw1to2.Size = new System.Drawing.Size(62, 40);
            this.btnWithdraw1to2.TabIndex = 19;
            this.btnWithdraw1to2.Text = ">>";
            this.btnWithdraw1to2.UseVisualStyleBackColor = true;
            this.btnWithdraw1to2.Click += new System.EventHandler(this.btnWithdraw1to2_Click);
            // 
            // btnWithdraw2to1
            // 
            this.btnWithdraw2to1.Location = new System.Drawing.Point(492, 267);
            this.btnWithdraw2to1.Name = "btnWithdraw2to1";
            this.btnWithdraw2to1.Size = new System.Drawing.Size(62, 39);
            this.btnWithdraw2to1.TabIndex = 20;
            this.btnWithdraw2to1.Text = "<<";
            this.btnWithdraw2to1.UseVisualStyleBackColor = true;
            this.btnWithdraw2to1.Click += new System.EventHandler(this.btnWithdraw2to1_Click);
            // 
            // tbWithdrawAmount
            // 
            this.tbWithdrawAmount.Location = new System.Drawing.Point(492, 237);
            this.tbWithdrawAmount.Name = "tbWithdrawAmount";
            this.tbWithdrawAmount.Size = new System.Drawing.Size(62, 23);
            this.tbWithdrawAmount.TabIndex = 12;
            // 
            // lbWithdrawInfo
            // 
            this.lbWithdrawInfo.AutoSize = true;
            this.lbWithdrawInfo.Location = new System.Drawing.Point(32, 100);
            this.lbWithdrawInfo.Name = "lbWithdrawInfo";
            this.lbWithdrawInfo.Size = new System.Drawing.Size(0, 15);
            this.lbWithdrawInfo.TabIndex = 0;
            // 
            // lbWithdrawInfo2
            // 
            this.lbWithdrawInfo2.AutoSize = true;
            this.lbWithdrawInfo2.Location = new System.Drawing.Point(9, 100);
            this.lbWithdrawInfo2.Name = "lbWithdrawInfo2";
            this.lbWithdrawInfo2.Size = new System.Drawing.Size(0, 15);
            this.lbWithdrawInfo2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 358);
            this.Controls.Add(this.tbWithdrawAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdraw2to1);
            this.Controls.Add(this.btnWithdraw1to2);
            this.Controls.Add(this.tbSetName2);
            this.Controls.Add(this.btnAddMoney2);
            this.Controls.Add(this.btnSetOwnerName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOwnerAmountInfo2);
            this.Controls.Add(this.lbOwnerNameInfo2);
            this.Controls.Add(this.btnShowInfo2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tbSetName);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.btnSetOwnerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOwnerAmountInfo);
            this.Controls.Add(this.lbOwnerNameInfo);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "a";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lbOwnerNameInfo;
        private System.Windows.Forms.Label lbOwnerAmountInfo;
        private System.Windows.Forms.Button btnSetOwnerName;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSetName;
        private System.Windows.Forms.TextBox tbAddMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSetName2;
        private System.Windows.Forms.Button btnAddMoney2;
        private System.Windows.Forms.Button btnSetOwnerName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOwnerAmountInfo2;
        private System.Windows.Forms.Label lbOwnerNameInfo2;
        private System.Windows.Forms.Button btnShowInfo2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAddMoney2;
        private System.Windows.Forms.Button btnWithdraw1to2;
        private System.Windows.Forms.Button btnWithdraw2to1;
        private System.Windows.Forms.TextBox tbWithdrawAmount;
        private System.Windows.Forms.Label lbWithdrawInfo;
        private System.Windows.Forms.Label lbWithdrawInfo2;
    }
}
