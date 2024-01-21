using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public ScoreScript score;
    public Transform player;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.transform == player) 
        {
            score.score++;
            Destroy(this.gameObject);
        }
    }
}
