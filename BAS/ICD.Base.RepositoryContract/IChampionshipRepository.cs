using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;

namespace ICD.Base.RepositoryContract
{
    public interface IChampionshipRepository:IRepository<ChampionshipEntity, int>
    {
        Task<ListQueryResult<ChampionshipEntity>> GetAllChampionshipsAsync(QueryDataSource<ChampionshipEntity> queryDataSource);
    }
}
