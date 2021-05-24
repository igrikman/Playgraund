using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class AlumDragon:FlyDragon, IWeapon
    {
        private  string Leather { get; set; }
        private  string Tail { get; set; }
        private  string Fly { get; set; }

        private  int HP = 220;

        public void UseW(params Weapon[] weapon)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                {
                    Debug.Log($" use {weapon[1]}");
                }
            }
        }
     
    }
}
