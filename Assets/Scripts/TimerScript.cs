using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float totalTimeLeft = 10;
    public bool timeRanOut = false;
    [SerializeField] public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(totalTimeLeft > 0) {
            totalTimeLeft -= Time.deltaTime;
        } else {
            timeRanOut = true;
            // Debug.Log("Time Ran Out!");
        }
        
        timerText.text = "Time Left: " + Mathf.RoundToInt(totalTimeLeft);
    }
}
