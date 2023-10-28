using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class UpdatePlayerRequest : Request<UpdatePlayerResult>
    {
        public int Key { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public int TeamId { get; set; }
    }
    public class UpdatePlayerResult:SingleQueryResult<UpdatePlayerModel>{ }

    public class UpdatePlayerModel
    {

    }
}
