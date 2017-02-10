using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charcters
{
    class Hero
    {
        HeroInfo Info;
        public int Lv { get; private set; }
        public int MaxHP
        {
            get
            {
                return (LIFE * 2);
            }
        }
        public int MaxMP
        {
            get
            {
                return (int)(INT * 1.5);
            }
        }
        public int ATT
        {
            get
            {
                
                //return (Info.ATT * Lv + EquipmentSlot[(int)eSlot.WepSlot].Value);
                return 1;
            }
        }
        public int DEF
        {
            get
            {
                //return (Info.DEF * Lv + EquipmentSlot[(int)eSlot.AmrSlot].Value);
                return 1;
            }
        }
        public int LIFE
        {
            get
            {
                //return (Info.LIFE * Lv + EquipmentSlot[(int)eSlot.HPAccSlot].Value);
                return 1;
            }
        }
        public int INT
        {
            get
            {
                //return (Info.INT * Lv + EquipmentSlot[(int)eSlot.HPAccSlot].Value);
                return 1;
            }
        }

        public int HP { get; set; }
        public int MP { get; set; }
        public int Exp { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        Image image;

        public Hero(eHeroKey key)
        {//Info Dict 에서 빼와
            Lv = 1;
            HP = MaxHP;
            MP = MaxMP;
            Exp = 0;
            image = (Image)Properties.Resources.ResourceManager.GetObject(Info.ImageRsrcName);
        }

        public Hero(eHeroKey key, int lv)
        {//Info Dict 에서 빼와
            Lv = lv;
            HP = MaxHP;
            MP = MaxMP;
            Exp = 0;
            image = (Image)Properties.Resources.ResourceManager.GetObject(Info.ImageRsrcName);
        }
        public void LvUp(int lv)
        {
            Lv = lv;
            HP = MaxHP;
            MP = MaxMP;
            Exp = 0;
        }
        public void LvUp()
        {
            Lv++;
            HP = MaxHP;
            MP = MaxMP; 
            Exp = 0;
        }
        public void DarwMySelf(Graphics e)
        {

        }

        //메서드
        //유즈아이템 -> 이거 정해라 -> 인벤토리를 가지고 있을지 아이템매니저가 가지고 있을지
        //LV set{} 안에서 계산해서 넣어준다
        //유즈 스킬
        //자기 자신 그리기
    }
    class HeroManager : Singleton<Hero>
    {
        Hero hero;

        public void CreateHero(eHeroKey key = eHeroKey.주인공, int lv = 1)
        {
            hero = new Hero(key, lv);
        }
    }
}
