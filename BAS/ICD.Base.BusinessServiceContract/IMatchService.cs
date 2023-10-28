using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Base.Match.Queries;

namespace ICD.Base.BusinessServiceContract
{
    public interface IMatchService
    {
        Task<InsertMatchResult> InsertMatchAsync(InsertMatchRequest request);
        Task<UpdateMatchResult> UpdateMatchAsync(UpdateMatchRequest request);
        Task<GetUpComingMatchinChampionshipResult> GetUpcomingMatchesinChampionship(GetUpComingMatchinChampionshipQuery query);



    }
}
