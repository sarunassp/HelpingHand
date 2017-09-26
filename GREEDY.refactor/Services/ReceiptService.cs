using System.Collections.Generic;
using GREEDY.refactor.DataManagers;
using GREEDY.refactor.Models;
using GREEDY.refactor.OCRs;

namespace GREEDY.refactor.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly IOcr _ocr;
        private readonly IDataConverter _dataConverter;
        private readonly IDataManager _dataManager;
        
        public ReceiptService (IOcr ocr, IDataConverter dataConverter, IDataManager dataManager)
        {
            _ocr = ocr;
            _dataConverter = dataConverter;
            _dataManager = dataManager;
        }
        
        public List<Item> ProcessReceiptImage ()
        {
            var receiptImage = _dataManager.GetReceiptImage ();
            var receipt = _ocr.ConvertImage (receiptImage);
            var itemList = _dataConverter.ReceiptToItemList (receipt);
            _dataManager.SaveData (itemList);
            return itemList;
        }
    }
}