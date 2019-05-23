using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //first is min size of inspector where we can write.
    //second is the amount of lines before we start to scroll.
    [TextArea(10,14)] [SerializeField] string storyText; 

    public string GetStateStory()
    {
        return storyText;
    }

}