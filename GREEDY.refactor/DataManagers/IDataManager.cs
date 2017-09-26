using System.Collections.Generic;
using System.Drawing;
using GREEDY.refactor.Models;

namespace GREEDY.refactor.DataManagers
{
    public interface IDataManager
    {
        void SaveData (List<Item> itemList);
        List<Item> LoadData ();
        Bitmap GetReceiptImage ();
    }
}