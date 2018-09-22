﻿using System;
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
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

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

        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if(Nearby(game.WeaponInRoom.Location, 1))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    if(!(Weapons.Contains("Sword") || !Weapons.Contains("Bow") || !Weapons.Contains("Mace")))
                    {
                        Equip(game.WeaponInRoom.Name);
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null)
                return;
            else
            {
                equippedWeapon.Attack();
                if (equippedWeapon is IPotion)
                    inventory.Remove(equippedWeapon);
            }
        }
    }
}
