using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectArnes
{
    public struct skill
    {
        string name;
        string tips;
        string school;
        string anim;
        string picChar;
        string picTarget;
        Image pic;
        int MPcost;
        int SPcost;
        int cooldown;
        int DMG;
    };
    public struct Ups
    {
        int HPUp;
        int MPUp;
        int DMG;
    }
    public struct item
    {
        string type;
        string name;
        string tip;
        string ForClass;
        Image picIcon;
        Image picVis;
        Ups Up;

    }

    public struct character
    {
        string name;
        string fraction;
        int XP;
        List<Image> picPortret;
        int HP;
        int MP;
        int CP;
        int SP;
        int DexP;
        string classPers;
        int DMG;
        int Coins;

        public character(string str)
        {
            name = "";
            fraction = "";
            XP = 0;
            picPortret = new List<Image>();
            HP = 25;
            MP = 25;
            DexP = 25;
            CP = 25;
            SP = 3;
            classPers = "";
            DMG = 5;
            Coins = 100;
        }
    };
   
    public struct user
    {
        public string name;
        public string password;
        public string promo;
        public string email;
        public int donatCoins;
        public List<character> Chars;
    }
}
