using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;

namespace Assets.Scripts
{
    class AirDragon : FlyDragon, IElmagic
    {

        private string Leather { get; set; }
        private string Tail { get; set; }
        private string Fly { get; set; }
        private int HP = 120;
        public override void Regeneration()
        {
            Debug.Log("регенерация");
        }
        public void EasyCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 5; i++)
            {
                if (i == 4)
                {
                    Debug.Log("Воздушная струя");
                }
                else
                {
                    Debug.Log("Кастует");
                }
            }
        }
        public void MidlCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 4; i++)
            {

                if (i == 1)
                {

                    Debug.Log("Дождь");
                    break;
                }
                else
                {
                    Debug.Log("Кастует");
                }
            }
        }
        public void HardCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 4; i++)
            {

                if (i == 2)
                {
                    Debug.Log("Раскалённый воздух");
                    break;
                }
                else
                {
                    Debug.Log("Кастует");
                }
            }
        }

        public static new void Lor()
        {
            Debug.Log("Дракон воздух");
        }

    }
}
