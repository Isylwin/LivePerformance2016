using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using LP2016Lib.Classes;
using static System.Math;

namespace LP2016Logic.Utilities
{
    public static class TempratureUtil
    {
        //Gets the tempratures for a certain day.
        public static Dictionary<string, string> GetTempratureForContract(Contract contract)
        {
            //Get all the lines from the csv.
            var tempratures = File.ReadAllLines(@"./verwachting.csv");
            var result = new Dictionary<string, string>();

            //For each line in tempratures.
            foreach (var line in tempratures)
            {
                var temp = line.Split(';');

                //Convert the days to datetime, and the temp and wind to ints.
                var day = DateTime.ParseExact(temp[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var temprature = Convert.ToInt32(temp[1]);
                var windSpeed = Convert.ToInt32(temp[2]);

                //If the day is known calculate the feeling.
                if (contract.StartDate <= day && day <= contract.EndDate)
                {
                    var calc =
                        Round(33 + (temprature - 33)*(0.474 + 0.454*Sqrt(windSpeed) - 0.0454*windSpeed), 2);
                    var feeling = $"{calc}°C";
                    result.Add(day.ToString("dd-MM-yyyy"), feeling);
                }
            }

            return result;
        }
    }
}
