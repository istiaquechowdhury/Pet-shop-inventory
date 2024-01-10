using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.DataSeed
{
    public class AdminLogin
    {
        private readonly AdminDataFetching _username;

        public AdminLogin()
        {
            _username = new AdminDataFetching();
        }
        public bool Login(string username, string password)
        {
            Admin adminUser = _username.GetAdmin();

            if (adminUser != null && adminUser.PassWord == password && adminUser.UserName == username)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}
