using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP2016Lib.Classes;
using LP2016Lib.Enums;
using LP2016Logic.Repositories;

namespace LP2016Logic.Utilities
{
    public static class CalculatorUtil
    {
        /// <summary>
        /// Calculates the amount of lakes you can travel through with the given budget.
        /// </summary>
        /// <param name="startDate">Starting date of the rental period.</param>
        /// <param name="endDate">End date of the rental period.</param>
        /// <param name="boats">The boats that are being rented.</param>
        /// <param name="articles">The articles that are being rented.</param>
        /// <param name="budget">The budget of the renter.</param>
        /// <param name="waters">The waters the renter is travelling through.</param>
        /// <returns>The amount of lakes you can travel through.</returns>
        public static int CalculateLakes(DateTime startDate, DateTime endDate, List<Boat> boats, List<Article> articles,
            decimal budget, List<Water> waters)
        {
            //TODO change canoe to a variable in the database.
            //TODO give lakes an upper limit to it's lakes.
            //Get the lake that we want to calculate about.
            var lake = FetchRepository.Instance.GetAllWaters().Find(x => x.Type == WaterType.Lake);

            //Amount of days it's being rented.
            var days = (endDate.Date - startDate.Date).Days + 1;

            //Costs per day of all the boats and articles.
            var boatsCostPerDay = boats.Sum(x => x.Price);
            var articleCostPerDay = articles.Sum(x => x.Price);

            //Price for travelling through the gates per day.
            var gatePricePerDay = boats.Exists(x => x.Type != BoatType.Canoe) ? waters.Sum(x => x.Price) : 0;

            //Calculates the total cost for rented the boats for all days and travelling over all the waters for all days.
            var totalItemCost = days*(boatsCostPerDay + articleCostPerDay);
            var totalWaterCost = days*gatePricePerDay;

            var remainder = budget - (totalItemCost + totalWaterCost);

            //If there are only boats that don't pay per gate and there's enough money for the rented stuff return the maximum amount.
            if (remainder >= 0 && boats.TrueForAll(x => x.Type == BoatType.Canoe))
                return 12;

            int result;

            //If we can travel through more lakes than the limit, use the new price in the calculation.
            if (remainder > lake.Limit*lake.Price*days)
            {
                result = lake.Limit;
                remainder = remainder - lake.Limit*lake.Price*days;
                result += (int) Math.Floor(remainder/((lake.Price + lake.PriceExtra)*days));
            }
            else
                result = (int) Math.Floor(remainder/(lake.Price*days));

            //Make sure the result is within bounds.
            if (result > 12)
                result = 12;
            if (result < 0)
                result = 0;

            return result;
        }
    }
}
