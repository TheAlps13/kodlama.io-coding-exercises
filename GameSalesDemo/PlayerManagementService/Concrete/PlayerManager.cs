using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.DatabaseSimulation.Abstract;
using GameSalesDemo.PlayerManagementService.Abstract;
using GameSalesDemo.PlayerManagementService.Entities;
using GameSalesDemo.PlayerValidationService.Abstract;

namespace GameSalesDemo.PlayerManagementService.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IValidationService _validator;
        IDatabase _playerDatabase;

        public PlayerManager(IValidationService validator, IDatabase playerDatabase)
        {
            _validator = validator;
            _playerDatabase = playerDatabase;
        }

        public void AddPlayer(Player player)
        {
            _playerDatabase.AddPlayer(player);
        }

        public List<Player> GetAllPlayers()
        {
            return _playerDatabase.GetAllPlayers();
        }

        public Player GetPlayer(int id)
        {
            return _playerDatabase.GetPlayer(id);
        }

        public void RemovePlayer(int id)
        {
            _playerDatabase.RemovePlayer(id);
        }

        public void UpdatePlayer(Player player)
        {
            _playerDatabase.UpdatePlayer(player);
        }

        public void ValidatePlayer(Player player)
        {
            _validator.Validate(player);
        }
    }
}
