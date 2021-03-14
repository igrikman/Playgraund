using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class AirDragon : Snake, IAir
    {
        public string Name { get; set; }
        public string Leahtear { get; set; }
        public string Fly { get; set; }
        public string Breath { get; set; }

        int speed = 40;
        public AirDragon(string name, string leahtear, string fly, string breath)
        {
            Name = name;
            Leahtear = leahtear;
            Fly = fly;
            Breath = breath;

        }
        public override void Info()
        {
            Debug.Log($"{Name}  Air Dragon, speed {speed} km/h");
            Air("air");


        }

        public void Air(string air)
        {
            Debug.Log($"{Name} Air Dragon possesses: leahtear {Leahtear}, fly {Fly}, breath {Breath}\n" +
                $"Когда змея столкнулась с элементалем воздуха, она взмыла в воздух, её полёт был быстор,\n" +
                $" а кожа стала грубее за счёт потока воздуха который рассекал ее плоть,\n" +
                $"{Breath} рассекал воздух и всё живое вокруг ");
        }
    }
}
