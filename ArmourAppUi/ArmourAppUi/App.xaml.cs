using ArmourAppUi.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmourAppUi
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzMzg4QDMxMzgyZTMxMmUzME04UFpEaGZSZlBPcXpBaVBFS0ZBbFFPNVJXbkFVcEtvNnNBWlBlOXhNaEE9");
            InitializeComponent();
            AppData.MockData();
            MainPage = new NavigationPage(new ArmourAppUi.Views.Statistic.MyWalletPage());            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
