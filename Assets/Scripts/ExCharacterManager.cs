using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharacterManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ExCharacter> charaxterList = new List<ExCharacter>();

    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i =0; i < charaxterList.Count; i++)
            {
                charaxterList[i].DestoryCharacter();
            }
        }
    }
}
