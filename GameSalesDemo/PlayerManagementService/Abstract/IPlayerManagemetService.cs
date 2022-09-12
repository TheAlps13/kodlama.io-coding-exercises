using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.PlayerManagementService.Entities;

namespace GameSalesDemo.PlayerManagementService.Abstract
{
    public interface IPlayerService
    {
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        void RemovePlayer(int id);
        Player GetPlayer(int id);
        List<Player> GetAllPlayers();
    }
}
