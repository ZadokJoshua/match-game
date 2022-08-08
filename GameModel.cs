using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchGame
{
    [Table("GameRecords")]
    public class GameModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double FastestTime { get; set; }
    }
}
