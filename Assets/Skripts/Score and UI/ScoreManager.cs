using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    public static int score;
   
    
    

    Text text;
    
    void Start()
    {
        
        text = GetComponent<Text>();
        
    }

    
    void Update()
    {
        
        text.text = "Score " + score;
        
    }


}
