using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotiteht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd cd = new Cd();
            Track track = new Track();
            List<string> tracks = new List<string>();
            cd.Artist = "Artisti maksaa";
            cd.Album = "Paskalevy";
            for (int i = 0;  i<3;  i++)
            {
                switch (i)
                {
                    case 0: track = new Track("Biisi1", "1:11"); break;
                    case 1: track = new Track("Biisi2", "2:22"); break;
                    case 2: track = new Track("Biisi3", "3:33"); break;

                }
                cd.AddTrack(track);
            }
            cd.PrintData();
        }
    }
}
