using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class ChampionshipEntity:BaseEntity<int>
    {
        public string Name  { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        #region Navigation properties

        public ICollection<MatchEntity> Matches { get; set; }
        public ICollection<TeamEntity> Teams { get; set; }

        #endregion

    }
}
    