using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION
{
    public class STUDENT 
    {
        private Home _home;
        public STUDENT(Home home) 
        {
            _home = home;
            _home.showName();
        }
    }
}
