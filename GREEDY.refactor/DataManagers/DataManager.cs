using System.Collections.Generic;
using System.Drawing;
using GREEDY.refactor.Models;

namespace GREEDY.refactor.DataManagers
{
    public class DataManager : IDataManager
    {
        /// <summary>
        /// Saves data to {TBD}
        /// </summary>
        /// <param name="itemList"></param>
        public void SaveData (List<Item> itemList)
        {
            throw new System.NotImplementedException ();
        }

        /// <summary>
        /// Gets data from {TBD}
        /// </summary>
        /// <returns></returns>
        public List<Item> LoadData ()
        {
            throw new System.NotImplementedException ();
        }

        /// <summary>
        /// Gets image from {TBD} (We imagine two possibilities to get a receipt. 
        /// From camera using Emgu.CV and from local file system, such like personal phone (if we create an apps) or
        /// computer (if we create a web application)
        /// </summary>
        /// <returns></returns>
        public Bitmap GetReceiptImage ()
        {
            throw new System.NotImplementedException ();
        }

    }
}