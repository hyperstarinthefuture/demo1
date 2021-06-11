
namespace demo1
{
    partial class Form_Login
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
            this.userControl_Login1 = new ClassLibrary2.UserControl_Login();
            this.SuspendLayout();
            // 
            // userControl_Login1
            // 
            this.userControl_Login1.Location = new System.Drawing.Point(46, 33);
            this.userControl_Login1.Name = "userControl_Login1";
            this.userControl_Login1.Size = new System.Drawing.Size(473, 246);
            this.userControl_Login1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 336);
            this.Controls.Add(this.userControl_Login1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary2.UserControl_Login userControl11;
        private ClassLibrary2.UserControl_Login userControl_Login1;
    }
}

