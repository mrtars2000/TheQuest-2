using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Weapons
{
    class RedPotion : Weapon, IPotion
    {
        public bool Used { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
