
namespace ClassLibrary2
{
    partial class UserControl_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_Login = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.grbx_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Login
            // 
            this.grbx_Login.Controls.Add(this.btn_Cancel);
            this.grbx_Login.Controls.Add(this.tb_Password);
            this.grbx_Login.Controls.Add(this.lb_Password);
            this.grbx_Login.Controls.Add(this.btn_Login);
            this.grbx_Login.Controls.Add(this.tb_Username);
            this.grbx_Login.Controls.Add(this.lb_Username);
            this.grbx_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_Login.Location = new System.Drawing.Point(3, 3);
            this.grbx_Login.Name = "grbx_Login";
            this.grbx_Login.Size = new System.Drawing.Size(461, 239);
            this.grbx_Login.TabIndex = 0;
            this.grbx_Login.TabStop = false;
            this.grbx_Login.Text = "Đăng nhập";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(264, 191);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 42);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(155, 115);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(241, 30);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(34, 118);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(98, 25);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(98, 191);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(123, 42);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(155, 53);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(241, 30);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(34, 56);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(102, 25);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Username";
            // 
            // UserControl_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbx_Login);
            this.Name = "UserControl_Login";
            this.Size = new System.Drawing.Size(473, 246);
            this.grbx_Login.ResumeLayout(false);
            this.grbx_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
