using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;

namespace ICD.Base.Repository
{
    [Dependency(typeof(IChampionshipRepository))]
    public class ChampionshipRepository : BaseRepository<ChampionshipEntity, int>, IChampionshipRepository
    {
        public async Task<ListQueryResult<ChampionshipEntity>> GetAllChampionshipsAsync(QueryDataSource<ChampionshipEntity> queryDataSource)
        {
            var Result = new ListQueryResult<ChampionshipEntity>
            {
                Entities = new List<ChampionshipEntity>()
            };

            var queryResult = from pt in GenericRepository.Query<ChampionshipEntity>()
                select pt;

            Result = await queryResult.ToListQueryResultAsync(queryDataSource);
            return Result;
        }
    }
}
