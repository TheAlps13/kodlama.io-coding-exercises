using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo;
using GameSalesDemo.DatabaseSimulation.Abstract;
using GameSalesDemo.PlayerManagementService.Entities;

namespace GameSalesDemo.DatabaseSimulation.Concrete
{
    public class DatabaseSimulator : IDatabase
    {
        static List<Player> _players;
        static List<KeyValuePair<Player, GameItem>> _purchaseHistory;
        public DatabaseSimulator()
        {
            _players = new List<Player>();
            _purchaseHistory = new List<KeyValuePair<Player, GameItem>>();
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(int id)
        {
            for (int i = 0; i < _players.Count; i++)
                if (_players[i].Id == id)
                    _players.RemoveAt(i);
        }

        public void UpdatePlayer(Player player)
        {
            int index = _players.FindIndex(p => p.Id == player.Id);
            if (index != -1)
                _players[index] = player;
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }

        public Player GetPlayer(int id)
        {
            return _players.First(p => p.Id == id);
        }

        public void SavePurchase(Player player, GameItem game)
        {
            _purchaseHistory.Add(new KeyValuePair<Player, GameItem>(player, game));
        }

        public GameItem GetPurchase(Player player)
        {
            foreach (KeyValuePair<Player, GameItem> p in _purchaseHistory)
            {
                if (p.Key.Equals(player))
                    return p.Value;
            }

            return null;
        }

        public List<KeyValuePair<Player, GameItem>> GetAlPurchaseHistory()
        {
            return _purchaseHistory;
        }
    }
}
