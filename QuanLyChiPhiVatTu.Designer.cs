namespace QuanLyCongTrinh
{
    partial class QuanLyChiPhiVatTu
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
            this.txt_AppName = new System.Windows.Forms.Label();
            this.grid_QLCPVT = new System.Windows.Forms.DataGridView();
            this.btn_insertQLCPVT = new System.Windows.Forms.Button();
            this.btn_updateQLCPVT = new System.Windows.Forms.Button();
            this.btn_deleteQLCPVT = new System.Windows.Forms.Button();
            this.btn_searchQLCPVT = new System.Windows.Forms.Button();
            this.btn_export_QLCPVT = new System.Windows.Forms.Button();
            this.cbx_QLCPVT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_congtrinh_QLCPVT = new System.Windows.Forms.Label();
            this.txt_tencongtrinh_QLCPVT = new System.Windows.Forms.TextBox();
            this.btn_add_congtrinh_QLCPVT = new System.Windows.Forms.Button();
            this.btn_delete_congtrinh_QLCPVT = new System.Windows.Forms.Button();
            this.txt_link_QLCPVT = new System.Windows.Forms.TextBox();
            this.lbl_link_QLCPVT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_QLCPVT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // txt_AppName
            // 
            this.txt_AppName.AutoSize = true;
            this.txt_AppName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AppName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_AppName.Location = new System.Drawing.Point(399, 18);
            this.txt_AppName.Name = "txt_AppName";
            this.txt_AppName.Size = new System.Drawing.Size(382, 38);
            this.txt_AppName.TabIndex = 1;
            this.txt_AppName.Text = "Quản Lý Chi Phí Vật Tư";
            // 
            // grid_QLCPVT
            // 
            this.grid_QLCPVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_QLCPVT.Location = new System.Drawing.Point(12, 164);
            this.grid_QLCPVT.Name = "grid_QLCPVT";
            this.grid_QLCPVT.RowTemplate.Height = 24;
            this.grid_QLCPVT.Size = new System.Drawing.Size(1102, 355);
            this.grid_QLCPVT.TabIndex = 0;
            // 
            // btn_insertQLCPVT
            // 
            this.btn_insertQLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertQLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_insertQLCPVT.Location = new System.Drawing.Point(87, 538);
            this.btn_insertQLCPVT.Name = "btn_insertQLCPVT";
            this.btn_insertQLCPVT.Size = new System.Drawing.Size(130, 43);
            this.btn_insertQLCPVT.TabIndex = 1;
            this.btn_insertQLCPVT.Text = "Insert";
            this.btn_insertQLCPVT.UseVisualStyleBackColor = true;
            this.btn_insertQLCPVT.Click += new System.EventHandler(this.btn_insertQLCPVT_Click);
            // 
            // btn_updateQLCPVT
            // 
            this.btn_updateQLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateQLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateQLCPVT.Location = new System.Drawing.Point(366, 538);
            this.btn_updateQLCPVT.Name = "btn_updateQLCPVT";
            this.btn_updateQLCPVT.Size = new System.Drawing.Size(130, 43);
            this.btn_updateQLCPVT.TabIndex = 2;
            this.btn_updateQLCPVT.Text = "Update";
            this.btn_updateQLCPVT.UseVisualStyleBackColor = true;
            this.btn_updateQLCPVT.Click += new System.EventHandler(this.btn_updateQLCPVT_Click);
            // 
            // btn_deleteQLCPVT
            // 
            this.btn_deleteQLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteQLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deleteQLCPVT.Location = new System.Drawing.Point(651, 538);
            this.btn_deleteQLCPVT.Name = "btn_deleteQLCPVT";
            this.btn_deleteQLCPVT.Size = new System.Drawing.Size(130, 43);
            this.btn_deleteQLCPVT.TabIndex = 3;
            this.btn_deleteQLCPVT.Text = "Delete";
            this.btn_deleteQLCPVT.UseVisualStyleBackColor = true;
            this.btn_deleteQLCPVT.Click += new System.EventHandler(this.btn_deleteQLCPVT_Click);
            // 
            // btn_searchQLCPVT
            // 
            this.btn_searchQLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchQLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_searchQLCPVT.Location = new System.Drawing.Point(912, 538);
            this.btn_searchQLCPVT.Name = "btn_searchQLCPVT";
            this.btn_searchQLCPVT.Size = new System.Drawing.Size(130, 43);
            this.btn_searchQLCPVT.TabIndex = 4;
            this.btn_searchQLCPVT.Text = "Search";
            this.btn_searchQLCPVT.UseVisualStyleBackColor = true;
            this.btn_searchQLCPVT.Click += new System.EventHandler(this.btn_searchQLCPVT_Click);
            // 
            // btn_export_QLCPVT
            // 
            this.btn_export_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_QLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_export_QLCPVT.Location = new System.Drawing.Point(912, 112);
            this.btn_export_QLCPVT.Name = "btn_export_QLCPVT";
            this.btn_export_QLCPVT.Size = new System.Drawing.Size(163, 36);
            this.btn_export_QLCPVT.TabIndex = 5;
            this.btn_export_QLCPVT.Text = "Xuất file Excel";
            this.btn_export_QLCPVT.UseVisualStyleBackColor = true;
            this.btn_export_QLCPVT.Click += new System.EventHandler(this.btn_export_QLCPVT_Click);
            // 
            // cbx_QLCPVT
            // 
            this.cbx_QLCPVT.FormattingEnabled = true;
            this.cbx_QLCPVT.Location = new System.Drawing.Point(187, 82);
            this.cbx_QLCPVT.Name = "cbx_QLCPVT";
            this.cbx_QLCPVT.Size = new System.Drawing.Size(297, 24);
            this.cbx_QLCPVT.TabIndex = 6;
            this.cbx_QLCPVT.SelectedIndexChanged += new System.EventHandler(this.cbx_QLCPVT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Công trình";
            // 
            // lbl_congtrinh_QLCPVT
            // 
            this.lbl_congtrinh_QLCPVT.AutoSize = true;
            this.lbl_congtrinh_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congtrinh_QLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_congtrinh_QLCPVT.Location = new System.Drawing.Point(12, 123);
            this.lbl_congtrinh_QLCPVT.Name = "lbl_congtrinh_QLCPVT";
            this.lbl_congtrinh_QLCPVT.Size = new System.Drawing.Size(151, 25);
            this.lbl_congtrinh_QLCPVT.TabIndex = 8;
            this.lbl_congtrinh_QLCPVT.Text = "Tên công trình";
            // 
            // txt_tencongtrinh_QLCPVT
            // 
            this.txt_tencongtrinh_QLCPVT.Location = new System.Drawing.Point(187, 122);
            this.txt_tencongtrinh_QLCPVT.Multiline = true;
            this.txt_tencongtrinh_QLCPVT.Name = "txt_tencongtrinh_QLCPVT";
            this.txt_tencongtrinh_QLCPVT.Size = new System.Drawing.Size(297, 26);
            this.txt_tencongtrinh_QLCPVT.TabIndex = 9;
            // 
            // btn_add_congtrinh_QLCPVT
            // 
            this.btn_add_congtrinh_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_congtrinh_QLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add_congtrinh_QLCPVT.Location = new System.Drawing.Point(520, 112);
            this.btn_add_congtrinh_QLCPVT.Name = "btn_add_congtrinh_QLCPVT";
            this.btn_add_congtrinh_QLCPVT.Size = new System.Drawing.Size(98, 36);
            this.btn_add_congtrinh_QLCPVT.TabIndex = 10;
            this.btn_add_congtrinh_QLCPVT.Text = "Add";
            this.btn_add_congtrinh_QLCPVT.UseVisualStyleBackColor = true;
            this.btn_add_congtrinh_QLCPVT.Click += new System.EventHandler(this.add_congtrinh_QLCPVT_Click);
            // 
            // btn_delete_congtrinh_QLCPVT
            // 
            this.btn_delete_congtrinh_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_congtrinh_QLCPVT.ForeColor = System.Drawing.Color.Red;
            this.btn_delete_congtrinh_QLCPVT.Location = new System.Drawing.Point(684, 112);
            this.btn_delete_congtrinh_QLCPVT.Name = "btn_delete_congtrinh_QLCPVT";
            this.btn_delete_congtrinh_QLCPVT.Size = new System.Drawing.Size(184, 36);
            this.btn_delete_congtrinh_QLCPVT.TabIndex = 11;
            this.btn_delete_congtrinh_QLCPVT.Text = "Xóa công trình";
            this.btn_delete_congtrinh_QLCPVT.UseVisualStyleBackColor = true;
            this.btn_delete_congtrinh_QLCPVT.Click += new System.EventHandler(this.btn_delete_congtrinh_QLCPVT_Click);
            // 
            // txt_link_QLCPVT
            // 
            this.txt_link_QLCPVT.Location = new System.Drawing.Point(684, 70);
            this.txt_link_QLCPVT.Multiline = true;
            this.txt_link_QLCPVT.Name = "txt_link_QLCPVT";
            this.txt_link_QLCPVT.Size = new System.Drawing.Size(430, 26);
            this.txt_link_QLCPVT.TabIndex = 12;
            // 
            // lbl_link_QLCPVT
            // 
            this.lbl_link_QLCPVT.AutoSize = true;
            this.lbl_link_QLCPVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_link_QLCPVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_link_QLCPVT.Location = new System.Drawing.Point(529, 70);
            this.lbl_link_QLCPVT.Name = "lbl_link_QLCPVT";
            this.lbl_link_QLCPVT.Size = new System.Drawing.Size(89, 25);
            this.lbl_link_QLCPVT.TabIndex = 13;
            this.lbl_link_QLCPVT.Text = "Lưu vào";
            // 
            // QuanLyChiPhiVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 602);
            this.Controls.Add(this.lbl_link_QLCPVT);
            this.Controls.Add(this.txt_link_QLCPVT);
            this.Controls.Add(this.btn_delete_congtrinh_QLCPVT);
            this.Controls.Add(this.btn_add_congtrinh_QLCPVT);
            this.Controls.Add(this.txt_tencongtrinh_QLCPVT);
            this.Controls.Add(this.lbl_congtrinh_QLCPVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_QLCPVT);
            this.Controls.Add(this.btn_export_QLCPVT);
            this.Controls.Add(this.btn_searchQLCPVT);
            this.Controls.Add(this.btn_deleteQLCPVT);
            this.Controls.Add(this.btn_updateQLCPVT);
            this.Controls.Add(this.btn_insertQLCPVT);
            this.Controls.Add(this.grid_QLCPVT);
            this.Controls.Add(this.txt_AppName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuanLyChiPhiVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyChiPhiVatTu";
            this.Activated += new System.EventHandler(this.QuanLyChiPhiVatTu_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyChiPhiVatTu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_QLCPVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_AppName;
        private System.Windows.Forms.DataGridView grid_QLCPVT;
        private System.Windows.Forms.Button btn_insertQLCPVT;
        private System.Windows.Forms.Button btn_updateQLCPVT;
        private System.Windows.Forms.Button btn_deleteQLCPVT;
        private System.Windows.Forms.Button btn_searchQLCPVT;
        private System.Windows.Forms.Button btn_export_QLCPVT;
        private System.Windows.Forms.ComboBox cbx_QLCPVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_congtrinh_QLCPVT;
        private System.Windows.Forms.TextBox txt_tencongtrinh_QLCPVT;
        private System.Windows.Forms.Button btn_add_congtrinh_QLCPVT;
        private System.Windows.Forms.Button btn_delete_congtrinh_QLCPVT;
        private System.Windows.Forms.TextBox txt_link_QLCPVT;
        private System.Windows.Forms.Label lbl_link_QLCPVT;
    }
}