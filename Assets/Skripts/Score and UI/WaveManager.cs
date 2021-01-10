using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public List<GameObject> waves;

    public List<GameObject> activeWave;


    // Start is called before the first frame update
    void Start()
    {
        activeWave[0] = waves[0];

        waves[1].SetActive(false);
        waves[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(waves[0] == null)
        {
            waves.RemoveAt(0);
            waves[0].SetActive(true);
        }


        activeWave[0] = waves[0];

        Debug.Log(activeWave[0]);
    }
}
