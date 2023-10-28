using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using ICD.Framework.QueryDataSource.Fitlter;
using ICD.Infrastructure.Exception;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(IChampionshipService))]
    public class ChampionshipService : IChampionshipService
    {
        private readonly IUnitOfWork _db;
        private readonly IChampionshipRepository _championshipRepository;
        private readonly IMatchRepository _matchRepository;
        private readonly ITeamRepository _teamRepository;
        public ChampionshipService(IUnitOfWork db)
        {
            _db = db;
            _championshipRepository = _db.GetRepository<IChampionshipRepository>();
            _matchRepository = _db.GetRepository<IMatchRepository>();
            _teamRepository = _db.GetRepository<ITeamRepository>();
        }


        public async Task<DeleteTypeIntResult> DeleteChampionshipAsync(DeleteTypeIntRequest request)
        {


            await _matchRepository.DeleteWithAsync(x => x.ChampionshipId == request.Key);
            await _championshipRepository.DeleteWithAsync(x => x.Key == request.Key);

            var teams = await _teamRepository.FindAsync(x => x.ChampionshipId == request.Key);
            foreach (var item in teams)
            {
                item.ChampionshipId = null;
                _teamRepository.Update(item);
            }


            await _db.SaveChangesAsync();


            return new DeleteTypeIntResult { Success = true };
        }


        public async Task<GetAllChampionshipResult> GetAllChampionshipsAsync(GetAllChampionshipQuery query)
        {


            QueryDataSource<ChampionshipEntity> queryDataSource = query.ToQueryDataSource<ChampionshipEntity>();
            ListQueryResult<ChampionshipEntity> result = await _championshipRepository.GetAllChampionshipsAsync(queryDataSource);

            var finalResult = result.MapTo<GetAllChampionshipResult>();

            return finalResult;
        }


        public async Task<InsertChampionshipResult> InsertChampionshipAsync(InsertChampionshipRequest request)
        {
            var championship = request.MapTo<ChampionshipEntity>();

            await _championshipRepository.AddAsync(championship);
            await _db.SaveChangesAsync();
            return new InsertChampionshipResult { Success = true };
        }

        public async Task<UpdateChampionshipResult> UpdateChampionshipAsync(UpdateChampionshipRequest request)
        {
            var champioship = await _championshipRepository.FirstOrDefaultAsync(x => x.Key == request.Key);

            if (champioship.IsNull())
            {
                throw new ICDException("Not Found");
            }

            champioship = request.MapTo<ChampionshipEntity>();
            _championshipRepository.Update(champioship);
            _db.SaveChanges();

            return new UpdateChampionshipResult() { Success = true };

        }
    }
}
