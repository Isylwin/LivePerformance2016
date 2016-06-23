using System.Collections.Generic;
using System.IO;
using System.Linq;
using LP2016Lib.Classes;

namespace LP2016Logic.Utilities
{
    public static class ExportUtil
    {
        /// <summary>
        /// Exports a contract to a txt file.
        /// </summary>
        /// <param name="contract">The contract.</param>
        /// <param name="path">The path to export to.</param>
        public static void ExportContractToTxt(Contract contract, string path)
        {
            var contents = new List<string>();
            var boats = contract.Items.FindAll(x => x is Boat).ToList();
            var articles = contract.Items.FindAll(x => x is Article).ToList();

            contents.Add($"Huurder: {contract.Renter}");
            contents.Add($"Begin datum: {contract.StartDate.ToString("dd-MM-yyyy")}");
            contents.Add($"Eind datum: {contract.EndDate.ToString("dd-MM-yyyy")}");
            contents.Add("\nBoten:");
            boats.ForEach(x => contents.Add("-- " + x.ToString()));
            contents.Add("\nArtikelen");
            articles.ForEach(x => contents.Add("-- " + x.ToString()));

            File.WriteAllLines(path, contents);
        }
    }
}
