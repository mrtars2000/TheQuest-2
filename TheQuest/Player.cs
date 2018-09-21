using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheQuest.Weapons;

namespace TheQuest
{
    class Player : Mover
    {
        public int HitPoints { get; private set; }
        public Point Location { get; internal set; }

        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name); //add weapon prop
                return names;
            }
        }

        //public Player(Game game, Point location)
    }
}
