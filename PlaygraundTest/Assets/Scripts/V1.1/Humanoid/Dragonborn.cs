using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class Dragonborn : Dragonoid, IElmagic, IWeapon
    {
        private string Leather { get; set; }

        private string Tail { get; set; }

        private int HP = 55;

        public void EasyCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 4; i++)
            {
                if (i == 1)
                {
                    Debug.Log($"{magic[1]}");
                }
            }
        }
        public void MidlCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 4; i++)
            {
                if (i == 4)
                {
                    Debug.Log($"{magic[4]}");
                }
            }
        }
        public void HardCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 4; i++)
            {
                if (i == 3)
                {
                    Debug.Log($"{magic[3]}");
                }
                else if (i == 2)
                {
                    Debug.Log($"{magic[2]}");
                }
            }
        }
        public void UseW(params Weapon[] weapon)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Debug.Log($" use {weapon[0]}");
                }
            }
        }


    }
}
