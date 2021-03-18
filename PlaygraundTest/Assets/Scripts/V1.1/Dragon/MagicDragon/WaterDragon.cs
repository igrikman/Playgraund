﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;

namespace Assets.Scripts
{
    class WaterDragon : FlyDragon, IElmagic
    {
        public new string Leather { get; set; }
        public new string Tail { get; set; }
        public new string Fly { get; set; }
        public new int HP = 120;
        public override void Regeneration()
        {
            int reg = 30;
            reg += 0;
        }
        public void EasyCast(params ElementalEnum[] magic)
        {
            for (int i = 1; i < 5; i++)
            {
                if (i == 4)
                {
                    Debug.Log("Река жизни");
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

                    Debug.Log("Водопад зла");
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

                if (i == 3)
                {
                    Debug.Log("Слизневые раскаты");
                    break;
                }
                else
                {
                    Debug.Log("Кастует");
                }
            }
        }


    }
}
