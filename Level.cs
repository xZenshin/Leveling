using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling
{
    internal class Level
    {
        private int lvl { get; set; }
        private double progress { get; }
        private double coefficient { get; }
        private attributeType type { get; }
        public Level(double co, attributeType type) 
        {
            this.lvl = 0;
            this.progress = 0;
            this.coefficient = co;
            this.type = type;
        }


        public void increaseLevel()
        {
            if (progress <= 100.0)
            {
                lvl += 1;
            }
        }
    }


}
