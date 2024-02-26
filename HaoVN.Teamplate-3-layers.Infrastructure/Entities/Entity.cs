using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Entities
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString("N");
            CreatedTime = LastUpdatedTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }

    }
}
