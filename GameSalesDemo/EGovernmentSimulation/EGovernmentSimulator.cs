using System;
using GameSalesDemo.PlayerManagementService.Entities;
using GameSalesDemo.PlayerValidationService.Abstract;

namespace GameSalesDemo.EGovernmentSimulation
{
    public class EGovermentAdapter : IValidationService
    {


        public bool Validate(Player player)
        {
            string TcNo = player.TcNo;
            string Name = player.Name;
            string LastName = player.LastName;
            DateTime birthDate = player.BirthDate;

            return true;
        }
    }
}