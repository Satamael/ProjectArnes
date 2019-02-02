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
        int SP;
        string classPers;
        int DMG;

        public character(string str)
        {
            name = "";
            fraction = "";
            XP = 0;
            picPortret = new List<Image>();
            HP = 50;
            MP = 50;
            SP = 3;
            classPers = "";
            DMG = 0;
        }
    };
}
