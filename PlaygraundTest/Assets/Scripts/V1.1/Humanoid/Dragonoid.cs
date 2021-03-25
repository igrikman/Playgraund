using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;
namespace Assets.Scripts
{
    abstract class Dragonoid: Dragon
    {
        private string Leather { get; set; }

        private string Tail { get; set; }

        private int HP = 55;
        public override void Regeneration()
        {
            Debug.Log("регенерация");
        }




    }
}
