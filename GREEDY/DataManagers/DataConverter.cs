using System.Collections.Generic;
using GREEDY.Models;

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

        private static ShopDistributor shopDistributor => new ShopDistributor();

        public List<Item> ReceiptToItemList(Receipt receipt)
        {
            var shop = shopDistributor.ReceiptDistributor(receipt);
            if(shop == "RIMI")
            {
                //need to check every line and find which contains "Kvitas"

                //string last = receipt.LinesOfText.Last();

                //foreach (string line in receipt.LinesOfText)
                //{
                //    if (line.Equals(last))
                //    {
                //        // do something different with the last item
                //    }
                //    else
                //    {
                //        // do something different with every item but the last
                //    }
                //}
                //if (shopTile.ToUpper().Contains("Kvitas"))
                //{
                //    var shop = "RIMI";
                //    return shop;
                //}
                return null;
            }
            else
            {
                return null;
            }


            
            
            
            //for reading decimal values from xml
            // System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            //customCulture.NumberFormat.NumberDecimalSeparator = ".";
            //System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //{
            //    throw new System.NotImplementedException();
            //}


            //    foreach (String line in receipt.LinesOfText)
            //    {
            //        _data += (line + Environment.NewLine);

            //    }

            //    List<Item> itemsList = new List<Item>();
            //    foreach (var item in _data)
            //    {
            //        itemsList.Add(new Item(item.Name, item.Price, item.Category));
            //    }

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

            //public DataTable GetDataTable()
            //{
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Item");
            //    dt.Columns.Add("Price");
            //    dt.Columns.Add("Category");

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
            //            DataRow dr = dt.NewRow();
            //            dr[0] = m.Groups[1].Value;
            //            dr[1] = m.Groups[3].Value;
            //            dr[2] = "Unknown";
            //            dt.Rows.Add(dr);
            //            dt.TableName = "ItemPriceList";
            //        }
            //    }

            //    return dt;
            //}

        }
    }
}