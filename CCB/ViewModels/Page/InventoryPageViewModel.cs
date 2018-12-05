using System.Collections.Generic;
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
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }

        public override IDataWrapper<Item> CreateDataViewModel(Item obj)
        {
            return new InventoryDataViewModel(obj);
        }
    }
}