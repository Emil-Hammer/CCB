using System.Collections.Generic;
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
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }

        public override IDataWrapper<Project> CreateDataViewModel(Project obj)
        {
            return new ProjectDataViewModel(obj);
        }
    }
}