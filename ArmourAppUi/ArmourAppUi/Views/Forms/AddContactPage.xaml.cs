using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.XForms.Buttons;
using Syncfusion.XForms.Pickers;
using Syncfusion.XForms.TextInputLayout;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ArmourAppUi.Views.Forms
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        private SfTimePicker timePicker;
        private Label pickerValueLabel;

        public AddContactPage()
        {
            InitializeComponent();
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

        private void Timepeacker_Button_Clicked(object sender, System.EventArgs e)
        {
            timePicker.IsOpen = true;
        }

        /*private Repeat_Button_Clicked(int n, int k)
        {
            SfTextInputLayout repeat_input = new SfTextInputLayout()
            {
                Hint = "Repeat #1",
                HelperText = "",
                ContainerType = ContainerType.Outlined,
            };
            repeat_input.InputView = new SfNumericTextBox();

            ExerciseGoal.Children.Add(repeat_input);
        }*/

        private void TimePicker_TimeSelected(object sender, TimeChangedEventArgs e)
        {
            pickerValueLabel.Text = $"{e.NewValue}";
            //DisplayAlert("TimeSelected", "NewValue: " + e.NewValue + "\n" + "OldValue: " + e.OldValue, "Ok");
        }

        private void ShowTimeExercise()
        {
            exerciseGoal.Children.Clear();

            StackLayout ExerciseGoal = new StackLayout()
            {
                HeightRequest = 70,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 20, 20, 20)
            };

            pickerValueLabel = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "0h 0m 0s",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                //FontAttributes = FontAttribute.Bold
            };

            timePicker = new SfTimePicker()
            {
                HeaderText = "Select a time",
                ShowFooter = true,
                PickerHeight = 300,
                PickerWidth = 300,
                Time = new TimeSpan(0, 00, 00),
                //OKButtonBackgroundColor = Color.Pink,
                //CancelButtonBackgroundColor = Color.Pink
            };
            timePicker.EnableLooping = true;
            timePicker.PickerMode = PickerMode.Dialog;
            timePicker.TimeSelected += TimePicker_TimeSelected;

            SfButton pickerButton = new SfButton()
            {
                Text = "SET VALUE",
                HeightRequest = 35,
                WidthRequest = 120,
                //Style = (Style)Resources["SfButtonStyle"],
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 20,
                TextColor = Color.White
            };
            pickerButton.Clicked += Timepeacker_Button_Clicked;
            //pickerButton.Style = (Style)Resources["SfButtonStyle"];
            StackLayout ExerciseGoalPicker = new StackLayout()
            {
                WidthRequest = 150,
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                //Margin = new Thickness(0, 0, 0, 0),
                Children = { pickerValueLabel, timePicker, pickerButton }
            };

            ExerciseGoal.Children.Add(ExerciseGoalPicker);

            exerciseGoal.Children.Add(ExerciseGoal);
        }

        private void ShowGoalExercise()
        {
            exerciseGoal.Children.Clear();

            StackLayout ExerciseGoal = new StackLayout()
            {
                HeightRequest = 70,
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 20, 20, 20)
            };

            SfTextInputLayout GoalNumericTextBox = new SfTextInputLayout()
            {
                Hint = "Excercise goal",
                //HelperText = "Enter your goal",

                ContainerType = ContainerType.Outlined,
            };
            GoalNumericTextBox.InputView = new SfNumericTextBox()
            {
                MaximumNumberDecimalDigits = 0,
                ParserMode = Parsers.Decimal
            };
            //GoalNumericTextBox.ParserMode = Parsers.Decimal;

            //SfNumericTextBox GoalNumericTextBox = new SfNumericTextBox
            //{
            //    Watermark = "Enter your goal",
            //    FormatString = " times",

            //    //HeightRequest = 100,
            //    //PercentDisplayMode = PercentDisplayMode.Value,        //unlock here
            //    ParserMode = Parsers.Decimal,
            //    WidthRequest = 150,
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    FontAttributes = FontAttributes.Bold
            //};

            ExerciseGoal.Children.Add(GoalNumericTextBox);

            exerciseGoal.Children.Add(ExerciseGoal);
        }  //object sender, EventArgs e

        private void ShowRepeatExercise()
        {
            exerciseGoal.Children.Clear();

            StackLayout ExerciseGoal = new StackLayout()
            {
                //HeightRequest = 70,
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 20, 20, 20)
            };

            SfTextInputLayout number_of_repeatitions_input = new SfTextInputLayout()
            {
                Hint = "Number of repeatitions",
                HelperText = "",
                ContainerType = ContainerType.Outlined
            };
            number_of_repeatitions_input.InputView = new SfNumericTextBox()
            {
                MaximumNumberDecimalDigits = 0,
                ParserMode = Parsers.Decimal
            };

            SfTextInputLayout times_per_repeatition_input = new SfTextInputLayout()
            {
                Hint = "Times/repetition",
                HelperText = "",
                ContainerType = ContainerType.Outlined,
            };
            times_per_repeatition_input.InputView = new SfNumericTextBox()
            {
                MaximumNumberDecimalDigits = 0,
                ParserMode = Parsers.Decimal
            };

            SfButton repeatButton = new SfButton()
            {
                Text = "Create repeats",
                HeightRequest = 35,
                WidthRequest = 120,
                //Style = (Style)Resources["SfButtonStyle"],
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 20,
                TextColor = Color.White
            };
            //repeatButton.Clicked += Repeat_Button_Clicked(number_of_repeatitions_input.Text, times_per_repeatition_input.Text);

            ExerciseGoal.Children.Add(number_of_repeatitions_input);
            ExerciseGoal.Children.Add(times_per_repeatition_input);
            ExerciseGoal.Children.Add(repeatButton);

            exerciseGoal.Children.Add(ExerciseGoal);
        }

        private void SegmentedControl_SelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            var currentValue = e.Index;

            switch (currentValue)
            {
                case 0: ShowTimeExercise(); break;
                case 1: ShowGoalExercise(); break;
                case 2: ShowRepeatExercise(); break;
            }
        }
    }
}