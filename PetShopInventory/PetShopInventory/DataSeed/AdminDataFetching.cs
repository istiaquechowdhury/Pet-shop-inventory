using PetShopInventory.ApplicationDbContext;
using PetShopInventory.DataSeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.DataSeed
{
    public class AdminDataFetching
    {
        private readonly PetShopInventoryContext _context;

        public  AdminDataFetching()
        {
            _context = new PetShopInventoryContext();
        }

        public Admin GetAdmin()
        {
            return _context.Admins.FirstOrDefault(u => u.UserName == "admin");

        }



    }
}
