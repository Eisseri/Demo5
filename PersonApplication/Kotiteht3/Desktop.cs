using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotiteht3
{
    class Desktop
    {
        public string Artist;
        private List<Stuff> stuff = new Stuff<stuff>();
        public List<Stuff> Stuffs
        {
            get { return stuffs; }
        }
        // Tyhjä constructor
        public Desktop()
        {
        }
        //Methodi addtrack
        public void AddSTuff(Stuff stuff)
        {
            stuffs.Add(stuff);
        }
        //Printtaus
        public void PrintData()
        {
            Console.WriteLine("Desktop : ");
            Console.WriteLine("Stufflist : ");
            foreach (Stuff line in stuffs)
            {
                Console.WriteLine("  " + line);
            }
        }
    }
}
