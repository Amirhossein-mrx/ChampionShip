using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetTeamsBySpecificChampionshipQuery:Query
    {
        public int ChampionshipId { get; set; }
    }
    public class GetTeamsBySpecificChampionshipResult : ListQueryResult<GetTeamsBySpecificChampionshipModel> { }
    public class GetTeamsBySpecificChampionshipModel
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}
