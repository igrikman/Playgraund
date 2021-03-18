using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Dragonoid : Human 
    {
        public new string Leather { get; set; }

        public string Tail { get; set; }

        public new int HP = 55;
        public virtual void Regeneration()
        {
            int reg = 10;
            reg += 0;
        }
        public new string Health { get; set; }
        public new string Metophorphosis { get; set; }
        public new string Mutation { get; set; }
        public new string Sword { get; set; }
        public string Сannon { get; set; }
        public string Tool { get; set; }
    }
}
