using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.Models
{
    public class Pet
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int Price { get; set; }

        public int? CageId { get; set; }    

        public int? AquariumId { get; set; }        

        public Cage Cage { get; set; }  

        public Aquarium Aquarium { get; set; }
        
        public List<PetFeedingSchedule> PetFeedingSchedules { get; set;}

        public List<PurchaseInformation> PurchaseInformation { get; set;}

        public List<SalesRecords> SalesRecords { get; set;} 

       

        


    }
}
