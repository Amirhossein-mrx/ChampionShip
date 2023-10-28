using ICD.Base.Domain.Entity;
using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class InsertTeamRequest : Request<InsertTeamResult>
    {
        public string Name { get; set; }
        public int NumberOfWin { get; set; }
        public int NumberOfLose { get; set; }
        //public int? CaptainId { get; set; }
        public int ChampionshipId { get; set; }


    }
    public class InsertTeamResult : SingleQueryResult<InsertTeamModel> { }
    public class InsertTeamModel
    {

    }
}
