using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class Kobold : Dragonoid, IWeapon
    {
        private string Tail { get; set; }
        private string Wool { get; set; }

        private int HP = 35;

        public void UseW(params Weapon[] weapon)
        {
            for(int i = 0; i<4; i ++)
            {
                if (i == 2)
                {
                    Debug.Log($" use {weapon[2]}");
                }
            }
        }

        public static new void Lor()
        {
            Debug.Log("Кобольд");
        }

    }
}
