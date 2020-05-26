using ArmourAppUi.Data;
using ArmourAppUi.Models.Statistic;
using ArmourAppUi.ViewModels.Statistic;
using System.Collections.ObjectModel;

namespace ArmourAppUi.DataService.Statistic
{
    // Data service for statistic page to load the data.
    public class StatisticDataService
    {
        private static StatisticDataService instance;
        private StatisticViewModel statisticViewModel;

        /// Gets an instance of the <see cref="StatisticDataService"/>.
        public static StatisticDataService Instance => instance ?? (instance = new StatisticDataService());

        // Gets or sets the value of statistic page view model.
        public StatisticViewModel StatisticViewModel =>
            this.statisticViewModel ??
            (this.statisticViewModel = PopulateData());

        private static StatisticViewModel PopulateData()
        {
            ObservableCollection<StatisticModel> statisticList = new ObservableCollection<StatisticModel>();
            foreach (var item in AppData.MainTableArray)
            {
                switch (item.Type)
                {
                    case 1:
                        statisticList.Add(new StatisticModel() { NameExercise = item.Name, Progress = "+5", IsProgress = true, Purpose = item.Purpose + " повтореннь", ExerciseIcon = "goal_icon.png", ProgressPercent = "45%" });
                        break;

                    case 2:
                        statisticList.Add(new StatisticModel() { NameExercise = item.Name, Progress = "-10", IsProgress = false, Purpose = item.Purpose, ExerciseIcon = "repeat_icon.png", ProgressPercent = "50%" });
                        break;

                    case 3:
                        statisticList.Add(new StatisticModel() { NameExercise = item.Name, Progress = item.Progress + "s", IsProgress = true, Purpose = item.Purpose + "s", ExerciseIcon = "time_icon.png", ProgressPercent = item.Percent + "%" });
                        break;

                    default:
                        break;
                }
            }
            return new StatisticViewModel() { StatisticList = statisticList };
        }
    }
}