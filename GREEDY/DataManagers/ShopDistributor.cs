using GREEDY.Models;
using System.Linq;

namespace GREEDY.DataManagers
{
    class ShopDistributor
    {
        public string ReceiptDistributor(Receipt receipt)
        {
            //need to make shroter
            var shopTile = "";
            for (int i =0; i < 4; i++)
            {
                shopTile += receipt.LinesOfText.ElementAt(i);
            }

            if (shopTile.ToUpper().Contains("RIMI"))
            {
                var shop = "RIMI";
                return shop;
            }
            else if (shopTile.ToUpper().Contains("MAXIMA"))
            {
                var shop = "MAXIMA";
                return shop;
            }
            else
            {
                return "";
            }
        }
    }
}
