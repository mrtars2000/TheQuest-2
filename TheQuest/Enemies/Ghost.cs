using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Enemies
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                if (random.Next(3) == 1) //stays still otherwise (1/3 that will move towards player)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
