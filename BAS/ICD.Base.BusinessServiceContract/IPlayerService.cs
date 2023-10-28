using ICD.Base.Player.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPlayerService
    {
        Task<InsertPlayerResult> InsertPlayerAsync(InsertPlayerRequest request);
        Task<GetPlayersByTeamResult> GetplayersInTeamAsync(GetPlayersByTeamQuery query);
        Task<UpdatePlayerResult> UpdatePlayerAsync(UpdatePlayerRequest request);
        Task<RemovePlayerFromTeamResult> RemovePlayerFromTeamAsync(RemovePlayerFromTeamRequest request);



    }
}
