using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public interface IEditAuditEntity
    {
        public DateTime? LastModified { get; set; }

        public int? LastModifiedBy { get; set; }
    }
}
