namespace GetHardWareID
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_safetycode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(158)))));
            this.label6.Location = new System.Drawing.Point(123, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "硬件唯一码生成器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "以下为本机特定生成的安全码，此安全码对本机具有特定性和唯一性。";
            // 
            // tb_safetycode
            // 
            this.tb_safetycode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_safetycode.Location = new System.Drawing.Point(65, 152);
            this.tb_safetycode.Multiline = true;
            this.tb_safetycode.Name = "tb_safetycode";
            this.tb_safetycode.Size = new System.Drawing.Size(366, 78);
            this.tb_safetycode.TabIndex = 14;
            this.tb_safetycode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "请复制，并将安全码发送给系统管理员";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(390, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "（V 1.0）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_safetycode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "华企动力ERP安全码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_safetycode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

