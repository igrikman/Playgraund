using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class Dragon : Lizzard
    {
        private string Leather { get; set; }
        private string Tail { get; set; }

        private int HP = 100;
        public override void Regeneration()
        {
            Debug.Log("регенерация");
        }
        public static new void Lor()
        {
            Debug.Log("Дракон");
        }
    }
}
