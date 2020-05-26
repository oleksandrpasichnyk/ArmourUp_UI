using SQLite;

namespace ArmourAppUi.DataService
{
    public class MainTable
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string StringID { get; set; }
        public byte Type { get; set; }
        public string Purpose { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public int Progress { get; set; }
    }
}