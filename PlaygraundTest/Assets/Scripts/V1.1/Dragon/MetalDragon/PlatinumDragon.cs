using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    class PlatinumDragon : GoldDragon, IWeapon, IElmagic
    {
        private string Leather { get; set; }
        private string Tail { get; set; }
        private string Fly { get; set; }

        private int HP = 1000;

        public void EasyCast(params ElementalEnum[] magic)
        {
            Debug.Log("Выстрел из балисты");
        }
        public void MidlCast(params ElementalEnum[] magic)
        {
            Debug.Log("Требушет зла");
        }
        public void HardCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 5; i++)
            {

                if (i == 1)
                {
                    Debug.Log("Ртутные брызги"); 
                }
                if (i == 2)
                {
                    Debug.Log("Кислотные брызги");
                }
                if (i == 3)
                {
                    Debug.Log("Обращение в пыль");
                }
                if (i == 4)
                {
                    Debug.Log("Потухшая свеча");
                    break;
                }
                else if (i == 5)
                {
                    Debug.Log("Кастует");
                }
            }
        }
        public new void UseW(params Weapon[] weapon)
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
