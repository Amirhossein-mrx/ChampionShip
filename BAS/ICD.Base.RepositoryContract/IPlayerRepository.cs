using System.Threading.Tasks;
using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;

namespace ICD.Base.RepositoryContract;

public interface IPlayerRepository : IRepository<PlayerEntity, int>
{
    Task<ListQueryResult<PlayerEntity>> GetAllPlayersAsync(QueryDataSource<PlayerEntity> queryDataSource);
}