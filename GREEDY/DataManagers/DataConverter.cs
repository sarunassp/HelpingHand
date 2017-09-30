using System.Collections.Generic;
using GREEDY.Models;
using System.Linq;

namespace GREEDY.DataManagers
{
    public class DataConverter : IDataConverter
    {
        // TODO: fix summary
        /// <summary>
        /// Parses receipt to item list, can just change to any type thats easy to read
        /// </summary>
        /// <param name="receipt"></param>
        /// <returns></returns>
        /// 

        private static ShopDistributor ShopDistributor => new ShopDistributor();

        public List<Item> ReceiptToItemList(Receipt receipt)
        {
            var shop = ShopDistributor.ReceiptDistributor(receipt);
            if (shop == "RIMI" || shop == "MAXIMA")
            {
                foreach (string line in receipt.LinesOfText)
                {
                    if (line.ToUpper().Contains("KVITAS") || line.ToUpper().Contains("PIRKĖJAS"))
                    {
                        throw new System.NotImplementedException();
                    }
                }

                //    foreach (String line in receipt.LinesOfText)
                //    {
                //        _data += (line + Environment.NewLine);
                //    }

                //List<Item> itemsList = new List<Item>();
                //foreach (var item in _data)
                //{
                //    itemsList.Add(new Item(item.Name, item.Price, item.Category));
                //}

                //    string pattern;
                //    string input;

                //    pattern = @"([*]+)\n(.+)\n([*]+)";
                //    input = _data;
                //    input = Regex.Replace(input, @"\r", "");

                //    Match match = Regex.Match(input, pattern, RegexOptions.Singleline);
                //    if (match.Success)
                //    {
                //        input = match.Groups[2].Value;
                //        pattern = @"([^..]*)([.]+)( \d+,\d\d)";

                //        MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.Singleline);
                //        foreach (Match m in matches)
                //        {
                //            itemlList.Add(new Item(m.Groups[1].Value, decimal.Parse(m.Groups[3].Value)));
                //        }
                //    }
                //    return itemlList;
                //}

                return null;
            }
            else
            {
                throw new System.NotImplementedException();
            }
        }
    }
}