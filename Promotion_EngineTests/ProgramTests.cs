using Microsoft.VisualStudio.TestTools.UnitTesting;
using Promotion_Engine;
using Promotion_Engine.PromotionBAL.Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Promotion_Dependency_InjectionTests promotion_Dependency_InjectionTests = new Promotion_Dependency_InjectionTests();
            promotion_Dependency_InjectionTests.GetAllPriceTest();
        }
    }
}