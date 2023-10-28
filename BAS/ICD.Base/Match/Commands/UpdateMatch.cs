using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class UpdateMatchRequest : Request<UpdateMatchResult>
    {
        public int Key { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
    public class UpdateMatchResult: SingleQueryResult<UpdateMatchModel>{ }

    public class UpdateMatchModel
    {

    }
}
