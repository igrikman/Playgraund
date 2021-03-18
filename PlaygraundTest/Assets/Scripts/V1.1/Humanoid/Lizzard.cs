using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Lizzard 
    {
        public string Leather { get; set; }
        public string Tail { get; set; }

        public int HP = 15;
        public virtual void Regeneration()
        { 
            int reg = 5;
            reg += 0; ;
        }
    }
}
