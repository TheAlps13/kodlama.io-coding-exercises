using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.CampaingManagementService.Abstract;
using GameSalesDemo.PlayerManagementService.Entities;

namespace GameDemo
{
    public interface IGamePurchaseService
    {
        void Sell(Player player, GameItem game);
        void AddCampaing(ICampaign campaign);
        void UpdateCampaing(ICampaign campaign);
        void RemoveCampaign(ICampaign campaign);
        List<KeyValuePair<Player, GameItem>> GetPurchaseHistory();
        GameItem GetPurchase(Player player);
    }
}
