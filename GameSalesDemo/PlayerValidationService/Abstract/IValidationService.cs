using GameSalesDemo.PlayerManagementService.Entities;

namespace GameSalesDemo.PlayerValidationService.Abstract
{
    public interface IValidationService
    {
        bool Validate(Player player);
    }
}