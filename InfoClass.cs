using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charcters
{
    public enum eNPCKey
    {
        촌장,
        상점주인,
        여관주인,
        과부
    }
    public enum eMonsterKey
    {
        몬스터1,
        몬스터2,
        몬스터3,
        유령,
        마왕                                                                                                
    }
    public enum eHeroKey
    {
        주인공,
    }
    //public enum eMainType
    //{

    //}

    //public enum eSubType
    //{

    //}

    class CharacterInfo
    {
        public string Name { get; protected set; }
        //public eMainType MainType { get; protected set; }     //현재 사용x
        //public int SubType { get; protected set; }            //현재 사용x
        public int ATT { get; protected set; }
        public int DEF { get; protected set; }
        public int LIFE { get; protected set; }
        public int INT { get; protected set; }
        public string ImageRsrcName { get; protected set; }
        public int ImageSize { get; protected set; }
    }

    class NPCInfo : CharacterInfo
    {
        public eNPCKey Key { get; private set; }
        public NPCInfo(eNPCKey key, string name, string imagersrcname, int imagesize)
        {
            Key = key;
            Name = name;
            ImageRsrcName = imagersrcname;
            ImageSize = imagesize;
        }
    }

    class MonsterInfo : CharacterInfo
    {
        public eMonsterKey Key { get; private set; }
        public MonsterInfo(eMonsterKey key, string name, int att, int def, int life, string imagersrcname, int imagesize)
        {
            Key = key;
            Name = name;
            ATT = att;
            DEF = def;
            LIFE = life;
            ImageRsrcName = imagersrcname;
            ImageSize = imagesize;
        }
    }

    class HeroInfo : CharacterInfo
    {
        public eHeroKey Key { get; private set; }
        public HeroInfo(eHeroKey key,string name, int att, int def, int life, int Int, string imagersrcname, int imagesize)
        {
            Key = key;
            Name = name;
            ATT = att;
            DEF = def;
            LIFE = life;
            INT = Int;
            ImageRsrcName = imagersrcname;
            ImageSize = imagesize;
        }
    }
}
