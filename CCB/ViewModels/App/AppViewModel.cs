using CCB.Views.Domain;
using Commands.Implementation;
using Extensions.ViewModel.Implementation;

namespace CCB.ViewModels.App
{
    public class AppViewModel : AppViewModelMenu
    {
        //Adds menu items to the sidebar menu.
        public override void AddCommands()
        {
            NavigationCommands.Add("OpenFrontView", new NavigationCommand(AppFrame, typeof(FrontView)));
            NavigationCommands.Add("OpenInventoryView", new NavigationCommand(AppFrame, typeof(InventoryView)));
            NavigationCommands.Add("OpenProjectView", new NavigationCommand(AppFrame, typeof(ProjectView)));
            NavigationCommands.Add("OpenStaffView", new NavigationCommand(AppFrame, typeof(StaffView)));
        }
    }
}