using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace Assets.Scripts
{
    class FireDragon : Snake, IFire
    {
        public string Leahtear { get; set; }
        public string Fly { get; set; }
        public string Breath { get; set; }
        public string Name { get; set; }
        int speed = 100;
        public FireDragon(string name, string leahtear, string fly, string breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;

        }
        public void Fire()
        {
            Debug.Log($"{Name} Fire Dragon possesses: leahtear {Leahtear}, fly {Fly}, breath {Breath} \n" +
                $" Змея столкнулась с элементалем огня, он превратил ее в пепел, а из пепла появился он {Name}, кожа его была покрыта {Leahtear},\n" +
                $"а его {Breath} дыханание сжигало все на своём пути");
        }
        public override void Info()
        {
            Debug.Log($"{Name}  Fire Dragon, speed {speed} km/h");
            Fire();


        }
    }
}
