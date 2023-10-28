using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.View
{
    public class championshipView
    {
        public int Key { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
        public int ChampionshipId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }



    }
}
