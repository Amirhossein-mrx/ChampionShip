using System;
using System.Collections.Generic;
using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class PlayerEntity : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }

        #region Navigation properties

        public int? TeamId { get; set; }
        public TeamEntity Team { get; set; }

        public ICollection<TeamEntity> Teams { get; set; }

        #endregion
    }
}
    