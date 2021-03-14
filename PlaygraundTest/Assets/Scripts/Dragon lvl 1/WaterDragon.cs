using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class WaterDragon : Snake, IWater
    {
        public string Leahtear { get; set; }
        public string Fly { get; set; }
        public string Breath { get; set; }
        public string Name { get; set; }
        public void Water()
        {
            Debug.Log($"{Name} Water Dragon possesses: leahtear {Leahtear}, fly {Fly}, breath {Breath}\n" +
                $" Амфибия будет завидовать {Name}. Она как могла летать так и проплывать километры за считаные минуты\n" +
                $" А ее {Breath} уничтожало поселения.");
        } 
        int speed = 25;
        public WaterDragon(string name, string leahtear, string fly, string breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;

        }

        public override void Info()
        {
            Debug.Log($"{Name}  Water Dragon, speed {speed} km/h");
            Water();


        }
    }
}
