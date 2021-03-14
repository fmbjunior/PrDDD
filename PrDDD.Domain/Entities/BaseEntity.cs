using System;
using System.Collections.Generic;
using System.Text;

namespace PrDDD.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual string Id { get; set; }
    }
}
