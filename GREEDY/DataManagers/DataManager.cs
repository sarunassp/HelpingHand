﻿using System.Collections.Generic;
using GREEDY.Models;
using System.Windows.Forms;
using System.IO;

namespace GREEDY.DataManagers
{
    public class DataManager : IDataManager
    {
        private static IAppConfig AppConfig => new AppConfig();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        
        // not tested yet. Need to write a methods to create a file
        public void SaveData(List<Item> itemList)
        {
            using (saveFileDialog)
            {
                saveFileDialog.InitialDirectory = AppConfig.SaveFilePath;
                //saveFileDialog.Filter = _config.Filter;
                saveFileDialog.Title = "Save an XML File";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //var SaveDataPath = saveFileDialog.FileName;
                    if (saveFileDialog.FileName != "")
                    {
                        FileStream fs = (FileStream)saveFileDialog.OpenFile();
                        fs.Close();
                    }
                    else
                    {
                        // what do you think about this part? how can I write exception if user close a window and do not select a picture/file?
                    }
                }
            };
        }

        /// <summary>
        /// Gets data from {TBD}
        /// </summary>
        /// <returns></returns>
        public List<Item> LoadData ()
        {
            throw new System.NotImplementedException ();
        }
    }
}