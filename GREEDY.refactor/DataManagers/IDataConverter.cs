using System.Collections.Generic;
using GREEDY.refactor.Models;

namespace GREEDY.refactor.DataManagers
{
    public interface IDataConverter
    {
        List<Item> ReceiptToItemList (Receipt receipt);
    }
}