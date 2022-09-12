using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesDemo.PlayerManagementService.Entities;
using GameSalesDemo.PlayerValidationService.Abstract;

namespace GameSalesDemo.PlayerValidationService.Concrete
{
    public abstract class ValidationBase : IValidationService
    {
        public abstract bool Validate(Player player);
    }
}
