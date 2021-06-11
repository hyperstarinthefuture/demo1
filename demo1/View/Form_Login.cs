using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.BLL;
using demo1.ViewModel;
namespace demo1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            userControl_Login1.myDel = Login; 
        }
        private void Login()
        {
            string Username = userControl_Login1.Username;
            string Password = userControl_Login1.Password;
            if (Account_MNG.Instance.CheckAccount(Username,Password))
            {
                Form_MNG f = new Form_MNG();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }  
            else
            {
                MessageBox.Show("Username hoặc Password không đúng!");
            }    
        }
    }
}
