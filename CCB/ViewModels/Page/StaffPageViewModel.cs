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
        // ControlStates of StaffView
        public StaffPageViewModel()
            //Insert into the catalog
            : base(DomainModel.Catalogs.StaffCatalog,
                //Non-editable ControlStates
                new List<string> { },
                //Editable ControlStates
                new List<string> { "Telephone", "Address", "Name", "Employed", "Position"})
        {
        }

        //Creates a DataViewModel and references it. Used for the properties in the View
        public override IDataWrapper<Staff> CreateDataViewModel(Staff obj)
        {
            return new StaffDataViewModel(obj);
        }

        //Sets up data in the item collection in the StaffView
        public override ObservableCollection<IDataWrapper<Staff>> ItemCollection => new ObservableCollection<IDataWrapper<Staff>>(base.ItemCollection.OrderBy(m => m.DataObject.Name));
    }
}