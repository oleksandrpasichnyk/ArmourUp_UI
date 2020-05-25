using SQLite;
using System;

namespace ArmourAppUi.DataService
{
    public class ExercisesApproachTable
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

        public DateTime Data { get; set; }
        public string Count { get; set; }
    }
}