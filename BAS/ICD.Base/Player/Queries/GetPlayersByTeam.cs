using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetPlayersByTeamQuery : Query
    {
        public int TeamId { get; set; }
    }
    public class GetPlayersByTeamResult:ListQueryResult<GetPlayersByTeamModel>{}

    public class GetPlayersByTeamModel
    {
        public int Key { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    }
}
