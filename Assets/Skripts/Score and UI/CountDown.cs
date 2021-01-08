using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;


public class CountDown : MonoBehaviour
{
    private int timeLeft = 30;
    public Text countDown;
    public int currentTime;

    void Start()
    {
        if(Difficulty.diff == 0 ||Difficulty.diff == 1)
        {
            timeLeft = 30;
        }else if(Difficulty.diff == 2)
        {
            timeLeft = 25;
        }


        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        currentTime = timeLeft;
    }
    
    void Update()
    {
        countDown.text = ("" + timeLeft);
        if(timeLeft == 0){
            StopCoroutine("LoseTime");
            Destroy(gameObject);
            SceneManager.LoadScene("MiddleScene");
            TotalScoreManager.totalScore = TotalScoreManager.totalScore + ScoreManager.score;
            
        }
    }

    IEnumerator LoseTime(){
        while(true){
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
