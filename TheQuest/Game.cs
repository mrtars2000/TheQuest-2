using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheQuest.Weapons;
using TheQuest.Enemies;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon MyProperty { get; set; }

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private readonly int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundries;
        public Rectangle Boundries { get { return boundries; } }

        public Game(Rectangle boundries)
        {
            this.boundries = boundries;
            player = new Player(this, new Point(boundries.Left + 10, boundries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }
    }
}
