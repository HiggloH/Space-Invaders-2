using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    private int nextSceneToLoad;

    public List<GameObject> waves;
    public List<GameObject> activeWave;


    // Start is called before the first frame update
    private void Awake()
    {

        activeWave[0] = waves[0];

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {

        activeWave[0] = waves[0];

        if (waves.Count == 0)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
        else if (waves[0] == null)
        {
            waves.RemoveAt(0);
            activeWave[0].SetActive(true);
        }

        Debug.Log(activeWave[0]);
    }
}
