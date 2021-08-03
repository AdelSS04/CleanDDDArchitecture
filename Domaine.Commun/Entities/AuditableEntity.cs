using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public abstract class AuditableEntity<TPrimaryKey> : Entity<TPrimaryKey>, IAuditableEntity
    {
        public DateTime? Created { get;  set; }

        public int? CreatedBy { get; set; }

        public DateTime? LastModified { get; set; } = null;

        public int? LastModifiedBy { get; set; }
       
    }
}
