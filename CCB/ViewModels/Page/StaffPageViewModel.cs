using System.Collections.Generic;
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
            : base(DomainModel.Catalogs.Employees,
                new List<string> { "Name", "CarsSold" },
                new List<string> { "Image", "Title", "Phone", "Email", "Employed" })
        {
        }

        public override IDataWrapper<Staff> CreateDataViewModel(Staff obj)
        {
            return new StaffDataViewModel(obj);
        }
    }
}