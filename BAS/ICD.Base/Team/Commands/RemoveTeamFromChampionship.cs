using ICD.Framework.Model;
using Serilog.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class RemoveTeamFromChampionshipRequest: Request<RemoveTeamFromChampionshipResult>
    {
        public int ChampionShipId { get; set; }
        public int TeamId { get; set; }

    }
    public class RemoveTeamFromChampionshipResult: SingleQueryResult<RemoveTeamFromChampionshipModel> { }

    public class RemoveTeamFromChampionshipModel
    {
    }


}
