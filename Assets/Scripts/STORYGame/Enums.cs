using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME

{
    public class Enums
    {
        public enum StoryType
        {

            MAIN,
            SUB =100,
            SERIAL
        }
        public enum EvenType
        {
            NONE,
            GoTOBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA,
        }

        public enum ResultType
        {

            ChangeHp,
            ChangeSp,
            AddExlerience,
            GoToShop,
            GoToNextStroy,
            GoToRandomStory,
            GoToEnding
        }

    }
   

    [System.Serializable]

    public class Stats
    {
        public int hpPoint;
        public int spPoint;

        public int currentHpPoint;
        public int currentSpPoint;
        public int currentXpPoint;

        public int strenght;
        public int dexterity;
        public int consitiution;
        public int intelligence;
        public int wisdom;
        public int sharisma;
    }

}
