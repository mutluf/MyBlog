using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }= Guid.NewGuid();
        public virtual string CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual bool isDeleted { get; set; } =false;
    }
}
