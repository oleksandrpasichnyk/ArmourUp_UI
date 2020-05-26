using ArmourAppUi.Models.Profile;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ArmourAppUi.ViewModels.Profile
{
    // ViewModel for profile page.
    public class ProfileViewModel : BaseViewModel
    {
        private Command<object> itemTappedCommand;

        /// Initializes a new instance for the <see cref="ProfileViewModel"/> class.
        public ProfileViewModel()
        {
        }

        // Gets the command that will be executed when an item is selected.
        public Command<object> ItemTappedCommand
        {
            get
            {
                return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
            }
        }

        // Gets or sets a collection of value to be displayed in profile list page.
        public ObservableCollection<ProfileModel> ProfileList { get; set; }

        // Invoked when an item is selected from the profile list page.
        /// <param name="selectedItem">, selected item from the list view.
        private void NavigateToNextPage(object selectedItem)
        {
            // Do something
        }
    }
}