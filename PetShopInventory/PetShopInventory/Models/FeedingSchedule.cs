using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopInventory.Models
{
    public class FeedingSchedule
    {
        public int Id { get; set; } 

        public string ScheduleDetails { get; set; }  
        
        public List<PetFeedingSchedule> PetFeedingSchedules { get; set; }       
    }
}
