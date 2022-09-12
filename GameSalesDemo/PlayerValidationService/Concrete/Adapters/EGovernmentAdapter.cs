using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.EGovernmentSimulation;
using GameSalesDemo.PlayerManagementService.Entities;
using GameSalesDemo.PlayerValidationService.Abstract;

namespace GameSalesDemo.PlayerValidationService.Concrete.Adapters
{
    public class EGovernmentAdapter : IValidationService
    {
        private EGovermentAdapter _validator;

        EGovernmentAdapter()
        {
            _validator = new EGovermentAdapter();
        }

        public bool Validate(Player player)
        {
            return _validator.Validate(player);
        }
    }
}
