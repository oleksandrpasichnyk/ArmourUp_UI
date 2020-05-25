using SQLite;
using System;

namespace ArmourAppUi.DataService
{
    public class ExercisesCountTable
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

        public DateTime Data { get; set; }
        public int Count { get; set; }
    }
}