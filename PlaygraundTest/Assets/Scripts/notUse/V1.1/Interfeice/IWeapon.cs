using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Assets.Scripts.Controller;

namespace Assets.Scripts
{
    interface IWeapon
    {
        void UseW(params Weapon[] weapon);
    }
}
