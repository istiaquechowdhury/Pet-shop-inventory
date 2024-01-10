using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.Models
{
    public class PetFeedingSchedule
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public int? CageId { get; set; } 

        public int? AquariumId { get; set; } 

        public Cage Cage { get; set; } 

        public Aquarium Aquarium { get; set; } 

        public int FeedingScheduleId { get; set; }
        public FeedingSchedule FeedingSchedule { get; set; }


    }
}
