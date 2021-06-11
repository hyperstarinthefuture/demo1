
namespace demo1
{
    partial class Form_Detail
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
            this.grbx_ThongTinSV = new System.Windows.Forms.GroupBox();
            this.grbx_GioiTinh = new System.Windows.Forms.GroupBox();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbb_LopSH = new System.Windows.Forms.ComboBox();
            this.tb_TenSV = new System.Windows.Forms.TextBox();
            this.tb_MSSV = new System.Windows.Forms.TextBox();
            this.lb_NS = new System.Windows.Forms.Label();
            this.lb_LopSH = new System.Windows.Forms.Label();
            this.lb_TenSV = new System.Windows.Forms.Label();
            this.lb_MSSV = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grbx_ThongTinSV.SuspendLayout();
            this.grbx_GioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_ThongTinSV
            // 
            this.grbx_ThongTinSV.Controls.Add(this.grbx_GioiTinh);
            this.grbx_ThongTinSV.Controls.Add(this.dtp);
            this.grbx_ThongTinSV.Controls.Add(this.cbb_LopSH);
            this.grbx_ThongTinSV.Controls.Add(this.tb_TenSV);
            this.grbx_ThongTinSV.Controls.Add(this.tb_MSSV);
            this.grbx_ThongTinSV.Controls.Add(this.lb_NS);
            this.grbx_ThongTinSV.Controls.Add(this.lb_LopSH);
            this.grbx_ThongTinSV.Controls.Add(this.lb_TenSV);
            this.grbx_ThongTinSV.Controls.Add(this.lb_MSSV);
            this.grbx_ThongTinSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_ThongTinSV.Location = new System.Drawing.Point(12, 22);
            this.grbx_ThongTinSV.Name = "grbx_ThongTinSV";
            this.grbx_ThongTinSV.Size = new System.Drawing.Size(891, 293);
            this.grbx_ThongTinSV.TabIndex = 0;
            this.grbx_ThongTinSV.TabStop = false;
            this.grbx_ThongTinSV.Text = "Thông tin SV";
            // 
            // grbx_GioiTinh
            // 
            this.grbx_GioiTinh.Controls.Add(this.rbtn_Nu);
            this.grbx_GioiTinh.Controls.Add(this.rbtn_Nam);
            this.grbx_GioiTinh.Location = new System.Drawing.Point(436, 157);
            this.grbx_GioiTinh.Name = "grbx_GioiTinh";
            this.grbx_GioiTinh.Size = new System.Drawing.Size(449, 100);
            this.grbx_GioiTinh.TabIndex = 0;
            this.grbx_GioiTinh.TabStop = false;
            this.grbx_GioiTinh.Text = "Giới tính";
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(283, 51);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(58, 29);
            this.rbtn_Nu.TabIndex = 0;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(70, 51);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(74, 29);
            this.rbtn_Nam.TabIndex = 0;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(536, 60);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(349, 30);
            this.dtp.TabIndex = 4;
            // 
            // cbb_LopSH
            // 
            this.cbb_LopSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_LopSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopSH.FormattingEnabled = true;
            this.cbb_LopSH.Location = new System.Drawing.Point(138, 224);
            this.cbb_LopSH.Name = "cbb_LopSH";
            this.cbb_LopSH.Size = new System.Drawing.Size(208, 33);
            this.cbb_LopSH.TabIndex = 3;
            // 
            // tb_TenSV
            // 
            this.tb_TenSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenSV.Location = new System.Drawing.Point(138, 145);
            this.tb_TenSV.Name = "tb_TenSV";
            this.tb_TenSV.Size = new System.Drawing.Size(208, 23);
            this.tb_TenSV.TabIndex = 2;
            this.tb_TenSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_MSSV
            // 
            this.tb_MSSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MSSV.Location = new System.Drawing.Point(138, 60);
            this.tb_MSSV.Name = "tb_MSSV";
            this.tb_MSSV.Size = new System.Drawing.Size(208, 23);
            this.tb_MSSV.TabIndex = 1;
            this.tb_MSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_NS
            // 
            this.lb_NS.AutoSize = true;
            this.lb_NS.Location = new System.Drawing.Point(431, 60);
            this.lb_NS.Name = "lb_NS";
            this.lb_NS.Size = new System.Drawing.Size(99, 25);
            this.lb_NS.TabIndex = 0;
            this.lb_NS.Text = "Ngày sinh";
            // 
            // lb_LopSH
            // 
            this.lb_LopSH.AutoSize = true;
            this.lb_LopSH.Location = new System.Drawing.Point(24, 232);
            this.lb_LopSH.Name = "lb_LopSH";
            this.lb_LopSH.Size = new System.Drawing.Size(78, 25);
            this.lb_LopSH.TabIndex = 0;
            this.lb_LopSH.Text = "Lớp SH";
            // 
            // lb_TenSV
            // 
            this.lb_TenSV.AutoSize = true;
            this.lb_TenSV.Location = new System.Drawing.Point(24, 145);
            this.lb_TenSV.Name = "lb_TenSV";
            this.lb_TenSV.Size = new System.Drawing.Size(69, 25);
            this.lb_TenSV.TabIndex = 0;
            this.lb_TenSV.Text = "Họ tên";
            // 
            // lb_MSSV
            // 
            this.lb_MSSV.AutoSize = true;
            this.lb_MSSV.Location = new System.Drawing.Point(24, 60);
            this.lb_MSSV.Name = "lb_MSSV";
            this.lb_MSSV.Size = new System.Drawing.Size(71, 25);
            this.lb_MSSV.TabIndex = 0;
            this.lb_MSSV.Text = "MSSV";
            // 
            // btn_OK
            // 
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(256, 352);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 34);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(509, 352);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 34);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 394);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.grbx_ThongTinSV);
            this.Name = "Form_Detail";
            this.Text = "Form_Detail";
            this.grbx_ThongTinSV.ResumeLayout(false);
            this.grbx_ThongTinSV.PerformLayout();
            this.grbx_GioiTinh.ResumeLayout(false);
            this.grbx_GioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_ThongTinSV;
        private System.Windows.Forms.TextBox tb_TenSV;
        private System.Windows.Forms.TextBox tb_MSSV;
        private System.Windows.Forms.Label lb_NS;
        private System.Windows.Forms.Label lb_LopSH;
        private System.Windows.Forms.Label lb_TenSV;
        private System.Windows.Forms.Label lb_MSSV;
        private System.Windows.Forms.GroupBox grbx_GioiTinh;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbb_LopSH;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}