using System;
using System.Collections.Generic;
using System.Globalization;
using LP2016Lib.Classes;
using LP2016Lib.Enums;
using LP2016Logic.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP2016Test
{
    [TestClass]
    public class CalculatorUtilTest
    {
        [TestMethod]
        public void CalculatLakesTest()
        {
            var allowedInOne = new List<Water> {new Water(1, "Noordzee", 2, WaterType.Sea, 1)};

            var startDate = DateTime.ParseExact("11-07-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact("12-07-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var boats = new List<Boat> {new MuscleBoat(1, "", 10, BoatType.Canoe, null, false)};
            var articles = new List<Article>();
            var budget = 20;
            var waters = new List<Water>();

            var result = CalculatorUtil.CalculateLakes(startDate, endDate, boats, articles, budget, waters);

            Assert.AreEqual(12, result);
        }
    }
}
