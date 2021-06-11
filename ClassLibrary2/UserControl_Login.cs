using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public partial class UserControl_Login : UserControl
    {
        public UserControl_Login()
        {
            InitializeComponent();
        }
        public delegate void MyDel();
        public MyDel myDel;
        public string Username
        {
            get { return tb_Username.Text; }
            set { tb_Username.Text = value; }
        }
        public string Password
        {
            get { return tb_Password.Text; }
            set { tb_Password.Text = value; }
        }
        public Button btn
        {
            get { return btn_Login; }
        }
        //Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            myDel();
        }
    }
}
