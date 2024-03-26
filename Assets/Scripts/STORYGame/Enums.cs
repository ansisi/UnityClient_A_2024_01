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

    }
}
