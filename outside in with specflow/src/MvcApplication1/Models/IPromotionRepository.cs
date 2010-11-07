using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public interface IPromotionRepository
    {
        IEnumerable<Promotion> GetPromotions();
    }
}