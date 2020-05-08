using ArmourAppUi.DataService;
using Xamarin.Forms.Internals;
using Syncfusion.XForms.Pickers;
using Syncfusion.XForms.Expander;
using Syncfusion.SfNumericTextBox.XForms;


using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.ListView.XForms;
using Syncfusion.XForms.Buttons;


namespace ArmourAppUi.Views.Forms
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        SfTimePicker timePicker;
        Label pickerValueLabel;
        public AddContactPage()
        {
            InitializeComponent();
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

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            timePicker.IsOpen = true;
        }

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
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 20, 20, 20)
            };

            Image ExerciseIcon = new Image
            {
                Source = "time_icon_color.png",
                HeightRequest = 100,
                WidthRequest = 100
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
                PickerMode = PickerMode.Dialog,
                PickerHeight = 300,
                PickerWidth = 300,
                Time = new TimeSpan(0, 00, 00),
                OKButtonBackgroundColor = Color.Pink,
                CancelButtonBackgroundColor = Color.Pink
            };
            timePicker.EnableLooping = true;
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
            pickerButton.Clicked += Button_Clicked;
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

            ExerciseGoal.Children.Add(ExerciseIcon);
            ExerciseGoal.Children.Add(ExerciseGoalPicker);

            exerciseGoal.Children.Add(ExerciseGoal);
        }

        private void ShowGoalExercise()
        {
            exerciseGoal.Children.Clear();



            StackLayout ExerciseGoal = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 20, 20, 20)
            };

            SfNumericTextBox GoalNumericTextBox = new SfNumericTextBox
            {
                Watermark = "Enter your goal",
                FormatString = " times",
                
                //HeightRequest = 100,
                PercentDisplayMode = PercentDisplayMode.Value,
                ParserMode = Parsers.Decimal,
                WidthRequest = 150,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            ExerciseGoal.Children.Add(GoalNumericTextBox);

            exerciseGoal.Children.Add(ExerciseGoal);
        }  //object sender, EventArgs e

        private void ShowRepeatExercise()
        {
            exerciseGoal.Children.Clear();



            StackLayout ExerciseGoal = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 50, 20, 0)
            };

            Image ExerciseIcon = new Image
            {
                Source = "time_icon_color.png",
                HeightRequest = 100,
                WidthRequest = 100
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
                PickerMode = PickerMode.Dialog,
                PickerHeight = 300,
                PickerWidth = 300,
                Time = new TimeSpan(0, 00, 00),
                OKButtonBackgroundColor = Color.Pink,
                CancelButtonBackgroundColor = Color.Pink
            };
            timePicker.EnableLooping = true;
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
            pickerButton.Clicked += Button_Clicked;
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
            ExerciseGoal.Children.Add(ExerciseIcon);
            ExerciseGoal.Children.Add(ExerciseGoalPicker);
            /*ExerciseGoal.Children.Add(pickerValueLabel);
            ExerciseGoal.Children.Add(timePicker);
            ExerciseGoal.Children.Add(pickerButton);*/
            //this.Content = grid;

            //StackLayout goal = new StackLayout().LoadFromXaml(xaml);
            //exerciseGoal.Content = xaml;
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

/*<StackLayout Padding="0,50,0,0" Orientation="Horizontal" HorizontalOptions="Center">
                    <StackLayout HorizontalOptions="Start">
                        <Image Source="time_icon_color.png" HeightRequest="100" WidthRequest="100"/>
                    </StackLayout>

                    <StackLayout HorizontalOptions="End" VerticalOptions="Center" Padding="20,0,0,0">
                        <Label Text="0h 0m 0s" x:Name="pickerValueLabel" HorizontalOptions="Start" 
                               FontSize="25"
                               TextColor="#222"
                               FontAttributes="Bold"
                               />
                        <syncfusion:SfTimePicker x:Name="timePickers"
                                 PickerMode="Dialog"
                                 Time="0:0:0"
                                 EnableLooping="True"
                                 TimeSelected="TimePicker_TimeSelected"/>

                        <buttons:SfButton
                            x:Name="pickerButton"
                            HorizontalOptions="Start" Clicked="Button_Clicked"
                            Style="{StaticResource SfButtonStyle}"
                            Text="Set value"
                            WidthRequest="120" />
                    </StackLayout>
                </StackLayout>*/
