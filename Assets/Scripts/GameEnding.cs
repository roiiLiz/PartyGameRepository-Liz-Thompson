using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public CanvasGroup winScreenCanvasGroup;
    public CanvasGroup lossScreenCanvasGroup;
    public ScoreScript score;
    public TimerScript timer;
    public float fadeDuration = 0.5f;
    public float imageDuration = 2f;
    public bool isGameWon = false;

    float screen_Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timeRanOut && isGameWon == false) {
            // Debug.Log("Game Over: Loss");
            EndGame(lossScreenCanvasGroup);
        } else if (score.score == 5) {
            EndGame(winScreenCanvasGroup);
            isGameWon = true;
        }
    }

    void EndGame(CanvasGroup imageCanvasGroup) 
    {
        screen_Timer += Time.deltaTime;

        imageCanvasGroup.alpha = screen_Timer / fadeDuration;

        if (screen_Timer > fadeDuration + imageDuration) {
            Application.Quit();
            Debug.Log("Game has closed.");
        }
    }
}
