using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class Dragon : Dragonoid
    {
        public new string Leather { get; set; }
        public new string Tail { get; set; }
        public new int HP = 100;
        public override void Regeneration()
        {
            int reg = 25;
            reg += 0;
        }

    }
}
