﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnclick : MonoBehaviour
{
    public void LoadScene(int level){
        Application.LoadLevel(level);
        ScoreManager.score = 0;
    }


}
