using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;


#if UNITY_EDITOR
public class GameSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GameSystem gameSystem = (GameSystem)target;

        if(GUILayout.Button("Result Story Models"))
        {
            gameSystem.ResetStoryModels();
        }
    }
}
#endif
public class GameSystem : MonoBehaviour
{





    public StoryModel[] storyModels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
#if UNITY_EDITOR
    [ContextMenu("Reset Story Models")]
    public void ResetStoryModels()
    {
        storyModels = Resources.LoadAll<StoryModel>("");
    }
#endif
}
