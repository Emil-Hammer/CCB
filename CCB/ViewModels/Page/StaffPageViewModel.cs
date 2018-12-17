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
    public class StaffPageViewModel : PageViewModelAppBase<Staff>
    {
        public StaffPageViewModel()
            : base(DomainModel.Catalogs.StaffCatalog,
                new List<string> { },
                new List<string> { "Telephone", "Address", "Name", "Employed", "Position"})
        {
        }

        public override IDataWrapper<Staff> CreateDataViewModel(Staff obj)
        {
            return new StaffDataViewModel(obj);
        }
        public override ObservableCollection<IDataWrapper<Staff>> ItemCollection => new ObservableCollection<IDataWrapper<Staff>>(base.ItemCollection.OrderBy(m => m.DataObject.Name));
    }
}