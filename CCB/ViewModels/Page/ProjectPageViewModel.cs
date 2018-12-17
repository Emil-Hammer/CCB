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
        public ProjectPageViewModel()
            : base(DomainModel.Catalogs.ProjectCatalog,
                new List<string> { },
                new List<string> { "Description", "Address", "Telephone", "Start", "Deadline" })
        {
            
        }

        public override IDataWrapper<Project> CreateDataViewModel(Project obj)
        {
            return new ProjectDataViewModel(obj);
        }

        public override ObservableCollection<IDataWrapper<Project>> ItemCollection
        {
            get
            {
                return new ObservableCollection<IDataWrapper<Project>>(base.ItemCollection.OrderBy(m =>((ProjectDataViewModel)m).ColorToNumber).ThenBy(n => n.DataObject.Address)); // .ThenBy(n => n.DataObject.Address // Virker ikke rigtigt
            }
        }
    }
}