using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_test
{
    public partial class Form1 : Form
    {
        int HP;
        int MP;
        int ATK=8;
        int SPD;
        int DEF;
        int HP1= 100;
        int MP1;
        int ATK1;
        int SPD1;
        int DEF1=4;
        int HP2 =100;
        int MP2;
        int ATK2;
        int SPD2;
        int DEF2 = 4;
        int HP3= 100;
        int MP3;
        int ATK3;
        int SPD3;
        int DEF3= 4;
        bool Target1;
        bool Target2;
        bool Target3;
        int Target;
        bool Targeting;
        bool Damage;
        int DMG;
        int x;
        public Form1()
        {
            InitializeComponent();
            Target = 1;
            Targeting = true;
            label1.Text = "HP:" + HP1;
            lblEnemy2.Text = "HP" + HP2;
            lblEnemy3.Text = "HP:" + HP3;
        }
        //Methods start here
        public void Attack()
        {
            if (Damage == true); 
            {
                if (Target == 1)
                {
                    if (HP1 > 0)
                    {
                        DMG = ATK - DEF1;
                        HP1 -= DMG;
                        label1.Text = "HP:" + HP1;
                    }
                }
            }
            if (Damage == true)
            {
                if (Target == 2)
                {
                    if (HP2 > 0)
                    {
                        DMG = ATK - DEF2;
                        HP2 -= DMG;
                        lblEnemy2.Text = "HP:" + HP2;
                    }
                }
            }
            if (Damage == true) 
            {
                if (Target == 3)
                {
                    if (HP3 > 0)
                    {
                        DMG = ATK - DEF3;
                        HP3 -= DMG;
                        lblEnemy3.Text = "HP:" + HP3;
                    }
                }
            }
        }
        
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Targeting debug
            if (e.KeyData == Keys.W)
            {
                Console.WriteLine(Target);
            }
            //Targeting system
            if (e.KeyData == Keys.Left)
            {
                if (Targeting == true & Target >= 2)
                {
                    Target = Target - 1;
                }
                else
                {
                    if (Targeting == true & Target == 1)
                    {
                        Target = 3;
                    }
                }
            }
            if (e.KeyData == Keys.Right)
            {
                if (Targeting == true & Target <= 2)
                {
                    Target = Target + 1;
                }
                else
                {
                    if (Targeting == true & Target == 3)
                    {
                        Target = 1;
                    }
                }
            }
            if (e.KeyData == Keys.Space)
            {
                Damage = false;
             
            }
        }

        private void tmrTarget_Tick(object sender, EventArgs e)
        {
            lblTarget.Text = "" + Target;
            if (HP1 <= 0)
            {
                HP1 = 0; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                Damage = true;
                Attack();
            }
        }
    }
}
