using CCB.Views.App;
using CCB.Views.Domain;
using Commands.Implementation;
using Extensions.ViewModel.Implementation;

namespace CCB.ViewModels.App
{
    public class AppViewModel : AppViewModelMenu
    {
        public override void AddCommands()
        {
            NavigationCommands.Add("OpenMainPage", new NavigationCommand(AppFrame, typeof(FileView)));
            NavigationCommands.Add("OpenInventoryView", new NavigationCommand(AppFrame, typeof(InventoryView)));
            NavigationCommands.Add("OpenProjectView", new NavigationCommand(AppFrame, typeof(ProjectView)));
            NavigationCommands.Add("OpenStaffView", new NavigationCommand(AppFrame, typeof(StaffView)));
        }
    }
}