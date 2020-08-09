using KDControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDControl
{
    public interface IContainerRepository: IRepository<SupervisorS>
    {
        public IEnumerable<Login> GetLogin();

    }
}
