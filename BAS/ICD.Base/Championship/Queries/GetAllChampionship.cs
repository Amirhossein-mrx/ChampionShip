using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetAllChampionshipQuery : Query
    {
    }
    public class GetAllChampionshipResult: ListQueryResult<GetAllChampionshipModel>{ }

    public class GetAllChampionshipModel
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
