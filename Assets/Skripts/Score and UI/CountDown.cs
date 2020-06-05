using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;


public class CountDown : MonoBehaviour
{
    public int timeLeft = 30;
    public Text countDown;
    public int currentTime;
    void Start()
    {
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
