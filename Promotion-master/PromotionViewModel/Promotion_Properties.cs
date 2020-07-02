using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Promotion_Engine.PromotionViewModel
{
  public class Promotion_Properties
    {
        public Promotion_Properties()
        {

        }
        /// <summary>
        /// Product Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        public decimal Price { get; set; }
    }
}
