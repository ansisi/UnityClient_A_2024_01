using STORYGAME;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewSory", menuName = "ScriptableObjects/StoryModel")]
public class StoryModel : ScriptableObject
{

    public int storyNumber;
    public Texture2D MainImage;

    public enum STORYTYPE
    {
        MAIN,
        SUB,
        SERIAL
    }
    public STORYTYPE storytype;
    public bool storyDone;

    [TextArea(10, 10)]
    public string storyText;

    public Option[] options;

    [System.Serializable]

    public class Option
    {
        public string optionText;
        public string buttonText;
        public EventCheck enventCheck;
    }

    [System.Serializable]
    public class EventCheck
    {
        public int checkValue;

        public enum EventType : int
        {
            NONE,
            GoToBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA,

        }
        public EventType eventType;
        public Result[] suceessReult;
        public Result[] failResult;

    }
    [System.Serializable]
    public class Result
    {
        public enum ResultType : int
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory,
            GOToEnding
        }
    

    public ResultType resultType;
    public int value;  
    public Stats stats;
 
 }

}
