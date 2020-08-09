using KDControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KDControl
{
    public class ContainerRepository : SQLRepository<SupervisorS>, IContainerRepository
    {
        public ContainerRepository(AppDbContex context) : base(context) { }

        public IEnumerable<Login> GetLogin()
        {
            return context.Set<Login>().AsEnumerable();
        }
    }
}
