using ArmourAppUi.DataService;
using Xamarin.Forms.Internals;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace ArmourAppUi.Views.Navigation
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationListCardPage : ContentPage
    {
        public NavigationListCardPage()
        {
            InitializeComponent();
            this.BindingContext = NavigationDataService.Instance.NavigationViewModel;
        }


        private void StatisticsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Statistic.MyWalletPage());
        }
        private void NewExercisePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Forms.AddContactPage());
        }
        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Navigation.NavigationListCardPage());
        }
        private void ProfileButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Settings.SettingPage());
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        /*private void YourButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StackLayout stack = button.Parent.Parent as StackLayout;
            Exercises.CurrentExercisesId = int.Parse(button.ClassId);
            Navigation.PushAsync(new CurrentExercise());
        }
        private void DeleteExerciseButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StackLayout stack = button.Parent.Parent as StackLayout;
            App.Database.DeleteItem(int.Parse(button.ClassId));
            App.UpdateMainTableList();
            Navigation.PushAsync(new ProfilePage());
        }*/
    }

    
}