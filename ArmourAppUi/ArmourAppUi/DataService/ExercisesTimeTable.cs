using SQLite;
using System;

namespace ArmourAppUi.DataService
{
    public class ExercisesTimeTable
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

        public DateTime Data { get; set; }
        public TimeSpan Count { get; set; }
    }
}