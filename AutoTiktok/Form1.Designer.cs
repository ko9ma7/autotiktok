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
            this.SuspendLayout();
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(97, 697);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(563, 20);
            this.txtConfig.TabIndex = 0;
            // 
            // txtLinkAcc
            // 
            this.txtLinkAcc.Location = new System.Drawing.Point(97, 660);
            this.txtLinkAcc.Name = "txtLinkAcc";
            this.txtLinkAcc.Size = new System.Drawing.Size(563, 20);
            this.txtLinkAcc.TabIndex = 1;
            // 
            // btn_acc
            // 
            this.btn_acc.Location = new System.Drawing.Point(666, 658);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(75, 23);
            this.btn_acc.TabIndex = 2;
            this.btn_acc.Text = "Brower";
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_ConfigB
            // 
            this.btn_ConfigB.Location = new System.Drawing.Point(666, 695);
            this.btn_ConfigB.Name = "btn_ConfigB";
            this.btn_ConfigB.Size = new System.Drawing.Size(75, 23);
            this.btn_ConfigB.TabIndex = 3;
            this.btn_ConfigB.Text = "Brower";
            this.btn_ConfigB.UseVisualStyleBackColor = true;
            this.btn_ConfigB.Click += new System.EventHandler(this.btn_ConfigB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
    }
}

