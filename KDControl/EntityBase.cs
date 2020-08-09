using System;

namespace KDControl
{
    public class EntityBase : Entity
    {
        public int Id { get; set; }
        public DateTime CreateAT { get; set; } = DateTime.Now;
        public DateTime? UpdateAT { get; set; }
        public bool Status { get; set; } = true;
    }
}
