using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotiteht2
{
    class Track
    {
            public string Title;
            public string Length;
            public Track()
            {

            }
            public Track(string title, string length)
            {
                Title = title;
                Length = length;
            }
            public override string ToString()
            {
                return String.Format(Title, " ", Length);
            }
    }
}

