using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo1.Model;
namespace demo1.BLL
{
    public class Account_MNG
    {
        private AppDBContext DBContext;
        private static Account_MNG _Instance;
        public static Account_MNG Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Account_MNG();
                }
                return _Instance;
            }
            private set { }
        }
        private Account_MNG()
        {
            DBContext = new AppDBContext();
        }
        public bool CheckAccount(string Username, string Password)
        {
            Account account = DBContext.Accounts.Where(x => x.Account_Username.Equals(Username) && x.Account_Password.Equals(Password)).FirstOrDefault();
            if (account != null)
            {
                return true;
            }
            return false;
        }
    }
}
