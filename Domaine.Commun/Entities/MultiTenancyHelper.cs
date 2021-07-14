using Domaine.Commun.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public static class MultiTenancyHelper
    {
        public static bool IsMultiTenantEntity(object entity)
        {
            return entity is IMayHaveTenant;
        }
    }
}
