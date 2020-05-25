using ArmourAppUi.DataService;
using Xamarin.Forms.Internals;

using System;
using System.Collections.Generic;
using Syncfusion.SfCalendar.XForms;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmourAppUi.Views.Statistic
{
    /// <summary>
    /// My wallet page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyWalletPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyWalletPage"/> class.
        /// </summary>
        public MyWalletPage()
        {
            InitializeComponent();
            
            List<DateTime> selectedDates = new List<DateTime>();
            selectedDates = new List<DateTime>();
            selectedDates.Add(new DateTime(2020, 5, 20));
            selectedDates.Add(new DateTime(2019, 5, 8));
            selectedDates.Add(new DateTime(2019, 5, 10));
            selectedDates.Add(new DateTime(2019, 5, 14));
            selectedDates.Add(new DateTime(2019, 5, 20));
            calendar.SelectedDates = selectedDates;
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
            Navigation.PushAsync(new ArmourAppUi.Views.Navigation.AppUsagePage());
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