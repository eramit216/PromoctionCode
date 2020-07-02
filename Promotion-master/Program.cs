using Promotion_Engine.PromotionBAL;
using Promotion_Engine.PromotionDAL;
using Promotion_Engine.PromotionViewModel;
using System;
using System.Collections.Generic;

namespace Promotion_Engine
{
   public class Program
    {
       public static void Main(string[] args)
        {
            try { 
            List<Promotion_Properties> promotion_Properties = new List<Promotion_Properties>();
            Console.WriteLine("Enter the total number of order");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Promotion_Properties promotion_Pro = new Promotion_Properties();
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("Enter the type of product : A,B,C,D");
                promotion_Pro.Id = Console.ReadLine();
                promotion_Properties.Add(promotion_Pro);
            }
            Promotion_Dependency_Injection promotion_Dependency_Injection = new Promotion_Dependency_Injection(new PromotionDal());
            int totalPromotionPrice = promotion_Dependency_Injection.GetAllPrice(promotion_Properties);
            Console.WriteLine(totalPromotionPrice);
            Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
