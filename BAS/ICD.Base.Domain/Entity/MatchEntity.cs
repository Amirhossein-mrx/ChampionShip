using System;
using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class MatchEntity : BaseEntity<int>
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }

        #region Navigation properties

        public int HomeTeamId { get; set; }
        public TeamEntity HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public TeamEntity AwayTeam { get; set; }

        public int ChampionshipId { get; set; }
        public ChampionshipEntity Championship { get; set; }

        #endregion
    }
}
    