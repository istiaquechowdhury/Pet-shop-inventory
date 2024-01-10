using Microsoft.EntityFrameworkCore;
using PetShopInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetShopInventory.ApplicationDbContext
{
    public class PetShopInventoryContext : DbContext
    {
        private readonly string _connectionstring;


        public PetShopInventoryContext()
        {
            _connectionstring = "Server = .\\SQLEXPRESS; Database = CSharpB15; User Id = csharpb15; Password = 123456; Trust Server Certificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_connectionstring);
            }

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admin>().HasData(GetAdmins().ToArray());

            

            base.OnModelCreating(modelBuilder);
        }

        private List<Admin> GetAdmins()
        {
            return new List<Admin>
            {
                new Admin{Id = 1,UserName ="admin",PassWord="123456"}
            };
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Pet> Pets { get; set; }    

        public DbSet<Cage> Cages { get; set; }  

        public DbSet<Aquarium> Aquariums { get; set; }  

        public DbSet<FeedingSchedule> feedingSchedules { get; set; }

        public DbSet<PetFeedingSchedule> PetFeedingSchedules { get; set;}

        public DbSet<PurchaseInformation> PetPurchaseInformations { get; set;}

        public DbSet<SalesRecords> SalesRecords { get; set; }       


        


    }
}
