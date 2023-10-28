using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Framework.Model;

namespace ICD.Base.Match.Queries
{
    public class GetUpComingMatchinChampionshipQuery : Query
    {
        public int Key { get; set; }
    }
    public class GetUpComingMatchinChampionshipResult:ListQueryResult<GetUpComingMatchinChampionshipModel>{}

    public class GetUpComingMatchinChampionshipModel
    {
        public int Key { get; set; }
        //public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }

        //public ICollection<GetUpComingMatchinChampionshipDetail> Details { get; set; }
    }

    //public class GetUpComingMatchinChampionshipDetail
    //{
    //    public int Key { get; set; }
    //    public DateTime Date { get; set; }
    //    public string Location { get; set; }
    //    public int HomeTeamId { get; set; }
    //    public int AwayTeamId { get; set; }
    //}



}

