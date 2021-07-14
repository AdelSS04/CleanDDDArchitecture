using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public interface ICreatedAuditEntity
    {
        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

    }
}
