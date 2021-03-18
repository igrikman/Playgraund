using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    abstract class FlyDragon: Dragon
    {
        public new string Leather { get; set; }
        public new string Tail { get; set; }
        public string Fly { get; set; }
        public new int HP = 120;
        public override void Regeneration()
        {
            int reg = 30;
            reg += 0;
        }

    }
}
