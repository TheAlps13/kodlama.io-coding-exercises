using GameSalesDemo.CampaingManagementService.Abstract;
using GameSalesDemo.CampaingManagementService.Concrete.Campaigns;
using GameSalesDemo.DatabaseSimulation.Abstract;
using GameSalesDemo.DatabaseSimulation.Concrete;
using GameSalesDemo.EGovernmentSimulation;
using GameSalesDemo.PlayerManagementService.Abstract;
using GameSalesDemo.PlayerManagementService.Concrete;
using GameSalesDemo.PlayerManagementService.Entities;
using GameSalesDemo.PlayerValidationService.Abstract;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////// Initialization Begins //////////
            IDatabase database = new DatabaseSimulator();
            IValidationService validator = new EGovermentAdapter();
            IPlayerService playerManager = new PlayerManager(validator, database);
            IGamePurchaseService purchaseManager = new PurchaseManager(database);

            ICampaign septemberDiscountCampaign = new SeptemperDiscountCampaign();
            ICampaign newPlayerCampaign = new NewPlayerCampaign();
            ///////// Initialization Ends ///////////
            

            // Adding player
            playerManager.AddPlayer(new Player
            {
                Id = 1,
                Name = "Alper",
                LastName = "Tasci",
                BirthDate = DateTime.Now, // I was born now
                TcNo = "2134545645"
            });

            playerManager.UpdatePlayer(new Player
            {
                Id = 1,
                Name = "Inci",
                LastName = "Tasci",
                BirthDate = DateTime.Now,
                TcNo = "2134545645"
            });

            

            purchaseManager.AddCampaing(septemberDiscountCampaign);

            purchaseManager.AddCampaing(newPlayerCampaign);
            
            purchaseManager.UpdateCampaing(septemberDiscountCampaign);

            purchaseManager.Sell(playerManager.GetPlayer(1), new GameItem
            {
                Name = "The jaguar's sword",
                Price = 150
            }); ;
            
            
           
            Console.WriteLine(playerManager.GetAllPlayers()[0].Name);
            List<KeyValuePair<Player, GameItem>> history = purchaseManager.GetPurchaseHistory();

            foreach(KeyValuePair<Player, GameItem> purchase in history)
                Console.WriteLine($"Player: {purchase.Key.Name} has purchased {purchase.Value.Name} for {purchase.Value.Price}$");
        }
    }
}
