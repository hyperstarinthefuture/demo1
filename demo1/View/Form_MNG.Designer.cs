
namespace demo1
{
    partial class Form_MNG
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
            this.lb_LopSH = new System.Windows.Forms.Label();
            this.cbb_LopSH = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grbx_DSSV = new System.Windows.Forms.GroupBox();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grbx_DSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LopSH
            // 
            this.lb_LopSH.AutoSize = true;
            this.lb_LopSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LopSH.Location = new System.Drawing.Point(74, 17);
            this.lb_LopSH.Name = "lb_LopSH";
            this.lb_LopSH.Size = new System.Drawing.Size(78, 25);
            this.lb_LopSH.TabIndex = 0;
            this.lb_LopSH.Text = "Lớp SH";
            // 
            // cbb_LopSH
            // 
            this.cbb_LopSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_LopSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopSH.FormattingEnabled = true;
            this.cbb_LopSH.Location = new System.Drawing.Point(169, 9);
            this.cbb_LopSH.Name = "cbb_LopSH";
            this.cbb_LopSH.Size = new System.Drawing.Size(210, 33);
            this.cbb_LopSH.TabIndex = 1;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(591, 10);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(205, 30);
            this.tb_Search.TabIndex = 2;
            this.tb_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(824, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 34);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grbx_DSSV
            // 
            this.grbx_DSSV.Controls.Add(this.cbb_Sort);
            this.grbx_DSSV.Controls.Add(this.btn_Sort);
            this.grbx_DSSV.Controls.Add(this.btn_Delete);
            this.grbx_DSSV.Controls.Add(this.btn_Edit);
            this.grbx_DSSV.Controls.Add(this.btn_Add);
            this.grbx_DSSV.Controls.Add(this.btn_Show);
            this.grbx_DSSV.Controls.Add(this.dgv);
            this.grbx_DSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_DSSV.Location = new System.Drawing.Point(6, 66);
            this.grbx_DSSV.Name = "grbx_DSSV";
            this.grbx_DSSV.Size = new System.Drawing.Size(1067, 457);
            this.grbx_DSSV.TabIndex = 0;
            this.grbx_DSSV.TabStop = false;
            this.grbx_DSSV.Text = "Danh sách SV";
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Items.AddRange(new object[] {
            "MSSV",
            "Họ Tên SV",
            "Tên Lớp",
            "Giới tính",
            "Ngày Sinh"});
            this.cbb_Sort.Location = new System.Drawing.Point(851, 417);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(210, 33);
            this.cbb_Sort.TabIndex = 3;
            // 
            // btn_Sort
            // 
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.Location = new System.Drawing.Point(743, 417);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(93, 34);
            this.btn_Sort.TabIndex = 0;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(525, 417);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 34);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(339, 417);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(93, 34);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(163, 417);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 34);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(6, 417);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(93, 34);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 29);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1055, 370);
            this.dgv.TabIndex = 0;
            // 
            // Form_MNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 535);
            this.Controls.Add(this.grbx_DSSV);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.cbb_LopSH);
            this.Controls.Add(this.lb_LopSH);
            this.Name = "Form_MNG";
            this.Text = "Form_MNG";
            this.grbx_DSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LopSH;
        private System.Windows.Forms.ComboBox cbb_LopSH;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox grbx_DSSV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
    }
}