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
    /// <summary>
    /// Page to display app usage list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppUsagePage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUsagePage" /> class.
        /// </summary>
        public AppUsagePage()
        {
            InitializeComponent();
            this.BindingContext = AppUsageDataService.Instance.AppUsageViewModel;
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

        private void SegmentedControl_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            /*var currentValue = e.Index;

            switch (currentValue)
            {
                case 0: ShowTimeExercise(); break;
                case 1: ShowGoalExercise(); break;
                case 2: ShowRepeatExercise(); break;
            }*/
        }
    }
}