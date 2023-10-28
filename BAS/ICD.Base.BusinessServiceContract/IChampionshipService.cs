using ICD.Base.Domain.Entity;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IChampionshipService
    {
        Task<InsertChampionshipResult> InsertChampionshipAsync(InsertChampionshipRequest request);
        Task <GetAllChampionshipResult> GetAllChampionshipsAsync(GetAllChampionshipQuery query);
        Task<UpdateChampionshipResult> UpdateChampionshipAsync(UpdateChampionshipRequest request);
        Task<DeleteTypeIntResult> DeleteChampionshipAsync(DeleteTypeIntRequest request);


    }
}
