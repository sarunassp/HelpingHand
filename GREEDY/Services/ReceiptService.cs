using System.Collections.Generic;
using GREEDY.DataManagers;
using GREEDY.Models;
using GREEDY.OCRs;
using System.Drawing;

namespace GREEDY.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly IOcr _ocr;
        private readonly IDataConverter _dataConverter;
        private readonly IDataManager _dataManager;
        //private readonly IShopDistributor _shopDistributor;

        public ReceiptService(IOcr ocr, IDataConverter dataConverter, IDataManager dataManager)
        {
            _ocr = ocr;
            _dataConverter = dataConverter;
            _dataManager = dataManager;
            //_shopDistributor = shopDistributor;
        }

        public List<Item> ProcessReceiptImage(Bitmap image)
        {
            var receipt = _ocr.ConvertImage(image);
            //var itemList = _shopDistributor.ReceiptDistributor(receipt);
            var itemList = _dataConverter.ReceiptToItemList(receipt);
            _dataManager.SaveData(itemList);
            return itemList;
        }
    }
}