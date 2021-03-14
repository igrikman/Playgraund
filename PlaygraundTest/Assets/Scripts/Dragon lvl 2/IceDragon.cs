using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class IceDragon : AirDragon, IAir
    {
        public new string Name { get; set; }
        public new string Leahtear { get; set; }
        public new string Fly { get; set; }
        public new string Breath { get; set; }
        public void Air()
        {
        }
        public virtual void Ice()
        {

        }
        int speed = 185;
        public IceDragon(string name, string leahtear, string fly, string breath) : base(name, leahtear, fly, breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;
        }
        public override void Info()
        {
            Debug.Log($"{Name}  Ice Dragon, speed {speed} km/h");
            Ice();
        }
    }
}

