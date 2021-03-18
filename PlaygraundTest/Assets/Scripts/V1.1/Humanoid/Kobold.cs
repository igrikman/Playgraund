using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    abstract class Kobold : Human
    {
        public string Tail { get; set; }
        public string Wool { get; set; }

        public new int HP = 35;
        public new string Sword { get; set; }
        public string Сannon { get; set; }
        public string Tool { get; set; }
    }
}
