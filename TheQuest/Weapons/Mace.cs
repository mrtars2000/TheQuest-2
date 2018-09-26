using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Weapons
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Right, 20, 6, random);
            DamageEnemy(Direction.Up, 20, 6, random);
            DamageEnemy(Direction.Left, 20, 6, random);
            DamageEnemy(Direction.Down, 20, 6, random);
        }
    }
}
