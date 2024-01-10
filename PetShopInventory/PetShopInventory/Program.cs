using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using PetShopInventory;
using PetShopInventory.ApplicationDbContext;
using PetShopInventory.DataSeed;
using PetShopInventory.Models;
using System;

public class Program
{
    public static void Main()
    {

        
            PetShopInventoryContext PetContext = new PetShopInventoryContext();

            AdminLogin login = new AdminLogin();


            int UserChoice = 0;



            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
        do
        {
            if (login.Login(username, password))
            {

                
                Console.WriteLine("1.Change Password");
                Console.WriteLine("2.Cage: ");
                Console.WriteLine("3.Aqurium: ");
                Console.WriteLine("4.Pet Inventory Menu:");
                Console.WriteLine("5.Feeding Schedule Details:");
                Console.WriteLine("6.Pet Feeding Schedule:");
                Console.WriteLine("7.Pet Purchase Information: ");
                Console.WriteLine("8.Sales Record Information: ");
                Console.WriteLine("9.Monthly Sales Reports");
                Console.WriteLine("10.Log Out");

                
                UserChoice = int.Parse(Console.ReadLine());

                if (UserChoice == 1)
                {
                    ChangePassword(username, password);
                }
                if (UserChoice == 2)
                {
                   
                    Console.WriteLine("+Add Cage");
                    Console.WriteLine("-Update Cage");
                    Console.WriteLine("*Delete Cage");
                    Console.WriteLine("/Show Cages");


                    string UserChoiceCage = (Console.ReadLine());


                    if (UserChoiceCage == "+")
                    {
                        Console.WriteLine("Name: ");

                        string Name = Console.ReadLine();

                        AddCage(Name);
                    }
                    if(UserChoiceCage =="-")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Name: ");

                        string Name = Console.ReadLine();


                        UpdateCage(Id, Name);
                    }
                    if(UserChoiceCage =="*")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());
                        DeleteCage(Id);
                    }
                    if(UserChoiceCage =="/")
                    {
                        Console.WriteLine("Cage Table:");
                        ShowCages(); 
                    }
                }

                if(UserChoice == 3)
                {
                    Console.WriteLine("+Add Aqurium");
                    Console.WriteLine("-Update Aqurium");
                    Console.WriteLine("*Delete Aqurium");
                    Console.WriteLine("/Show Aqurium");

                    string UserChoiceAqurium = Console.ReadLine();

                    if(UserChoiceAqurium == "+")
                    {
                        Console.WriteLine("Enter Name: ");

                        string Name = Console.ReadLine();
                        AddAquariam(Name);
                    }
                    if(UserChoiceAqurium =="-")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Name: ");

                        string Name = Console.ReadLine();

                        UpdateAquarium(Id, Name);
                    }
                    if(UserChoiceAqurium =="*")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());
                        DeleteAquarium(Id);
                    }
                    if(UserChoiceAqurium =="/")
                    {
                        Console.WriteLine("Aquarium Table:");
                        ShowAquarium();
                    }
                }
                if(UserChoice == 4)
                {
                    Console.WriteLine("+Add Pet");
                    Console.WriteLine("-Update Pet");
                    Console.WriteLine("*Delete Pet");
                    Console.WriteLine("/Show Pet Inventory");

                    string UserchoicePet = Console.ReadLine();

                    if(UserchoicePet =="+")
                    {

                        Console.WriteLine("Pet Type: ");
                        string PetType = Console.ReadLine();

                        Console.WriteLine("Price: ");
                        int price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Cage Id (Nullable): ");
                        int? cageId = null;


                        string userInput = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "null")
                        {
                            cageId = int.Parse(userInput);
                        }

                        Console.WriteLine("Aqurium Id (Nullable): ");
                        int? aquriumId = null;

                        string userInput2 = Console.ReadLine();


                        if (!string.IsNullOrWhiteSpace(userInput2) && userInput2.ToLower() != "null")
                        {
                            aquriumId = int.Parse(userInput2);
                        }

                        AddPetToInventory(PetType, price, cageId, aquriumId);
                    }
                    if(UserchoicePet =="-")
                    {
                        Console.WriteLine("Enter ID: ");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Type: ");

                        string Type = Console.ReadLine();

                        Console.WriteLine("EnterPrice: ");

                        int Price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Cage Id (Nullable): ");
                        int? CageId = null;


                        string userInput = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "null")
                        {
                            CageId = int.Parse(userInput);
                        }
                        Console.WriteLine("Enter Aqurium Id (Nullable): ");
                        int? AquriumId = null;

                        string userInput2 = Console.ReadLine();


                        if (!string.IsNullOrWhiteSpace(userInput2) && userInput2.ToLower() != "null")
                        {
                            AquriumId = int.Parse(userInput2);
                        }

                        UpDatePet(Id, Type, Price, CageId, AquriumId);

                    }
                    if(UserchoicePet == "*")
                    {
                        Console.WriteLine("Enter Id: ");
                        int Id = int.Parse(Console.ReadLine());
                        DeletePet(Id);
                    }
                    if(UserchoicePet == "/")
                    {
                        Console.WriteLine("Pet Table:");
                        ShowPetInventory();
                    }
                }
                
                if(UserChoice == 5)
                {
                    Console.WriteLine("+Add to Schedule Details");
                    Console.WriteLine("-Update to Schedule Details");
                    Console.WriteLine("*Delete to Schedule Details");
                    Console.WriteLine("/Show Schedule Details");

                    string UserchoiceSchedules = Console.ReadLine();

                    if(UserchoiceSchedules =="+")
                    {
                        Console.WriteLine("Enter Schedule Details: ");

                        string ScheduleDetails = Console.ReadLine();

                        AddtoFeedingSchedule(ScheduleDetails);
                    }
                    if(UserchoiceSchedules == "-")
                    {
                        Console.WriteLine("Enter Id:");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Schedule Details:");

                        String Details = Console.ReadLine();

                        UpdateFeedingSchedule(Id, Details);
                    }
                    if(UserchoiceSchedules == "*")
                    {
                        Console.WriteLine("Enter Id:");

                        int Id = int.Parse(Console.ReadLine());

                        DeleteFeedingSchedule(Id);

                    }

                    if(UserchoiceSchedules =="/")
                    {
                        Console.WriteLine("Feeding Schedule Table:");
                        ShowScheduleDetails();
                    }
                }
                
                if(UserChoice == 6)
                {
                    Console.WriteLine("+Add pet feeding Schedule");
                    Console.WriteLine("-Update pet feeding Schedule");
                    Console.WriteLine("*delete pet feeding Schedule");
                    Console.WriteLine("/Show pet feeding Schedule");

                    string UserChoicePetFeedingSchedule = Console.ReadLine();

                    if(UserChoicePetFeedingSchedule == "+")
                    {
                        Console.WriteLine("Enter PetID: ");
                        int PetId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Feeding Schedule Id:  ");

                        int FeedingScheduleId = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Aqurium Id (Nullable): ");
                        int? AquriumId = null;

                        string userInput2 = Console.ReadLine();


                        if (!string.IsNullOrWhiteSpace(userInput2) && userInput2.ToLower() != "null")
                        {
                            AquriumId = int.Parse(userInput2);
                        }

                        Console.WriteLine("Enter Cage Id (Nullable): ");
                        int? CageId = null;


                        string userInput = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "null")
                        {
                            CageId = int.Parse(userInput);
                        }

                        AddPetFeedingSchedule(PetId, FeedingScheduleId, AquriumId, CageId);
                    }

                    if(UserChoicePetFeedingSchedule =="-")
                    {

                        Console.WriteLine("Enter Id");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter PetID: ");
                        int PetId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Feeding Schedule Id:  ");

                        int FeedingScheduleId = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Aqurium Id (Nullable): ");
                        int? AquriumId = null;

                        string userInput2 = Console.ReadLine();


                        if (!string.IsNullOrWhiteSpace(userInput2) && userInput2.ToLower() != "null")
                        {
                            AquriumId = int.Parse(userInput2);
                        }

                        Console.WriteLine("Enter Cage Id (Nullable): ");
                        int? CageId = null;


                        string userInput = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "null")
                        {
                            CageId = int.Parse(userInput);
                        }


                        UpdatePetFeedingSchedule(Id, PetId, FeedingScheduleId, AquriumId, CageId);

                    }

                    if(UserChoicePetFeedingSchedule == "*")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        DeletePetFeedingSchedule(Id);
                    }

                    if(UserChoicePetFeedingSchedule == "/")
                    {
                        Console.WriteLine("Pet Feeding Schedule Table:");
                        ShowPetFeedingSchedule();
                    }
                }

                if(UserChoice == 7)
                {
                    Console.WriteLine("+Add Purchase Information: ");
                    Console.WriteLine("-Update Purchase Information: ");
                    Console.WriteLine("*Delete Purchase Information");
                    Console.WriteLine("/Show Purchase Information");

                    string UserchoicePurchaseinfo = Console.ReadLine(); 

                    if(UserchoicePurchaseinfo =="+")
                    {
                        Console.WriteLine("Enter Seller Contact info: ");

                        string SellerContactInfo = Console.ReadLine();

                        Console.WriteLine("Enter Type of Pet: ");

                        string TypeOfPet = Console.ReadLine();

                        Console.WriteLine("Enter Pet Id: ");

                        int PetId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Price: ");

                        int Price = int.Parse(Console.ReadLine());




                        AddPurchaseInformation(SellerContactInfo, TypeOfPet, PetId, Price);
                    }
                    if(UserchoicePurchaseinfo =="-")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Seller Contact info: ");

                        string SellerContactInfo = Console.ReadLine();

                        Console.WriteLine("Enter Type of Pet: ");

                        string TypeOfPet = Console.ReadLine();

                        Console.WriteLine("Enter Pet Id: ");

                        int PetId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Price: ");

                        int Price = int.Parse(Console.ReadLine());

                        UpdatePurchaseInformation(Id, SellerContactInfo, TypeOfPet, PetId, Price);


                    }
                    if(UserchoicePurchaseinfo =="*")
                    {
                        Console.WriteLine("Enter Id:");
                        int Id = int.Parse(Console.ReadLine());
                        DeletePurchaseInformation(Id);

                    }

                    if(UserchoicePurchaseinfo =="/")
                    {
                        Console.WriteLine("Pet Purchase Information Table:");
                        ShowPurchaseInformation();
                    }
                }

                if(UserChoice == 8)
                {
                    Console.WriteLine("+Add Sale Records");
                    Console.WriteLine("-Update Sale Records");
                    Console.WriteLine("*Delete Sale Records");
                    Console.WriteLine("/Show Sale Records");

                    string UserchoiceSaleinfo = Console.ReadLine();

                    if(UserchoiceSaleinfo == "+")
                    {
                        Console.WriteLine("Enter Sell date: ");

                        DateTime SellDate = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Price: ");

                        int Price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter PetId: ");

                        int PetId = int.Parse(Console.ReadLine());

                        AddSalesRecords(SellDate, Price, PetId);
                    }
                    if (UserchoiceSaleinfo == "-")
                    {
                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Sell date: ");

                        DateTime SellDate = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Price: ");

                        int Price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter PetId: ");

                        int PetId = int.Parse(Console.ReadLine());

                        UpdateSalesRecords(Id, SellDate, Price, PetId);
                    }

                    if (UserchoiceSaleinfo == "*")
                    {

                        Console.WriteLine("Enter Id: ");

                        int Id = int.Parse(Console.ReadLine());

                        DeleteSalesRecords(Id);

                    }

                    if(UserchoiceSaleinfo =="/")
                    {
                        Console.WriteLine("Sales Records Table:");
                        ShowSaleRecords();
                    }


                }

                if(UserChoice == 9)
                {
                    Console.WriteLine("Monthly Sales Report:");
                    MonthlySalesReports();
                }










               

                
               




            }
            else
            {
                Console.WriteLine("Invalid username or password. Login failed.");
                break;

            }
        }while(UserChoice != 10);

    }


    public static void ChangePassword(string username,string password)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        Console.WriteLine("Please enter your current username");

        string CurrentUsername = Console.ReadLine();

        Console.WriteLine("Please enter your current password");

        string CurrentPassword = Console.ReadLine();   
        
        if(CurrentUsername == username && CurrentPassword == password)
        {
            Console.WriteLine("Please enter your new Password");
            string NewPassword = Console.ReadLine();

            var shopOwner = PetContext.Admins.FirstOrDefault(o => o.UserName == "admin");

            if (shopOwner != null)
            {
                shopOwner.PassWord = NewPassword;
                PetContext.SaveChanges();
                Console.WriteLine("Password changed Successfully!");
            }

        }
        else
        {
            Console.WriteLine("Invalid UserName or Password");
        }
        
    }

    public static void ShowPetInventory()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var allPets = PetContext.Pets.Include(p => p.Cage).Include(p => p.Aquarium).ToList();

        foreach (var pet in allPets)
        {
            string locationInfo = "";
            if (pet.CageId != null)
            {
                locationInfo = $"Cage: {pet.Cage.Name}";
            }
            else if (pet.AquariumId != null)
            {
                locationInfo = $"Aquarium: {pet.Aquarium.Name}";
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Pet ID: {pet.Id}, Pet Name: {pet.Type}, Price:{pet.Price} Location- {locationInfo}");
            Console.WriteLine("-------------------------------");
        }
    }

    public static void AddPetToInventory(string petType, int price, int? cageId, int? aquariumId)
    {

        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        Pet Pet = new Pet
        {
            Type = petType,
            Price = price,
            CageId = cageId,
            AquariumId = aquariumId
        };

            PetContext.Pets.Add(Pet);

            PetContext.SaveChanges();
        
        
       

        Console.WriteLine("Pet added to inventory.");
    }

    public static void UpDatePet(int id,string type,int price,int? cageid,int? aquriamid)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var petToUpdate = PetContext.Pets.FirstOrDefault(p => p.Id == id);

        if (petToUpdate != null)
        {
            petToUpdate.Type = type;
            petToUpdate.Price = price;
            petToUpdate.CageId = cageid;
            petToUpdate.AquariumId = aquriamid;

            PetContext.SaveChanges();
            Console.WriteLine("Pet details updated successfully.");
        }
        else
        {
            Console.WriteLine("Pet not found with the provided ID.");
        }
    }


    public static void DeletePet(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var petToDelete = PetContext.Pets.FirstOrDefault(p => p.Id == id);

            if (petToDelete != null)
            {
                PetContext.Pets.Remove(petToDelete);
                PetContext.SaveChanges();
                Console.WriteLine("Pet deleted successfully.");
            }
            else
            {
                Console.WriteLine("Pet not found with the provided ID.");
            }
        
    }


    public static void AddCage(string Name)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        Cage cage = new Cage();
        cage.Name = Name;   

        PetContext.Cages.Add(cage);

        PetContext.SaveChanges();

        Console.WriteLine("Cage inserted Successfully!");

    }

    public static void UpdateCage(int Id ,string Name)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var CageUpdate = PetContext.Cages.FirstOrDefault(p => p.Id == Id);

        if (CageUpdate != null)
        {
            CageUpdate.Name = Name;
            PetContext.SaveChanges();
            Console.WriteLine("Cage Updated Successfully!");
        }
        else
        {
            Console.WriteLine("Cage not Found with provided Id");
        }
    }

    public static void DeleteCage(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var CageDelete = PetContext.Cages.FirstOrDefault(p => p.Id == id);

        if (CageDelete != null)
        {
            PetContext.Cages.Remove(CageDelete);
            PetContext.SaveChanges();

            Console.WriteLine("Cage remove Succesfully!");
        }

        else
        {
            Console.WriteLine("Cage not Found with provided Id");
        }

    }

    public static void ShowCages()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var allCages = PetContext.Cages.ToList();

        foreach ( var p in allCages)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"ID: {p.Id} , Name: {p.Name}");
            Console.WriteLine("-------------------------------");
        }

    }

    public static void AddAquariam(string Name)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        

        Aquarium aquarium = new Aquarium
        {
            Name = Name,
        };

        PetContext.Aquariums.Add(aquarium);

        PetContext.SaveChanges();

        Console.WriteLine("aquarium inserted Successfully!");

    }

    public static void UpdateAquarium(int Id, string Name)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var AquariumUpdate = PetContext.Aquariums.FirstOrDefault(p => p.Id == Id);

        if (AquariumUpdate != null)
        {
            AquariumUpdate.Name = Name;
            PetContext.SaveChanges();
            Console.WriteLine("Aquarium Updated Successfully!");
        }
        else
        {
            Console.WriteLine("Aquarium not Found with provided Id");
        }
    }

    public static void DeleteAquarium(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var AquariumDelete = PetContext.Aquariums.FirstOrDefault(p => p.Id == id);

        if (AquariumDelete != null)
        {
            PetContext.Aquariums.Remove(AquariumDelete);
            PetContext.SaveChanges();

            Console.WriteLine("Aquarium remove Succesfully!");
        }

        else
        {
            Console.WriteLine("Aquarium not Found with provided Id");
        }

    }

    public static void ShowAquarium()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var allAquariums = PetContext.Aquariums.ToList();

        foreach (var p in allAquariums)
        {

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"ID: {p.Id} , Name: {p.Name}");
            Console.WriteLine("-------------------------------");
        }

    }


    public static void AddtoFeedingSchedule(string Details)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        FeedingSchedule feedingSchedule = new FeedingSchedule
        {
            ScheduleDetails = Details,
        };

        PetContext.feedingSchedules.Add(feedingSchedule);
        PetContext.SaveChanges();

        Console.WriteLine("Feeding Schedule added Successfully!");
    }

    public static void UpdateFeedingSchedule(int id,string Details)
    {

        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var Update = PetContext.feedingSchedules.FirstOrDefault(P => P.Id == id); 
        
        if(Update != null)
        {
            Update.ScheduleDetails = Details;

            PetContext.SaveChanges();

            Console.WriteLine("Feeding Schedule updated SuccessFully!");


        }
        else
        {
            Console.WriteLine("Feeding Schedule not found with the Provided Id");
        }



    }

    public static void DeleteFeedingSchedule(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var delete = PetContext.feedingSchedules.FirstOrDefault(P => P.Id == id);

        if(delete != null) 
        {
            PetContext.feedingSchedules.Remove(delete); 
            PetContext.SaveChanges();

            Console.WriteLine("Feeding Scheduled Deleted SuccessFully");
        }
        else
        {
            Console.WriteLine("Feeding Scheduled not found with Provided Id");
        }




    }

    public static void ShowScheduleDetails()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var AllScheduleDetails = PetContext.feedingSchedules.ToList();

        foreach(var  p in AllScheduleDetails) 
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Id: {p.Id}, ScheduleDetails: {p.ScheduleDetails}");
            Console.WriteLine("----------------------------------------------------");
        }
    }

    public static void AddPetFeedingSchedule(int petid,int feedingscheduleid,int? aquriamid,int? cageid)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        PetFeedingSchedule petFeedingSchedule = new PetFeedingSchedule
        {
            PetId = petid,
            FeedingScheduleId = feedingscheduleid,
            AquariumId = aquriamid,
            CageId = cageid




        };

        PetContext.PetFeedingSchedules.Add(petFeedingSchedule);
        PetContext.SaveChanges();
        Console.WriteLine("Pet Feeding Schedule Added Successfully");

    }


    public static void UpdatePetFeedingSchedule(int id,int petid, int feedingscheduleid,int? aquriuimid,int? cageid)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var Update = PetContext.PetFeedingSchedules.FirstOrDefault(p => p.Id == id);

        if (Update != null)
        {
            Update.PetId = petid;   
            Update.FeedingScheduleId = feedingscheduleid;
            Update.AquariumId = aquriuimid;
            Update.CageId = cageid;

            PetContext.SaveChanges();

            Console.WriteLine("Pet Feeding Schedule Updated Successfully");

        }
        else
        {
            Console.WriteLine("Pet Feeding Schedule Not found with Provided Id");
        }

        
    }

    public static void DeletePetFeedingSchedule(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var delete = PetContext.PetFeedingSchedules.FirstOrDefault(p => p.Id == id);
        if (delete != null)
        {
            PetContext.PetFeedingSchedules.Remove(delete);
            PetContext.SaveChanges();
            Console.WriteLine("Pet Feeding Schedule deleted Successfully");
        }
        else
        {
            Console.WriteLine("No PetFeeding Schedules found with provided Id ");
        }
    }

    public static void ShowPetFeedingSchedule()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var AllCageAndAquarium = PetContext.PetFeedingSchedules.Include(p => p.Cage).Include(p => p.Aquarium).Include(p => p.FeedingSchedule).ToList();
      

        foreach (var PFS in AllCageAndAquarium)
        {
            string CageName = "";
            string AquariumName = "";
            if (PFS.CageId != null)
            {
                CageName =  PFS.Cage.Name;
            }
            if (PFS.AquariumId != null)
            {
                AquariumName = PFS.Aquarium.Name;
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($" Id:{PFS.Id} {CageName} {AquariumName} ScheduleDetails: {PFS.FeedingSchedule.ScheduleDetails}");
            Console.WriteLine("-------------------------------");
        }

    }

    public static void AddPurchaseInformation(string sellerinfo,string typeofpet,int petid,int price)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        PurchaseInformation purchaseinfo = new PurchaseInformation
        {
            SellerContactInfo = sellerinfo,
            TypeOfPet = typeofpet,
            PetId = petid,
            Price = price





        };
        PetContext.PetPurchaseInformations.Add(purchaseinfo);
        PetContext.SaveChanges();


        Console.WriteLine("Purchase information Added Successfully");

    }
    public static void UpdatePurchaseInformation(int id,string sellerinfo, string typeofpet, int petid, int price)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var Update = PetContext.PetPurchaseInformations.FirstOrDefault(p => p.Id == id);

        if (Update != null)
        {
            Update.SellerContactInfo = sellerinfo;
            Update.TypeOfPet = typeofpet;
            Update.PetId = petid;
            Update.Price = price;

            PetContext.SaveChanges();

            Console.WriteLine("Pet Purchase Information Updated Successfully");

        }
        else
        {
            Console.WriteLine("Pet Purchase Information Not found with Provided Id");
        }

    }

    public static void DeletePurchaseInformation(int id)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var delete = PetContext.PetPurchaseInformations.FirstOrDefault(p => p.Id == id);
        if (delete != null)
        {
                PetContext.PetPurchaseInformations.Remove(delete);
                PetContext.SaveChanges();
                Console.WriteLine("Pet Purchase Information deleted Successfully");
        }
            
        else
        {
            Console.WriteLine("Pet Purchase Information Not found with Provided Id");
        }

    }

    public static void ShowPurchaseInformation()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var Show = PetContext.PetPurchaseInformations.Include(P => P.Pet).ToList();

        foreach (var item in Show)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Id: {item.Id} Seller Contact info:{item.SellerContactInfo} Type Of Pet:{item.TypeOfPet} Pet Name:{item.Pet.Type} Buying Price:{item.Price}");
            Console.WriteLine("-------------------------------");
        }

    }

    public static void AddSalesRecords(DateTime selldate, int price, int petid)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        SalesRecords SR = new SalesRecords
        {
            SellDate = selldate,
            Price = price,
            PetId = petid,

        };

        PetContext.SalesRecords.Add(SR);
        PetContext.SaveChanges();

        Console.WriteLine("Sales Records added SuccessfullY! ");


    }

    public static void UpdateSalesRecords(int id,DateTime selldate,int price,int petid)
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var SaleRecords = PetContext.SalesRecords.FirstOrDefault(p => p.Id == id);

        if(SaleRecords != null) 
        {
            SaleRecords.SellDate = selldate;
            SaleRecords.Price = price;
            SaleRecords.PetId = petid;

            PetContext.SaveChanges();

            Console.WriteLine("Sales records Updated Successfully!");


        }
        else
        {
            Console.WriteLine("Sales records not found with the provided Id");
        }


    }

    public static void DeleteSalesRecords(int id) 
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var Delete = PetContext.SalesRecords.FirstOrDefault(p => p.Id == id);

        if(Delete != null)
        {
            PetContext.SalesRecords.Remove(Delete);
            PetContext.SaveChanges();
            Console.WriteLine("Sales records Deleted Successfully!");
        }
        else
        {
            Console.WriteLine("Sales records not found with the provided Id");

        }
    }

    public static void ShowSaleRecords()
    {
        PetShopInventoryContext PetContext = new PetShopInventoryContext();

        var Show = PetContext.SalesRecords.Include(p => p.Pet).ToList();

        foreach (var b in Show)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"ID: {b.Id}, Sell Date: {b.SellDate}, Selling Price:{b.Price}, Pet Name: {b.Pet.Type}");
            Console.WriteLine("-------------------------------");
        }
    }


    public static void MonthlySalesReports()
    {
        Console.WriteLine("Purchase Information Table");
        ShowPurchaseInformation();

        Console.WriteLine();


        Console.WriteLine("Sale Records Table");
        ShowSaleRecords();

        PetShopInventoryContext PetContext = new PetShopInventoryContext();
        var ShowPurchasePrice = PetContext.PetPurchaseInformations.Include(P => P.Pet).ToList();
        var ShowSellsPrice = PetContext.SalesRecords.Include(p => p.Pet).ToList();

        int TotalPurchasePrice = 0;

        int TotalSellsPrice = 0;

        foreach (var Price in ShowPurchasePrice)
        {
            

            TotalPurchasePrice = TotalPurchasePrice + Price.Price;
            
        }
        foreach(var Price in ShowSellsPrice)
        {
            
            TotalSellsPrice = TotalSellsPrice + Price.Price;

            
        }

        if(TotalPurchasePrice > TotalSellsPrice)
        {
            Console.WriteLine($"Loss Amount: {Math.Abs(TotalPurchasePrice - TotalSellsPrice)}");
        }
        else if(TotalPurchasePrice == TotalSellsPrice) 
        {
            Console.WriteLine($"No Loss and No Profit: {Math.Abs(TotalPurchasePrice - TotalSellsPrice)}");
        }
        else
        {
            Console.WriteLine($"Profit Amount: {Math.Abs(TotalPurchasePrice - TotalSellsPrice)}");
        }
    }
















}