using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Lizzard 
    {
        private string Leather { get; set; }
        private string Tail { get; set; }

        private int HP = 15;
        public virtual void Regeneration()
        {
            Debug.Log("регенерация");
        }

        public static void Lor()
        {
            Debug.Log("Яширица");
        }
        
           
        
    }
}
