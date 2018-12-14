using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using AddOns.Images.Implementation;
using AddOns.Images.Interfaces;
using CCB.Models.App;
using CCB.ViewModels.App;
using CCB.Views.App;
using CCB.Views.Domain;
using Commands.Implementation;
using Extensions.AddOns.Implementation;

namespace CCB.Configuration.App
{
    public class AppConfig
    {
        public static void Setup(Page mainPage, Frame appFrame)
        {
            DomainModel.Instance.LoadAsync(); // Loading data from database before opening program

            appFrame.Navigate(typeof(FrontView)); // Configuring the first view to see when you open the program
            ((AppViewModel)mainPage.DataContext).SetAppFrame(appFrame); 
        }
    }
}