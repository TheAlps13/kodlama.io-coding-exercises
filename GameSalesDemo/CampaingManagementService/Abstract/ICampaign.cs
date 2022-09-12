using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo;

namespace GameSalesDemo.CampaingManagementService.Abstract
{
    public interface ICampaign
    {
        decimal DiscountAmount { get; set; }

        // Base for campaigns, ApplyCampaing method will return campaign applied game item
        public GameItem ApplyCampaign(GameItem gameItem);
    }
}
