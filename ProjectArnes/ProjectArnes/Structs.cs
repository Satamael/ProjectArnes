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
       List<Image> anim;
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
        public string name;
        public string fraction;
        public bool male;
        public List<Image> pics;
        public int HP;
        public int MP;
        public int CP;
        public int SP;
        public int DexP;
        public string Talants;
        public int DMG;
        

        public character(string str)
        {
            name = "";
            male=true;
            fraction = "";
            pics = new List<Image>();
            HP = 25;
            MP = 25;
            DexP = 25;
            CP = 25;
            SP = 3;
            Talants = "";
            DMG = 5;
           
        }
    };
   
    public struct user
    {
        public string name;
        public string password;
        public string email;
        public string promo;
        public int EXP;
        public int Coins;
        public int donatCoins;
        public List<character> Chars;
        public int NChars;
    }
}
