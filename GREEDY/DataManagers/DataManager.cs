using System.Collections.Generic;
using GREEDY.Models;
using System.Windows.Forms;
using System.IO;

namespace GREEDY.DataManagers
{
    public class DataManager : IDataManager
    {
        private readonly SaveFileDialog _saveFileDialog;
        private readonly string _saveDataDialogTitle = "Save an Image File";

        public DataManager()
        {
            _saveFileDialog = new SaveFileDialog();
        }

        public void SaveData(List<Item> itemList)
        {
            using (_saveFileDialog)
            {
                _saveFileDialog.InitialDirectory = Environments.AppConfig.SaveFilePath;
                _saveFileDialog.Title = _saveDataDialogTitle;
                _saveFileDialog.RestoreDirectory = true;

                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = (FileStream)_saveFileDialog.OpenFile();
                    fs.Close();
                }
            };
        }

        /// <summary>
        /// Gets data from {TBD}
        /// </summary>
        /// <returns></returns>
        public List<Item> LoadData()
        {
            throw new System.NotImplementedException();
        }
    }
}