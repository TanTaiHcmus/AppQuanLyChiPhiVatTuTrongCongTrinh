namespace QuanLyCongTrinh
{
    partial class QuanLyCongTrinhXayDUng
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
            this.txt_AppName = new System.Windows.Forms.Label();
            this.btn_QLCPVT = new System.Windows.Forms.Button();
            this.btn_NKCT = new System.Windows.Forms.Button();
            this.btn_QLCPDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AppName
            // 
            this.txt_AppName.AutoEllipsis = true;
            this.txt_AppName.AutoSize = true;
            this.txt_AppName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AppName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_AppName.Location = new System.Drawing.Point(270, 75);
            this.txt_AppName.Name = "txt_AppName";
            this.txt_AppName.Size = new System.Drawing.Size(634, 51);
            this.txt_AppName.TabIndex = 0;
            this.txt_AppName.Text = "Quản Lý Công Trình Xây Dựng";
            // 
            // btn_QLCPVT
            // 
            this.btn_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLCPVT.ForeColor = System.Drawing.Color.Red;
            this.btn_QLCPVT.Location = new System.Drawing.Point(351, 218);
            this.btn_QLCPVT.Name = "btn_QLCPVT";
            this.btn_QLCPVT.Padding = new System.Windows.Forms.Padding(10);
            this.btn_QLCPVT.Size = new System.Drawing.Size(428, 60);
            this.btn_QLCPVT.TabIndex = 1;
            this.btn_QLCPVT.Text = "Quản Lý Chi Phí Vật Tư";
            this.btn_QLCPVT.UseVisualStyleBackColor = true;
            this.btn_QLCPVT.Click += new System.EventHandler(this.btn_QLCPVT_Click);
            // 
            // btn_NKCT
            // 
            this.btn_NKCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NKCT.ForeColor = System.Drawing.Color.Red;
            this.btn_NKCT.Location = new System.Drawing.Point(351, 341);
            this.btn_NKCT.Name = "btn_NKCT";
            this.btn_NKCT.Padding = new System.Windows.Forms.Padding(10);
            this.btn_NKCT.Size = new System.Drawing.Size(428, 60);
            this.btn_NKCT.TabIndex = 2;
            this.btn_NKCT.Text = "Nhật Ký Công Trình";
            this.btn_NKCT.UseVisualStyleBackColor = true;
            // 
            // btn_QLCPDN
            // 
            this.btn_QLCPDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLCPDN.ForeColor = System.Drawing.Color.Red;
            this.btn_QLCPDN.Location = new System.Drawing.Point(351, 461);
            this.btn_QLCPDN.Name = "btn_QLCPDN";
            this.btn_QLCPDN.Padding = new System.Windows.Forms.Padding(10);
            this.btn_QLCPDN.Size = new System.Drawing.Size(428, 60);
            this.btn_QLCPDN.TabIndex = 3;
            this.btn_QLCPDN.Text = "Quản Lý Chi Phí Điện Nước";
            this.btn_QLCPDN.UseVisualStyleBackColor = true;
            // 
            // QuanLyCongTrinhXayDUng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 602);
            this.Controls.Add(this.btn_QLCPDN);
            this.Controls.Add(this.btn_NKCT);
            this.Controls.Add(this.btn_QLCPVT);
            this.Controls.Add(this.txt_AppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuanLyCongTrinhXayDUng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Công Trình Xây Dựng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyCongTrinhXayDUng_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_AppName;
        private System.Windows.Forms.Button btn_QLCPVT;
        private System.Windows.Forms.Button btn_NKCT;
        private System.Windows.Forms.Button btn_QLCPDN;
    }
}

