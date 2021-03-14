using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class RockDragon : Snake, IRock
    {
        public string Leahtear { get; set; }
        public string Fly { get; set; }
        public string Breath { get; set; }

        public void Rock()
        {
            Debug.Log($"{Name} Rock Dragon possesses: leahtear {Leahtear}, fly {Fly}, breath {Breath}\n" +
                $"Земляной элементаль ещё больше преблизел земноводное к земле, но ее кожа стала будто {Leahtear} ");
        }
        public string Name { get; set; }
        int speed = 15;
        public RockDragon(string name, string leahtear, string fly, string breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;

        }
        public override void Info()
        {
            Debug.Log($"{Name}  Rock Dragon, speed {speed} km/h");
            Rock();


        }
    }
}
