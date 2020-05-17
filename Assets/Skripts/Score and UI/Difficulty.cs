using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static int diff = 0;
    

    public void OnClick(int diffi)
    {
        diff = diffi;
    }
}
