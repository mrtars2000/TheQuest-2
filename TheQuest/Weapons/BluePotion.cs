using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Weapons
{
    class BluePotion : Weapon, IPotion
    {
        private bool used;

        public BluePotion(Game game, Point location) : base(game, location)
        {
            used = false;
        }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used { get { return used; } set { } }

        public override void Attack(Direction direction, Random random)
        {
            used = true;

            game.IncreasePlayerHealth(5, random);
        }
    }
}
