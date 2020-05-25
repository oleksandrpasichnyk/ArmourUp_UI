using ArmourAppUi.DataService;
using System;
using System.IO;

namespace ArmourAppUi.Data
{
    public static class AppData
    {
        public enum TypeExercises : byte { Count = 1, Approach, Time };

        public static MainTableRepository database;

        public static MainTableRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new MainTableRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "main.db"));
                }
                return database;
            }
        }

        public static MainTable[] MainTableArray = Database.GetItems();

        public static void UpdateMainTableList()
        {
            MainTableArray = Database.GetItems();
        }

        public static void MockData()
        {
            if (MainTableArray.Length != 0) return;
            for (int i = 0; i < ExercisesTest.exercisesTest.Count; i++)
            {
                DBSaverLoader.SAVE_EXERCISE(ExercisesTest.exercisesTest[i], Database);
            }
            UpdateMainTableList();
        }

        //public static int iteratorQuote = CrossSettings.Current.GetValueOrDefault("IteratorQuote", 0);
        //public static Quote CurrentQuote;
        //public static int Pivot = 20;
        //public static string UserImagePath = CrossSettings.Current.GetValueOrDefault("UserImagePath", null);
    }
}