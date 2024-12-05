using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public void Update(BaseEntity entity)
        {
            foreach (PropertyInfo property in entity.GetType().GetProperties())
            {
                if (property.GetValue(entity) != null && property.CanWrite && property.Name != nameof(Id) && property.Name != nameof(DateCreated))
                {
                    property.SetValue(this, property.GetValue(entity));
                }
            }
            this.DateUpdated = entity.DateUpdated;
        }

        public void Delete()
        {
            this.DateDeleted = DateTimeOffset.Now;
        }
    }
}
