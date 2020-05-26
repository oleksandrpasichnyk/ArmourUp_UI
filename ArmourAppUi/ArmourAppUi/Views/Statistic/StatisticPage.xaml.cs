using ArmourAppUi.DataService.Statistic;
using System;
using Xamarin.Forms;

namespace ArmourAppUi.Views.Statistic
{
    public partial class StatisticPage : ContentPage
    {
        public StatisticPage()
        {
            InitializeComponent();
            this.BindingContext = StatisticDataService.Instance.StatisticViewModel;
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
    }
}