using System.Threading.Tasks;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;

namespace ICD.Base.RepositoryContract;

public interface IMatchRepository : IRepository<MatchEntity, int>
{
    Task<ListQueryResult<MatchEntity>> GetAllMatchAsync(QueryDataSource<MatchEntity> queryDataSource);
    Task<ListQueryResult<MatchView>> GetTeamNameInMatchAsync(QueryDataSource<MatchView> queryDataSource);
}