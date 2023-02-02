using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Scores = 1;

    public float SpeedBox = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(SpeedBox * Time.deltaTime, 0f, SpeedBox * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            PlayerController players = player.GetComponent<PlayerController>();

            if (players != null)
            {
                players.NumScore(Scores);
                Destroy(gameObject);
            }
        }   
    }
}
