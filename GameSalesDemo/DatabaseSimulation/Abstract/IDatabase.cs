using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo;
using GameSalesDemo.PlayerManagementService.Entities;

namespace GameSalesDemo.DatabaseSimulation.Abstract
{
    public interface IDatabase
    {
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        void RemovePlayer(int id);
        Player GetPlayer(int id);
        List<Player> GetAllPlayers();
        void SavePurchase(Player player, GameItem game);
        GameItem GetPurchase(Player player);
        List<KeyValuePair<Player, GameItem>> GetAlPurchaseHistory();
    }
}
