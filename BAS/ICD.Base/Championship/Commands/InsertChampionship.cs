using ICD.Base.Domain.Entity;
using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class InsertChampionshipRequest: Request<InsertChampionshipResult>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }

    public class InsertChampionshipResult: SingleQueryResult<InsertChampionshipModel> { }

    public class InsertChampionshipModel
    {

    }
}
