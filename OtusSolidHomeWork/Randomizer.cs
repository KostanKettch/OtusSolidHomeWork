using OtusSolidHomeWork.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidHomeWork
{
    public class Randomizer : IRandomizer
    {
        private readonly Random _random = new Random();
        public int Randomize (int min, int max)
        {
            return _random.Next (min, max);
        }
    }
}
