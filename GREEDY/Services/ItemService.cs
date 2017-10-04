using GREEDY.DataManagers;

namespace GREEDY.Services
{
    public class ItemService : IItemService
    {
        private readonly IDataConverter _dataConverter;
        private readonly IDataManager _dataManager;
        private readonly IItemCategorization _itemCategorization;

        public ItemService(
            IDataConverter dataConverter, IDataManager dataManager, IItemCategorization itemCategorization)
        {
            _dataConverter = dataConverter;
            _dataManager = dataManager;
            _itemCategorization = itemCategorization;
        }

        /// TODO:
        // you're basically calling a single method from another class, why not just use that class instead?
        public void AddChangeCategory(string itemName, string category)
        {
            _itemCategorization.AddChangeCategories(itemName.ToLower(), category.ToLower());
        }
    }
}