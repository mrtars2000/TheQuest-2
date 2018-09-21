using System.Drawing;

namespace TheQuest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.swordField = new System.Windows.Forms.PictureBox();
            this.maceField = new System.Windows.Forms.PictureBox();
            this.bowField = new System.Windows.Forms.PictureBox();
            this.ghostField = new System.Windows.Forms.PictureBox();
            this.batField = new System.Windows.Forms.PictureBox();
            this.bluePotionField = new System.Windows.Forms.PictureBox();
            this.redPotionField = new System.Windows.Forms.PictureBox();
            this.ghoulField = new System.Windows.Forms.PictureBox();
            this.playerImg = new System.Windows.Forms.PictureBox();
            this.swordInventory = new System.Windows.Forms.PictureBox();
            this.maceInventory = new System.Windows.Forms.PictureBox();
            this.bowInventory = new System.Windows.Forms.PictureBox();
            this.redPotionInventory = new System.Windows.Forms.PictureBox();
            this.bluePotionInventory = new System.Windows.Forms.PictureBox();
            this.moveGroupBox = new System.Windows.Forms.GroupBox();
            this.attackGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPlayerHP = new System.Windows.Forms.Label();
            this.labelBatHP = new System.Windows.Forms.Label();
            this.labelGhostHP = new System.Windows.Forms.Label();
            this.labelGhoulHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.swordField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // swordField
            // 
            this.swordField.BackColor = System.Drawing.Color.Transparent;
            this.swordField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swordField.Image = ((System.Drawing.Image)(resources.GetObject("swordField.Image")));
            this.swordField.InitialImage = null;
            this.swordField.Location = new System.Drawing.Point(106, 82);
            this.swordField.Name = "swordField";
            this.swordField.Size = new System.Drawing.Size(30, 30);
            this.swordField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordField.TabIndex = 0;
            this.swordField.TabStop = false;
            this.swordField.Visible = false;
            // 
            // maceField
            // 
            this.maceField.BackColor = System.Drawing.Color.Transparent;
            this.maceField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maceField.Image = ((System.Drawing.Image)(resources.GetObject("maceField.Image")));
            this.maceField.InitialImage = null;
            this.maceField.Location = new System.Drawing.Point(70, 82);
            this.maceField.Name = "maceField";
            this.maceField.Size = new System.Drawing.Size(30, 30);
            this.maceField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceField.TabIndex = 1;
            this.maceField.TabStop = false;
            this.maceField.Visible = false;
            // 
            // bowField
            // 
            this.bowField.BackColor = System.Drawing.Color.Transparent;
            this.bowField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bowField.Image = ((System.Drawing.Image)(resources.GetObject("bowField.Image")));
            this.bowField.Location = new System.Drawing.Point(143, 82);
            this.bowField.Name = "bowField";
            this.bowField.Size = new System.Drawing.Size(30, 30);
            this.bowField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowField.TabIndex = 2;
            this.bowField.TabStop = false;
            this.bowField.Visible = false;
            // 
            // ghostField
            // 
            this.ghostField.BackColor = System.Drawing.Color.Transparent;
            this.ghostField.Image = ((System.Drawing.Image)(resources.GetObject("ghostField.Image")));
            this.ghostField.Location = new System.Drawing.Point(287, 82);
            this.ghostField.Name = "ghostField";
            this.ghostField.Size = new System.Drawing.Size(30, 30);
            this.ghostField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghostField.TabIndex = 3;
            this.ghostField.TabStop = false;
            this.ghostField.Visible = false;
            // 
            // batField
            // 
            this.batField.BackColor = System.Drawing.Color.Transparent;
            this.batField.Image = ((System.Drawing.Image)(resources.GetObject("batField.Image")));
            this.batField.Location = new System.Drawing.Point(251, 82);
            this.batField.Name = "batField";
            this.batField.Size = new System.Drawing.Size(30, 30);
            this.batField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batField.TabIndex = 4;
            this.batField.TabStop = false;
            this.batField.Visible = false;
            // 
            // bluePotionField
            // 
            this.bluePotionField.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionField.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionField.Image")));
            this.bluePotionField.Location = new System.Drawing.Point(215, 82);
            this.bluePotionField.Name = "bluePotionField";
            this.bluePotionField.Size = new System.Drawing.Size(30, 30);
            this.bluePotionField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotionField.TabIndex = 5;
            this.bluePotionField.TabStop = false;
            this.bluePotionField.Visible = false;
            // 
            // redPotionField
            // 
            this.redPotionField.BackColor = System.Drawing.Color.Transparent;
            this.redPotionField.Image = ((System.Drawing.Image)(resources.GetObject("redPotionField.Image")));
            this.redPotionField.Location = new System.Drawing.Point(179, 82);
            this.redPotionField.Name = "redPotionField";
            this.redPotionField.Size = new System.Drawing.Size(30, 30);
            this.redPotionField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotionField.TabIndex = 6;
            this.redPotionField.TabStop = false;
            this.redPotionField.Visible = false;
            // 
            // ghoulField
            // 
            this.ghoulField.BackColor = System.Drawing.Color.Transparent;
            this.ghoulField.Image = ((System.Drawing.Image)(resources.GetObject("ghoulField.Image")));
            this.ghoulField.Location = new System.Drawing.Point(323, 82);
            this.ghoulField.Name = "ghoulField";
            this.ghoulField.Size = new System.Drawing.Size(30, 30);
            this.ghoulField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoulField.TabIndex = 7;
            this.ghoulField.TabStop = false;
            this.ghoulField.Visible = false;
            // 
            // playerImg
            // 
            this.playerImg.BackColor = System.Drawing.Color.Transparent;
            this.playerImg.Image = ((System.Drawing.Image)(resources.GetObject("playerImg.Image")));
            this.playerImg.Location = new System.Drawing.Point(359, 82);
            this.playerImg.Name = "playerImg";
            this.playerImg.Size = new System.Drawing.Size(30, 30);
            this.playerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImg.TabIndex = 8;
            this.playerImg.TabStop = false;
            this.playerImg.Visible = false;
            // 
            // swordInventory
            // 
            this.swordInventory.BackColor = System.Drawing.Color.Transparent;
            this.swordInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swordInventory.Image = ((System.Drawing.Image)(resources.GetObject("swordInventory.Image")));
            this.swordInventory.InitialImage = null;
            this.swordInventory.Location = new System.Drawing.Point(86, 370);
            this.swordInventory.Name = "swordInventory";
            this.swordInventory.Size = new System.Drawing.Size(50, 50);
            this.swordInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordInventory.TabIndex = 9;
            this.swordInventory.TabStop = false;
            this.swordInventory.Visible = false;
            // 
            // maceInventory
            // 
            this.maceInventory.BackColor = System.Drawing.Color.Transparent;
            this.maceInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maceInventory.Image = ((System.Drawing.Image)(resources.GetObject("maceInventory.Image")));
            this.maceInventory.InitialImage = null;
            this.maceInventory.Location = new System.Drawing.Point(143, 370);
            this.maceInventory.Name = "maceInventory";
            this.maceInventory.Size = new System.Drawing.Size(50, 50);
            this.maceInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceInventory.TabIndex = 10;
            this.maceInventory.TabStop = false;
            this.maceInventory.Visible = false;
            // 
            // bowInventory
            // 
            this.bowInventory.BackColor = System.Drawing.Color.Transparent;
            this.bowInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bowInventory.Image = ((System.Drawing.Image)(resources.GetObject("bowInventory.Image")));
            this.bowInventory.Location = new System.Drawing.Point(199, 370);
            this.bowInventory.Name = "bowInventory";
            this.bowInventory.Size = new System.Drawing.Size(50, 50);
            this.bowInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowInventory.TabIndex = 11;
            this.bowInventory.TabStop = false;
            this.bowInventory.Visible = false;
            // 
            // redPotionInventory
            // 
            this.redPotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.redPotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("redPotionInventory.Image")));
            this.redPotionInventory.Location = new System.Drawing.Point(255, 370);
            this.redPotionInventory.Name = "redPotionInventory";
            this.redPotionInventory.Size = new System.Drawing.Size(50, 50);
            this.redPotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotionInventory.TabIndex = 12;
            this.redPotionInventory.TabStop = false;
            this.redPotionInventory.Visible = false;
            // 
            // bluePotionInventory
            // 
            this.bluePotionInventory.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionInventory.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionInventory.Image")));
            this.bluePotionInventory.Location = new System.Drawing.Point(311, 370);
            this.bluePotionInventory.Name = "bluePotionInventory";
            this.bluePotionInventory.Size = new System.Drawing.Size(50, 50);
            this.bluePotionInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotionInventory.TabIndex = 13;
            this.bluePotionInventory.TabStop = false;
            this.bluePotionInventory.Visible = false;
            // 
            // moveGroupBox
            // 
            this.moveGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.moveGroupBox.Location = new System.Drawing.Point(367, 360);
            this.moveGroupBox.Name = "moveGroupBox";
            this.moveGroupBox.Size = new System.Drawing.Size(85, 60);
            this.moveGroupBox.TabIndex = 14;
            this.moveGroupBox.TabStop = false;
            this.moveGroupBox.Text = "Move";
            // 
            // attackGroupBox
            // 
            this.attackGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.attackGroupBox.Location = new System.Drawing.Point(476, 360);
            this.attackGroupBox.Name = "attackGroupBox";
            this.attackGroupBox.Size = new System.Drawing.Size(85, 60);
            this.attackGroupBox.TabIndex = 15;
            this.attackGroupBox.TabStop = false;
            this.attackGroupBox.Text = "Attack";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayerHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBatHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGhostHP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGhoulHP, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(269, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 71);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // labelPlayerHP
            // 
            this.labelPlayerHP.AutoSize = true;
            this.labelPlayerHP.Location = new System.Drawing.Point(85, 0);
            this.labelPlayerHP.Name = "labelPlayerHP";
            this.labelPlayerHP.Size = new System.Drawing.Size(49, 13);
            this.labelPlayerHP.TabIndex = 4;
            this.labelPlayerHP.Text = "playerHp";
            // 
            // labelBatHP
            // 
            this.labelBatHP.AutoSize = true;
            this.labelBatHP.Location = new System.Drawing.Point(85, 17);
            this.labelBatHP.Name = "labelBatHP";
            this.labelBatHP.Size = new System.Drawing.Size(36, 13);
            this.labelBatHP.TabIndex = 5;
            this.labelBatHP.Text = "batHp";
            // 
            // labelGhostHP
            // 
            this.labelGhostHP.AutoSize = true;
            this.labelGhostHP.Location = new System.Drawing.Point(85, 34);
            this.labelGhostHP.Name = "labelGhostHP";
            this.labelGhostHP.Size = new System.Drawing.Size(47, 13);
            this.labelGhostHP.TabIndex = 6;
            this.labelGhostHP.Text = "ghostHp";
            // 
            // labelGhoulHP
            // 
            this.labelGhoulHP.AutoSize = true;
            this.labelGhoulHP.Location = new System.Drawing.Point(85, 51);
            this.labelGhoulHP.Name = "labelGhoulHP";
            this.labelGhoulHP.Size = new System.Drawing.Size(47, 13);
            this.labelGhoulHP.TabIndex = 7;
            this.labelGhoulHP.Text = "ghoulHp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attackGroupBox);
            this.Controls.Add(this.moveGroupBox);
            this.Controls.Add(this.bluePotionInventory);
            this.Controls.Add(this.redPotionInventory);
            this.Controls.Add(this.bowInventory);
            this.Controls.Add(this.maceInventory);
            this.Controls.Add(this.swordInventory);
            this.Controls.Add(this.playerImg);
            this.Controls.Add(this.ghoulField);
            this.Controls.Add(this.batField);
            this.Controls.Add(this.ghostField);
            this.Controls.Add(this.redPotionField);
            this.Controls.Add(this.bluePotionField);
            this.Controls.Add(this.bowField);
            this.Controls.Add(this.swordField);
            this.Controls.Add(this.maceField);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.swordField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionInventory)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox swordField;
        private System.Windows.Forms.PictureBox maceField;
        private System.Windows.Forms.PictureBox bowField;
        private System.Windows.Forms.PictureBox ghostField;
        private System.Windows.Forms.PictureBox batField;
        private System.Windows.Forms.PictureBox bluePotionField;
        private System.Windows.Forms.PictureBox redPotionField;
        private System.Windows.Forms.PictureBox ghoulField;
        private System.Windows.Forms.PictureBox playerImg;
        private System.Windows.Forms.PictureBox swordInventory;
        private System.Windows.Forms.PictureBox maceInventory;
        private System.Windows.Forms.PictureBox bowInventory;
        private System.Windows.Forms.PictureBox redPotionInventory;
        private System.Windows.Forms.PictureBox bluePotionInventory;
        private System.Windows.Forms.GroupBox moveGroupBox;
        private System.Windows.Forms.GroupBox attackGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPlayerHP;
        private System.Windows.Forms.Label labelBatHP;
        private System.Windows.Forms.Label labelGhostHP;
        private System.Windows.Forms.Label labelGhoulHP;
    }
}

