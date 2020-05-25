using ArmourAppUi.Data;
using ArmourAppUi.Models.Navigation;
using ArmourAppUi.ViewModels.Navigation;
using System.Collections.ObjectModel;

namespace ArmourAppUi.DataService
{
    /// <summary>
    /// Data service for app usage page to load the data.
    /// </summary>
    public class AppUsageDataService
    {
        #region fields

        private static AppUsageDataService instance;

        private AppUsageViewModel appUsageViewModel;

        #endregion fields

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="AppUsageDataService"/>.
        /// </summary>
        public static AppUsageDataService Instance => instance ?? (instance = new AppUsageDataService());

        /// <summary>
        /// Gets or sets the value of app usage page view model.
        /// </summary>
        public AppUsageViewModel AppUsageViewModel =>
            this.appUsageViewModel ??
            (this.appUsageViewModel = PopulateData());

        #endregion Properties

        #region Methods

        private static AppUsageViewModel PopulateData()
        {
            ObservableCollection<AppUsage> appUsageList = new ObservableCollection<AppUsage>();
            foreach (var item in AppData.MainTableArray)
            {
                switch (item.Type)
                {
                    case 1:
                        appUsageList.Add(new AppUsage() { NameExercise = item.Name, BackgroundColor = "#2f80ed", ProgressBarValue = "45", ProgressValue = "45%" });
                        break;

                    case 2:
                        appUsageList.Add(new AppUsage() { NameExercise = item.Name, BackgroundColor = "#eb5757", ProgressBarValue = "50", ProgressValue = "50%" });
                        break;

                    case 3:
                        appUsageList.Add(new AppUsage() { NameExercise = item.Name, BackgroundColor = "#f2c94c", ProgressBarValue = "55", ProgressValue = "55%" });
                        break;

                    default:
                        break;
                }
            }
            return new AppUsageViewModel() { AppUsageList = appUsageList };
        }

        #endregion Methods
    }
}