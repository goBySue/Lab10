namespace Lab10
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.lblOriginDeposit = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAcctNum = new System.Windows.Forms.TextBox();
            this.txtBxOriDeposit = new System.Windows.Forms.TextBox();
            this.txtBxAddDep = new System.Windows.Forms.TextBox();
            this.txtBxWithdraw = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBxNewBal = new System.Windows.Forms.TextBox();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking Register";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(108, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum.ForeColor = System.Drawing.Color.White;
            this.lblAcctNum.Location = new System.Drawing.Point(108, 206);
            this.lblAcctNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(137, 25);
            this.lblAcctNum.TabIndex = 2;
            this.lblAcctNum.Text = "Account No: ";
            // 
            // lblOriginDeposit
            // 
            this.lblOriginDeposit.AutoSize = true;
            this.lblOriginDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginDeposit.ForeColor = System.Drawing.Color.White;
            this.lblOriginDeposit.Location = new System.Drawing.Point(108, 287);
            this.lblOriginDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginDeposit.Name = "lblOriginDeposit";
            this.lblOriginDeposit.Size = new System.Drawing.Size(166, 25);
            this.lblOriginDeposit.TabIndex = 3;
            this.lblOriginDeposit.Text = "Original Deposit";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.White;
            this.lblDeposit.Location = new System.Drawing.Point(160, 401);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(85, 25);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Visible = false;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.ForeColor = System.Drawing.Color.White;
            this.lblWithdraw.Location = new System.Drawing.Point(384, 401);
            this.lblWithdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(102, 25);
            this.lblWithdraw.TabIndex = 5;
            this.lblWithdraw.Text = "Withdraw";
            this.lblWithdraw.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(270, 117);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(250, 30);
            this.txtBxName.TabIndex = 6;
            // 
            // txtBxAcctNum
            // 
            this.txtBxAcctNum.Location = new System.Drawing.Point(329, 201);
            this.txtBxAcctNum.Name = "txtBxAcctNum";
            this.txtBxAcctNum.Size = new System.Drawing.Size(191, 30);
            this.txtBxAcctNum.TabIndex = 7;
            // 
            // txtBxOriDeposit
            // 
            this.txtBxOriDeposit.Location = new System.Drawing.Point(389, 282);
            this.txtBxOriDeposit.Name = "txtBxOriDeposit";
            this.txtBxOriDeposit.Size = new System.Drawing.Size(135, 30);
            this.txtBxOriDeposit.TabIndex = 8;
            this.txtBxOriDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxAddDep
            // 
            this.txtBxAddDep.Location = new System.Drawing.Point(113, 429);
            this.txtBxAddDep.Name = "txtBxAddDep";
            this.txtBxAddDep.Size = new System.Drawing.Size(195, 30);
            this.txtBxAddDep.TabIndex = 9;
            this.txtBxAddDep.Visible = false;
            // 
            // txtBxWithdraw
            // 
            this.txtBxWithdraw.Location = new System.Drawing.Point(329, 429);
            this.txtBxWithdraw.Name = "txtBxWithdraw";
            this.txtBxWithdraw.Size = new System.Drawing.Size(195, 30);
            this.txtBxWithdraw.TabIndex = 10;
            this.txtBxWithdraw.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 531);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 88);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 531);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 88);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBxNewBal
            // 
            this.txtBxNewBal.Location = new System.Drawing.Point(364, 356);
            this.txtBxNewBal.Name = "txtBxNewBal";
            this.txtBxNewBal.Size = new System.Drawing.Size(156, 30);
            this.txtBxNewBal.TabIndex = 14;
            this.txtBxNewBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxNewBal.Visible = false;
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBal.ForeColor = System.Drawing.Color.White;
            this.lblNewBal.Location = new System.Drawing.Point(106, 361);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(202, 25);
            this.lblNewBal.TabIndex = 15;
            this.lblNewBal.Text = "Your New Balance: ";
            this.lblNewBal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(590, 688);
            this.Controls.Add(this.lblNewBal);
            this.Controls.Add(this.txtBxNewBal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBxWithdraw);
            this.Controls.Add(this.txtBxAddDep);
            this.Controls.Add(this.txtBxOriDeposit);
            this.Controls.Add(this.txtBxAcctNum);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblOriginDeposit);
            this.Controls.Add(this.lblAcctNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.Label lblOriginDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAcctNum;
        private System.Windows.Forms.TextBox txtBxOriDeposit;
        private System.Windows.Forms.TextBox txtBxAddDep;
        private System.Windows.Forms.TextBox txtBxWithdraw;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBxNewBal;
        private System.Windows.Forms.Label lblNewBal;
    }
}

