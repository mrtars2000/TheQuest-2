﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest.Enemies
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            if(HitPoints > 0)
            {
                Direction directionToMove;
                if (random.Next(1) == 1)
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                else
                    directionToMove = (Direction)random.Next(4);
                Move(directionToMove, game.Boundries);
                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}
