using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreManager : MonoBehaviour
{
    
    public static int totalScore = 0;

    

    Text text;
    
    void Start()
    {
        
        text = GetComponent<Text>();
        
    }

    
    void Update()
    {
        
        text.text = "Score " + totalScore;
        
    }

}
