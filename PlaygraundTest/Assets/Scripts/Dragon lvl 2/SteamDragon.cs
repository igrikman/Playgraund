using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class SteamDragon : WaterDragon, IFire
    {
        public new string Leahtear { get; set; }
        public new string Fly { get; set; }
        public new string Breath { get; set; }
        public new string Name { get; set; }
        public void Fire()
        {
        }
        public virtual void Steam()
        {

        }
        int speed = 170;
        public SteamDragon(string name, string leahtear, string fly, string breath) :base(name, leahtear, fly, breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;
        }
        public override void Info()
        {
            Debug.Log($"{Name}  Steam Dragon, speed {speed} km/h");
            Steam();

        }

    }
}
