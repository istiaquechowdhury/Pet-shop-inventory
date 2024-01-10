using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.Models
{
    public class PurchaseInformation
    {
        public int Id { get; set; }     

        public string SellerContactInfo { get; set; }

        public string TypeOfPet {get; set; }  
        
        public int Price { get; set; }

        public int PetId { get; set; }  

        public Pet Pet { get; set; }        
    }
}
