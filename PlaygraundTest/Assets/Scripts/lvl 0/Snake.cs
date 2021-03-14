using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Snake
    {
        int speed = 1;
        public virtual void Info()
        {
            Debug.Log($"Snake, speed {speed} km/h");
        }

       public static void Snakes()
        {
            Debug.Log("Змея стала причиной появления драконов. Но не только она, но и люди которые выпустили на свободу элементалей.\n" +
                "Это всё мутация и эксперементы людей. Которые начали чувствовать себя богами, но пришли они драконы плод творения человека.\n" +
                "Вирус... который развивается до сих пор...");
        }
    }

}





