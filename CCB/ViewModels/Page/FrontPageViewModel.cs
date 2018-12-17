using System.Collections.Generic;
using CCB.Data.Domain;
using CCB.Models.App;
using CCB.ViewModels.Base;
using Data.InMemory.Interfaces;
using CCB.ViewModels.Data;

namespace CCB.ViewModels.Page
{
    public class FrontPageViewModel : PageViewModelAppBase<Logbook>
    {
        //ControlStates of FrontView (Logbook function)
        public FrontPageViewModel()
            //Insert into the catalog:
            : base(DomainModel.Catalogs.LogbookCatalog,
                //Non-editable ControlStates
                new List<string> { },
                //Editable ControlStates
                new List<string> { })
        {
        }

        //Creates a DataViewModel and references it. Used for properties in the View
        public override IDataWrapper<Logbook> CreateDataViewModel(Logbook obj)
        {
            return new FrontDataViewModel(obj);
        }

        
    }
}