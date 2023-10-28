using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Player.Commands
{
    public class RemovePlayerFromTeamRequest : Request<RemovePlayerFromTeamResult>
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
    }
    public class RemovePlayerFromTeamResult:SingleQueryResult<RemovePlayerFromTeamModel>{}

    public class RemovePlayerFromTeamModel
    {

    }
}
