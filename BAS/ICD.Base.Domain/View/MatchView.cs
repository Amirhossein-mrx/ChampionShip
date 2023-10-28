using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.View
{
    public class MatchView
    {
        public int Key { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
    }
}
