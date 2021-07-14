using Domaine.Commun.Entities.Interfaces;
using Domaine.Commun.Timing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public static class AuditableEntityHelper
    {
        public static void SetCreationAuditProperties(object entityAsObj,int? userId,int? TenantId)
        {
            if(entityAsObj is ICreatedAuditEntity)
            {
                var Entity = entityAsObj as ICreatedAuditEntity;
                Entity.Created = Clock.Now;
                Entity.CreatedBy = userId;
            }
            if(MultiTenancyHelper.IsMultiTenantEntity(entityAsObj))
            {
                var Entity = entityAsObj as IMayHaveTenant;
                Entity.TenantId = TenantId;
            }

        }

        public static void SetModificationAuditProperties(object entityAsObj, int userId)
        {
            if (entityAsObj is IEditAuditEntity)
            {
                var Entity = entityAsObj as IEditAuditEntity;
                Entity.LastModified = Clock.Now;
                Entity.LastModifiedBy = userId;
            }
        }

    }
}
