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
            this.btn_tiktok = new System.Windows.Forms.Button();
            this.btn_sortLD = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txtTikTokID = new System.Windows.Forms.TextBox();
            this.txtTikTokPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblttp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(168, 169);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(563, 20);
            this.txtConfig.TabIndex = 0;
            // 
            // txtLinkAcc
            // 
            this.txtLinkAcc.Location = new System.Drawing.Point(168, 132);
            this.txtLinkAcc.Name = "txtLinkAcc";
            this.txtLinkAcc.Size = new System.Drawing.Size(563, 20);
            this.txtLinkAcc.TabIndex = 1;
            // 
            // btn_acc
            // 
            this.btn_acc.Location = new System.Drawing.Point(737, 130);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(75, 23);
            this.btn_acc.TabIndex = 2;
            this.btn_acc.Text = "Brower";
            this.btn_acc.UseVisualStyleBackColor = true;
            // 
            // btn_ConfigB
            // 
            this.btn_ConfigB.Location = new System.Drawing.Point(737, 167);
            this.btn_ConfigB.Name = "btn_ConfigB";
            this.btn_ConfigB.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfigB.TabIndex = 3;
            this.btn_ConfigB.Text = "Brower";
            this.btn_ConfigB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File chứa tài khoản tiktok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File chứa config:";
            // 
            // txtWinCount
            // 
            this.txtWinCount.Location = new System.Drawing.Point(350, 57);
            this.txtWinCount.Name = "txtWinCount";
            this.txtWinCount.Size = new System.Drawing.Size(100, 20);
            this.txtWinCount.TabIndex = 6;
            this.txtWinCount.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số cửa số chạy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay:";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(350, 94);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 20);
            this.txtDelay.TabIndex = 8;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(513, 57);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 56);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_tiktok
            // 
            this.btn_tiktok.Location = new System.Drawing.Point(594, 56);
            this.btn_tiktok.Name = "btn_tiktok";
            this.btn_tiktok.Size = new System.Drawing.Size(75, 57);
            this.btn_tiktok.TabIndex = 11;
            this.btn_tiktok.Text = "Tiktok";
            this.btn_tiktok.UseVisualStyleBackColor = true;
            this.btn_tiktok.Click += new System.EventHandler(this.btn_tiktok_Click);
            // 
            // btn_sortLD
            // 
            this.btn_sortLD.Location = new System.Drawing.Point(675, 56);
            this.btn_sortLD.Name = "btn_sortLD";
            this.btn_sortLD.Size = new System.Drawing.Size(75, 57);
            this.btn_sortLD.TabIndex = 12;
            this.btn_sortLD.Text = "Sort";
            this.btn_sortLD.UseVisualStyleBackColor = true;
            this.btn_sortLD.Click += new System.EventHandler(this.btn_sortLD_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(756, 56);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 57);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close all";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txtTikTokID
            // 
            this.txtTikTokID.Location = new System.Drawing.Point(101, 56);
            this.txtTikTokID.Name = "txtTikTokID";
            this.txtTikTokID.Size = new System.Drawing.Size(100, 20);
            this.txtTikTokID.TabIndex = 14;
            // 
            // txtTikTokPass
            // 
            this.txtTikTokPass.Location = new System.Drawing.Point(101, 91);
            this.txtTikTokPass.Name = "txtTikTokPass";
            this.txtTikTokPass.Size = new System.Drawing.Size(100, 20);
            this.txtTikTokPass.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "TikTokID";
            // 
            // lblttp
            // 
            this.lblttp.AutoSize = true;
            this.lblttp.Location = new System.Drawing.Point(33, 94);
            this.lblttp.Name = "lblttp";
            this.lblttp.Size = new System.Drawing.Size(64, 13);
            this.lblttp.TabIndex = 17;
            this.lblttp.Text = "TikTokPass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 487);
            this.Controls.Add(this.lblttp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTikTokPass);
            this.Controls.Add(this.txtTikTokID);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_sortLD);
            this.Controls.Add(this.btn_tiktok);
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
        private System.Windows.Forms.Button btn_tiktok;
        private System.Windows.Forms.Button btn_sortLD;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txtTikTokID;
        private System.Windows.Forms.TextBox txtTikTokPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblttp;
    }
}

