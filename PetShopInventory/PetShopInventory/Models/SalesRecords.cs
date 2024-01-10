using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.Models
{
    public class SalesRecords
    {
        public int Id { get; set; } 

        public DateTime SellDate { get; set; }

        public int Price { get; set; }  

        public Pet Pet { get; set; }

        public int PetId { get; set; }  


    }
}
