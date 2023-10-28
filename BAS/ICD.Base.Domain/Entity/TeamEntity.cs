using System.Collections.Generic;
using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class TeamEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public int? NumberOfWin { get; set; }
        public int? NumberOfLose { get; set; }

        #region Navigation properties

        public int? CaptainId { get; set; }
        public PlayerEntity Player { get; set; }


        public int? ChampionshipId { get; set; }
        public ChampionshipEntity Championship { get; set; }


        public ICollection<PlayerEntity> Players { get; set; }
        public ICollection<MatchEntity> Matches { get; set; } //Check
        public ICollection<MatchEntity> Matches1 { get; set; } //Check

        #endregion
    }
}
    