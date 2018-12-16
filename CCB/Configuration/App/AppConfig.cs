using Windows.UI.Xaml.Controls;
using CCB.Models.App;
using CCB.ViewModels.App;
using CCB.Views.Domain;

namespace CCB.Configuration.App
{
    public class AppConfig
    {
        public static async void Setup(Page mainPage, Frame appFrame)
        {
            await DomainModel.Instance.LoadAsync(); // Loading data from database before opening program

            appFrame.Navigate(typeof(FrontView)); // Configuring the first view to see when you open the program
            ((AppViewModel)mainPage.DataContext).SetAppFrame(appFrame); 
        }
    }
}