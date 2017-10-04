using System.Collections.Generic;
using System.Drawing;
using GREEDY.Models;

namespace GREEDY.DataManagers
{
    public interface IDataManager
    {
        // TODO: rewrite this using generics
        void SaveData(List<Item> itemList);
        List<Item> LoadData();
    }
}