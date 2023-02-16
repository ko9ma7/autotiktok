namespace AutoTiktok
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
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.txtLinkAcc = new System.Windows.Forms.TextBox();
            this.btn_acc = new System.Windows.Forms.Button();
            this.btn_ConfigB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWinCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(159, 697);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(563, 20);
            this.txtConfig.TabIndex = 0;
            // 
            // txtLinkAcc
            // 
            this.txtLinkAcc.Location = new System.Drawing.Point(159, 660);
            this.txtLinkAcc.Name = "txtLinkAcc";
            this.txtLinkAcc.Size = new System.Drawing.Size(563, 20);
            this.txtLinkAcc.TabIndex = 1;
            // 
            // btn_acc
            // 
            this.btn_acc.Location = new System.Drawing.Point(728, 658);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(75, 23);
            this.btn_acc.TabIndex = 2;
            this.btn_acc.Text = "Brower";
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_ConfigB
            // 
            this.btn_ConfigB.Location = new System.Drawing.Point(728, 695);
            this.btn_ConfigB.Name = "btn_ConfigB";
            this.btn_ConfigB.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfigB.TabIndex = 3;
            this.btn_ConfigB.Text = "Brower";
            this.btn_ConfigB.UseVisualStyleBackColor = true;
            this.btn_ConfigB.Click += new System.EventHandler(this.btn_ConfigB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File chứa tài khoản tiktok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File chứa config:";
            // 
            // txtWinCount
            // 
            this.txtWinCount.Location = new System.Drawing.Point(909, 660);
            this.txtWinCount.Name = "txtWinCount";
            this.txtWinCount.Size = new System.Drawing.Size(100, 20);
            this.txtWinCount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(819, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số cửa số chạy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 700);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay:";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(909, 697);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 20);
            this.txtDelay.TabIndex = 8;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(1067, 657);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 56);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWinCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConfigB);
            this.Controls.Add(this.btn_acc);
            this.Controls.Add(this.txtLinkAcc);
            this.Controls.Add(this.txtConfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.TextBox txtLinkAcc;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Button btn_ConfigB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWinCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Button btn_Start;
    }
}

