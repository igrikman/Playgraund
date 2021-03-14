using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    interface IAir
    {
        string Name { get; set; }
        string Leahtear { get; set; }
        string Fly { get; set; }
        string Breath { get; set; }
        void Air(string air);
    }

}


