using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidHomeWork
{
    public interface ISettings
    {
        int Attempts { get; }
        int Min { get; }
        int Max { get; }
    }
}
