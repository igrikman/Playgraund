using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Human
    {
        public string Leather { get; set; }

        public int HP = 40;

        public string Sword { get; set; }
        public string Health { get; set; }
        public string Metophorphosis { get; set; }
        public string Mutation { get; set; }
    }
}
