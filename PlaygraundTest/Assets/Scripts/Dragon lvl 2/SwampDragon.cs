using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class SwampDragon: RockDragon, IWater
    {
        public new string Name { get; set; }
        public new string Leahtear { get; set; }
        public new string Fly { get; set; }
        public new string Breath { get; set; }
        public void Water()
        {
        }
        public virtual void Swamp()
        {

        }
        int speed = 130;
        public SwampDragon(string name, string leahtear, string fly, string breath) : base(name, leahtear, fly, breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;

        }
        public override void Info()
        {
            Debug.Log($"{Name}  Swamp Dragon, speed {speed} km/h");;
            Swamp();

        }
    }
}
