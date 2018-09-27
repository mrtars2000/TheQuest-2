using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheQuest.Enemies;
using TheQuest.Weapons;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 480, 195));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void swordInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                swordInventory.BorderStyle = BorderStyle.FixedSingle;
                bowInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void maceInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                swordInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.FixedSingle;
                UpdateScroll();
            }
        }

        private void bowInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                swordInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.FixedSingle;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void redPotionInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                swordInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.None;
                redPotionInventory.BorderStyle = BorderStyle.FixedSingle;
                maceInventory.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void bluePotionInventory_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                swordInventory.BorderStyle = BorderStyle.None;
                bowInventory.BorderStyle = BorderStyle.None;
                bluePotionInventory.BorderStyle = BorderStyle.FixedSingle;
                redPotionInventory.BorderStyle = BorderStyle.None;
                maceInventory.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void LeftArrowMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void UpArrowMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void RightArrowMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void DownArrowMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        public void UpdateScroll()
        {
            if(bluePotionInventory.BorderStyle.Equals(BorderStyle.FixedSingle) || redPotionInventory.BorderStyle.Equals(BorderStyle.FixedSingle))
            {
                AttackDownArrow.Visible = false;
                AttackLeftArrow.Visible = false;
                AttackRightArrow.Visible = false;
                AttackUpArrow.Text = "Drink";
            }
            else
            {
                AttackDownArrow.Visible = true;
                AttackLeftArrow.Visible = true;
                AttackRightArrow.Visible = true;
                AttackUpArrow.Text = "↑";
            }
        }

        private void AttackUpArrow_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackRightArrow_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();

        }

        private void AttackDownArrow_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();

        }

        private void AttackLeftArrow_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();

        }

        private void UpdateCharacters()
        {
            playerImg.Location = game.PlayerLocation;
            labelPlayerHP.Text = game.PlayerHitPoints.ToString();
            //Enemies
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    batField.Location = enemy.Location;
                    labelBatHP.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostField.Location = enemy.Location;
                    labelGhostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulField.Location = enemy.Location;
                    labelGhoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                batField.Visible = false;
                labelBatHP.Text = "";
            }
            else
                batField.Visible = true;
            if (!showGhost)
            {
                ghostField.Visible = false;
                labelGhostHP.Text = "";
            }
            else
                ghostField.Visible = true;
            if (!showGhoul)
            {
                ghoulField.Visible = false;
                labelGhoulHP.Text = "";
            }
            else
                ghoulField.Visible = true;

            //Weapons
            swordField.Visible = false;
            bowField.Visible = false;
            redPotionField.Visible = false;
            bluePotionField.Visible = false;
            maceField.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordField; break;
                case "Bow":
                    weaponControl = bowField; break;
                case "Red Potion":
                    weaponControl = redPotionField; break;
                case "Blue Potion":
                    weaponControl = bluePotionField; break;
                case "Mace":
                    weaponControl = maceField; break;
                default:
                    break;
            }
            weaponControl.Visible = true;
            //Inventory
            swordInventory.Visible = false;
            bowInventory.Visible = false;
            maceInventory.Visible = false;
            redPotionInventory.Visible = false;
            bluePotionInventory.Visible = false;
            if (game.CheckPlayerInventory("Sword"))
                swordInventory.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                bowInventory.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                maceInventory.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                redPotionInventory.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                bluePotionInventory.Visible = true;
            //Check if weapon was picked up
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            //Check if player died
            if(game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if( enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
    }  
}
