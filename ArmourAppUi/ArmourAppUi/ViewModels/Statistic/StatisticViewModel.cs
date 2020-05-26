using ArmourAppUi.Models.Statistic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ArmourAppUi.ViewModels.Statistic
{
    public class StatisticViewModel : BaseViewModel
    {
        private Command<object> itemTappedCommand;

        public StatisticViewModel()
        {
        }

        public ObservableCollection<StatisticModel> StatisticList { get; set; }

        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
            }
        }

        /// Invoked when an item is selected from the my wallet page.
        /// <param name="selectedItem">Selected item from the list view.</param>
        private void NavigateToNextPage(object selectedItem)
        {
            // Do something
        }
    }
}