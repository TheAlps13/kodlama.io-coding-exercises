using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.CampaingManagementService.Abstract;
using GameSalesDemo.DatabaseSimulation.Abstract;
using GameSalesDemo.PlayerManagementService.Entities;

namespace GameDemo
{
    public class PurchaseManager : IGamePurchaseService
    {
        private List<ICampaign> _campaigns;
        private IDatabase _database;

        public PurchaseManager(IDatabase database)
        {
            _campaigns = new List<ICampaign>();
            _database = database;
        }

        public void AddCampaing(ICampaign campaign)
        {
            _campaigns.Add(campaign);
        }

        public void RemoveCampaign(ICampaign campaign)
        {
            _campaigns.Remove(campaign);
        }

        public void Sell(Player player, GameItem gameItem)
        {
             gameItem = ApplyCampaign(gameItem);
            _database.SavePurchase(player, gameItem);
        }

        public void UpdateCampaing(ICampaign campaign)
        {
            int index = _campaigns.IndexOf(campaign);
            if (index != -1)
                _campaigns[index] = campaign;
        }

        public GameItem ApplyCampaign(GameItem gameItem)
        {
            foreach (ICampaign campaigns in _campaigns)
            {
                gameItem = campaigns.ApplyCampaign(gameItem);
            }
            return gameItem;
        }

        public List<KeyValuePair<Player, GameItem>> GetPurchaseHistory()
        {
            return _database.GetAlPurchaseHistory();
        }

        public GameItem GetPurchase(Player player)
        {
            return _database.GetPurchase(player);
        }
    }
}
