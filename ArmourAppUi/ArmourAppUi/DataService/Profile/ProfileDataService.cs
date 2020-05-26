using ArmourAppUi.Data;
using ArmourAppUi.Models.Profile;
using ArmourAppUi.ViewModels.Profile;
using System.Collections.ObjectModel;

namespace ArmourAppUi.DataService.Profile
{
    // Data service for profile page to load the data.
    public class ProfileDataService
    {
        private static ProfileDataService instance;
        private ProfileViewModel profileViewModel;

        /// Gets an instance of the <see cref="ProfileDataService"/>.
        public static ProfileDataService Instance => instance ?? (instance = new ProfileDataService());

        // Gets or sets the value of profile page view model.
        public ProfileViewModel ProfileViewModel =>
            this.profileViewModel ??
            (this.profileViewModel = PopulateData());

        private static ProfileViewModel PopulateData()
        {
            ObservableCollection<ProfileModel> profileList = new ObservableCollection<ProfileModel>();
            foreach (var item in AppData.MainTableArray)
            {
                switch (item.Type)
                {
                    case 1:
                        profileList.Add(new ProfileModel() { NameExercise = item.Name, BackgroundColor = "#2f80ed", ExerciseIcon = "goal_icon.png", ProgressBarValue = "45", ProgressPercent = "45%" });
                        break;

                    case 2:
                        profileList.Add(new ProfileModel() { NameExercise = item.Name, BackgroundColor = "#eb5757", ExerciseIcon = "repeat_icon.png", ProgressBarValue = "50", ProgressPercent = "50%" });
                        break;

                    case 3:
                        profileList.Add(new ProfileModel() { NameExercise = item.Name, BackgroundColor = "#f2c94c", ExerciseIcon = "time_icon.png", ProgressBarValue = "55", ProgressPercent = "55%" });
                        break;

                    default:
                        break;
                }
            }
            return new ProfileViewModel() { ProfileList = profileList };
        }
    }
}