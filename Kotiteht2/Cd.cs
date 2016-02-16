using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotiteht2
{
    class Cd
    {
        public string Artist;
        public string Album;
        private List<Track> tracks = new List<Track>();
        public List<Track> Tracks
        {
            get { return tracks; }
        }
        // Tyhjä constructor
        public Cd()
        {
        }
        //Methodi addtrack
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }
        //Printtaus
        public void PrintData()
        {
            Console.WriteLine("Cd : " );
            Console.WriteLine("Album : " + Album);
            Console.WriteLine("Artist : " + Artist);
            Console.WriteLine("Tracklist : ");
            foreach (Track line in tracks)
            {
                Console.WriteLine("  " + line);
            }
        }
    }
}
