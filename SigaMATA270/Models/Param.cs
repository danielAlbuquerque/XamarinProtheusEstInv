using SQLite;

namespace SigaMATA270.Models
{
    public class Param
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
}
