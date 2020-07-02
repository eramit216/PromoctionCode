using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion_Engine.PromotionBAL;
using Promotion_Engine.PromotionDAL;
using Promotion_Engine.PromotionViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.PromotionBAL.Tests
{
    [TestClass()]
    public class Promotion_Dependency_InjectionTests
    {
        [TestMethod()]
        public void GetAllPriceTest()
        {
            try
            {
                List<Promotion_Properties> promotion_Properties = new List<Promotion_Properties>();
                int userInput = 1;
                Promotion_Properties promotion_Pro = new Promotion_Properties();
                for (int i = 0; i < userInput; i++)
                {
                    promotion_Pro.Id = "A";
                    promotion_Properties.Add(promotion_Pro);
                }
                Promotion_Dependency_Injection promotion_Dependency_Injection = new Promotion_Dependency_Injection(new PromotionDal());
                int totalPromotionPrice = promotion_Dependency_Injection.GetAllPrice(promotion_Properties);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}