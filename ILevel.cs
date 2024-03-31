using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling
{
    interface ILevel
    {
        int lvl { get; set; }
        double coefficient { get; set; }
        attributeType type { get; set; }

        void levelUp();
        void increaseProgress();

    }
}
