using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class InsertMatchRequest : Request<InsertMatchResult>
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int ChampionshipId { get; set; }
    }
    public class InsertMatchResult:SingleQueryResult<InsertMatchModel>{ }

    public class InsertMatchModel
    {

    }
}
