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
        //ControlStates of InventoryView
        public InventoryPageViewModel()
            //Insert into the catalog
            : base(DomainModel.Catalogs.ItemCatalog,
                //Non-editable ControlStates
                new List<string> { },
                //Editable ControlStates
                new List<string> { "Name", "AmountAvailable", "AmountAllocated", "Amount" })
        {
        }

        //Creates a DataViewModel and references it. Used for properties in the View
        public override IDataWrapper<Item> CreateDataViewModel(Item obj)
        {
            return new InventoryDataViewModel(obj);
        }

        //Sets up data in the item collection in the InventoryView
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