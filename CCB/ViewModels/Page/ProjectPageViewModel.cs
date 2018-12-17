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
    public class ProjectPageViewModel : PageViewModelAppBase<Project>
    {
        //ControlStates of ProjectView
        public ProjectPageViewModel()
            //Insert into the catalog:
            : base(DomainModel.Catalogs.ProjectCatalog,
                //Non-editable ControlStates
                new List<string> { },
                //Editable ControlStates
                new List<string> { "Description", "Address", "Telephone", "Start", "Deadline" })
        {
            
        }

        //Creates a DataViewModel and references it. Used for properties in the View
        public override IDataWrapper<Project> CreateDataViewModel(Project obj)
        {
            return new ProjectDataViewModel(obj);
        }

        //Sets up data in the item collection in the ProjectView
        public override ObservableCollection<IDataWrapper<Project>> ItemCollection
        {
            get
            {
                return new ObservableCollection<IDataWrapper<Project>>(base.ItemCollection.OrderBy(m =>((ProjectDataViewModel)m).ColorToNumber).ThenBy(n => n.DataObject.Address)); // .ThenBy(n => n.DataObject.Address // Virker ikke rigtigt
            }
        }
    }
}