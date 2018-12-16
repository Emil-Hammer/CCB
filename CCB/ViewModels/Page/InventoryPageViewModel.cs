using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CCB.Data.Domain;
using CCB.Models.App;
using CCB.ViewModels.Base;
using Data.InMemory.Interfaces;
using CCB.ViewModels.Data;

namespace CCB.ViewModels.Page
{
    public class InventoryPageViewModel : PageViewModelAppBase<Item>
    {
        public InventoryPageViewModel()
            : base(DomainModel.Catalogs.ItemCatalog,
                new List<string> { },
                new List<string> {"Name", "AmountAvailable", "AmountAllocated", "Amount"})
        {
        }

        public override IDataWrapper<Item> CreateDataViewModel(Item obj)
        {
            return new InventoryDataViewModel(obj);
        }

        public IOrderedEnumerable<IDataWrapper<Item>> SortedItemCollection
        {
            get
            {
                OnPropertyChanged();
                return ItemCollection.OrderBy(m => m.DataObject.Name);
            }
        }
    }
}