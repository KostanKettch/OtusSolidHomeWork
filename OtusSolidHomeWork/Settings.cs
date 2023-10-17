using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidHomeWork
{
    public class Settings: ISettings
    {
        public int Attempts { get; }
        public int Min { get; }
        public int Max { get; }

        public Settings(int attempts, int min, int max) {
            Attempts = attempts;
            Min = min; 
            Max = max;
        }

    }
}
