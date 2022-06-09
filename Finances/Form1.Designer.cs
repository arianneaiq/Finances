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
            this.tbWithdrawMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.tbWithdrawMoney);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnWithdrawMoney);
            this.groupBox2.Controls.Add(this.tbAddMoney);
            this.groupBox2.Location = new System.Drawing.Point(42, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 235);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbWithdrawMoney
            // 
            this.tbWithdrawMoney.Location = new System.Drawing.Point(348, 188);
            this.tbWithdrawMoney.Name = "tbWithdrawMoney";
            this.tbWithdrawMoney.Size = new System.Drawing.Size(59, 23);
            this.tbWithdrawMoney.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "amount to withdraw: ";
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdrawMoney.Location = new System.Drawing.Point(9, 176);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(156, 44);
            this.btnWithdrawMoney.TabIndex = 10;
            this.btnWithdrawMoney.Text = "Withdraw money";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 408);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.TextBox tbWithdrawMoney;
    }
}
