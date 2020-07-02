using Promotion_Engine.PromotionInterface;
using Promotion_Engine.PromotionViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.PromotionDAL
{
   public class PromotionDal : Promotion_Interface
    {
        public PromotionDal()
        {

        }
        /// <summary>
        /// Calculate the promotion price based on the user input
        /// </summary>
        /// <param name="promotion_Properties"></param>
        /// <returns></returns>
        public int GetPromotionPrice(List<Promotion_Properties> promotion_Properties)
        {
            try
            {
                //Initialize the local variable
                int promotionA = 0, priceOfA = 50, promotionB = 0, priceOfB = 30, promotionC = 0, priceOfC = 20, promotionD = 0, priceOfD = 15;

                foreach (Promotion_Properties pro in promotion_Properties)
                {
                    switch (pro.Id)
                    {
                        case "A":
                        case "a":
                            promotionA += 1;
                            break;
                        case "B":
                        case "b":
                            promotionB += 1;
                            break;
                        case "C":
                        case "c":
                            promotionC += 1;
                            break;
                        case "D":
                        case "d":
                            promotionD += 1;
                            break;
                    }
                }
                //Calculate the prices
                int totalPromotionPriceOfA = (promotionA / 3) * 130 + (promotionA % 3 * priceOfA);
                int totalPromotionPriceOfB = (promotionB / 2) * 45 + (promotionB % 3 * priceOfB);
                int totalPromotionPriceOfC = (promotionC * priceOfC);
                int totalPromotionPriceOfD = (promotionD * priceOfD);

                return totalPromotionPriceOfA + totalPromotionPriceOfB + totalPromotionPriceOfC + totalPromotionPriceOfD;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
