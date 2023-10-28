using System.Threading.Tasks;
using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;

namespace ICD.Base.RepositoryContract;

public interface ITeamRepository : IRepository<TeamEntity, int>
{
    Task<ListQueryResult<TeamEntity>> GetAllTeamsAsync(QueryDataSource<TeamEntity> queryDataSource);
    //Task<ListQueryResult<TeamEntity>> RemoveTeamFromChampionshipAsync(QueryDataSource<TeamEntity> queryDataSource);

}