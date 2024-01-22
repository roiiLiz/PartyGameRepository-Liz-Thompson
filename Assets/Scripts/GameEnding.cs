using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public CanvasGroup winScreenCanvasGroup;
    public CanvasGroup lossScreenCanvasGroup;
    public ScoreScript score;
    public TimerScript timer;
    public AudioSource winSound;
    public AudioSource loseSound;
    public AudioSource bgMusic;
    public float fadeDuration = 0.5f;
    public float imageDuration = 2f;
    public bool isGameWon = false;

    float screen_Timer;
    bool m_HasAudioPlayed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timeRanOut && isGameWon == false) {
            // Debug.Log("Game Over: Loss");
            EndGame(lossScreenCanvasGroup, loseSound);
        } else if (score.score == 5) {
            isGameWon = true;
            EndGame(winScreenCanvasGroup, winSound);
        }
    }

    void EndGame(CanvasGroup imageCanvasGroup, AudioSource audio) 
    {
        if (!m_HasAudioPlayed) {
            audio.Play();
            m_HasAudioPlayed = true;
        }

        screen_Timer += Time.deltaTime;

        imageCanvasGroup.alpha = screen_Timer / fadeDuration;

        bgMusic.volume = 0;

        if (screen_Timer > fadeDuration + imageDuration) {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
