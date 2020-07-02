using Promotion_Engine.PromotionViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.PromotionInterface
{
   public interface Promotion_Interface
    {
        /// <summary>
        /// Get the Price of the Promotion input
        /// </summary>
        /// <param name="promotion_Properties"></param>
        /// <returns></returns>
        int GetPromotionPrice(List<Promotion_Properties> promotion_Properties);
    }
}
