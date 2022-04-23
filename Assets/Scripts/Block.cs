using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public int Hits = 1;
    public int ScoreValue = 100;
    GameController gameController;
    public AudioClip OnBreakAudio;
    //float startTime = 0;
    //float waitFor = 4;
    //bool timerStart = false;
    //private float BlockPosition;



    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
        //BlockPosition = transform.position;
    }

    public void OnHit()
    {
        Hits--;

        if (Hits <= 0)
        {
            gameController.AdScore(ScoreValue);
            gameController.AudioController.PlayClip(OnBreakAudio);
            Instantiate(gameController.ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //timerStart = true;
            Debug.Log("cn");
        }
    }

    //void Update()
    //{
    //    if (timerStart && Time.time - startTime > waitFor)
    //    {
    //        Debug.Log("respawn");
    //        timerStart = false;
    //    }
    //}

}
