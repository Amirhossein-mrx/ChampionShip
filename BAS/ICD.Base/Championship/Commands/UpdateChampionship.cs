using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class UpdateChampionshipRequest : Request<UpdateChampionshipResult>
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
    public class UpdateChampionshipResult:SingleQueryResult<UpdateUpdateChampionshipModel>{ }

    public class UpdateUpdateChampionshipModel
    {

    }
}
