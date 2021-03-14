using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class LavaDragon: FireDragon, IRock
    {
        public new string Name { get; set; }
        public new string Leahtear { get; set; }
        public new string Fly { get; set; }
        public new string Breath { get; set; }
        public void Rock()
        {
        }
        public virtual void Lava()
        {
        }
        int speed = 130;
        public LavaDragon(string name, string leahtear, string fly, string breath) : base(name, leahtear, fly, breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;
        }
        public override void Info()
        {
            Debug.Log($"{Name}  Lava Dragon, speed {speed} km/h");
            Lava();
        }
    }
}
