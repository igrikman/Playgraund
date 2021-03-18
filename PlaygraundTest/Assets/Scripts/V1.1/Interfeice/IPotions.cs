using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    interface IPotions
    {
        string Health { get; set; }
        string Metophorphosis { get; set; }
        string Mutation { get; set; }
    }
}
