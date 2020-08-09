using System;
using System.Collections.Generic;
using System.Text;

namespace KDControl
{
    public interface Entity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAT { get; set; }
        public DateTime? UpdateAT { get; set; }
    }
}

