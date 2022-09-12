using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo;
using GameSalesDemo.CampaingManagementService.Abstract;

namespace GameSalesDemo.CampaingManagementService.Concrete.Campaigns
{
    public class NewPlayerCampaign : ICampaign
    {
        // This random can be applied to new players to make a discount for 10 $ as default discount
        public decimal DiscountAmount { get; set; } = 10;
        public GameItem ApplyCampaign(GameItem game)
        {
            return new GameItem
            {
                Name = game.Name,
                Price = game.Price - this.DiscountAmount
            };
        }
    }
}
