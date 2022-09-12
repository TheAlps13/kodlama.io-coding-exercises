using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo;
using GameSalesDemo.CampaingManagementService.Abstract;

namespace GameSalesDemo.CampaingManagementService.Concrete.Campaigns
{
    public class SeptemperDiscountCampaign : ICampaign
    {
        // This campaign is made for who buys items on september, with a 30 $ discount as default discount
        public decimal DiscountAmount { get; set; } = 30;
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
