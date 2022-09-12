using System;
using GameSalesDemo.DatabaseSimulation.Abstract;

namespace GameSalesDemo.PlayerManagementService.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}