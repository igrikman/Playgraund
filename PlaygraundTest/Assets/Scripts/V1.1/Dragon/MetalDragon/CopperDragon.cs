using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class CopperDragon : AlumDragon, IGun
    {
        public new string Leather { get; set; }
        public new string Tail { get; set; }
        public new string Fly { get; set; }

        public new int HP = 220;
        public override void Regeneration()
        {
            int reg = 30;
            reg += 0;
        }
        public new string Sword { get; set; }
        public new string Сannon { get; set; }
        public new string Tool { get; set; }
    }
}
