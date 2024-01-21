using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    public GameObject virusPrefab;
    public GameEnding gameWon;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateVirus", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameWon.isGameWon) {
            CancelInvoke();
        }
    }

    void CreateVirus()
    {
        Instantiate(virusPrefab, new Vector2(Random.Range(-12, 12), Random.Range(-6, 6)), Quaternion.identity);
    }
}
