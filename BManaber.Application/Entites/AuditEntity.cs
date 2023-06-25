using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BManaber.Application.Entites
{
    public class AuditEntity<TId> : EntityBase<TId>
    {
        public int ReferenceNo { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public DateTimeOffset? LastModifiedOn { get; private set; }
        public Guid? DeletedBy { get; set; }
        public Guid? LastModifiedBy { get; private set; }
    }
}
