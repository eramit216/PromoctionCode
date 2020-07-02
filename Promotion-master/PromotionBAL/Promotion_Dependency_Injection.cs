using Promotion_Engine.PromotionInterface;
using Promotion_Engine.PromotionViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.PromotionBAL
{
  public class Promotion_Dependency_Injection
    {
        public Promotion_Interface promotion_Interface;

        /// <summary>
        /// Using Dependency Injection
        /// </summary>
        /// <param name="promotion_Interface">Interface</param>
        public Promotion_Dependency_Injection(Promotion_Interface promotion_Interface)
        {
            this.promotion_Interface = promotion_Interface;
        }

        /// <summary>
        /// Get all the promotion price
        /// </summary>
        /// <param name="promotion_Properties"></param>
        /// <returns></returns>
        public int GetAllPrice(List<Promotion_Properties> promotion_Properties)
        {
            try
            {
                return promotion_Interface.GetPromotionPrice(promotion_Properties);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
