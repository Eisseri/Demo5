using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotiteht3
{
    class Stuff
    {
        public string Name;

        public override string ToString()
        {
            return String.Format(Name, " " );
        }
    }
}
