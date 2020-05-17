using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DifficultyTextManager : MonoBehaviour
{
    
    

    public Text difficulty;
    

    public void Update()
    {
        if(Difficulty.diff == 0)
        {
            difficulty.text = "Difficulty = Easy";
        }
        if(Difficulty.diff == 1)
        {
            difficulty.text = "Difficulty = Normal";
        }
        if(Difficulty.diff == 2)
        {
            difficulty.text = "Difficulty = Hard";
        }
    }
}
