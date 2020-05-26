using ArmourAppUi.DataService.Profile;
using System;
using Xamarin.Forms;

namespace ArmourAppUi.Views.Profile
{
    /// Page to display profile list.
    public partial class ProfilePage : ContentPage
    {
        /// Initializes a new instance of the <see cref="ProfilePage" /> class.
        public ProfilePage()
        {
            InitializeComponent();
            this.BindingContext = ProfileDataService.Instance.ProfileViewModel;
        }

        private void StatisticsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Statistic.StatisticPage());
        }

        private void NewExercisePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Forms.AddContactPage());
        }

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Profile.ProfilePage());
        }

        private void ProfileButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArmourAppUi.Views.Settings.SettingPage());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void SegmentedControl_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            //var currentValue = e.Index;
            //switch (currentValue)
            //{
            //    case 0: ShowTimeExercise(); break;
            //    case 1: ShowGoalExercise(); break;
            //    case 2: ShowRepeatExercise(); break;
            //}
        }
    }
}