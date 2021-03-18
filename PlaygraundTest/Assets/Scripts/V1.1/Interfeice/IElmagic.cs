using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;

namespace Assets.Scripts
{
    interface IElmagic
    {
        void EasyCast(params ElementalEnum[] magic);
        void MidlCast(params ElementalEnum[] magic);
        void HardCast(params ElementalEnum[] magic);
    }
}
