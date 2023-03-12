using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnoyingSound : MonoBehaviour
{
   public AudioSource source; 
    public AudioClip clip;
    public float SongRate = 34f;
    private float nextSongTimer = 0.0f;
    public float volumeIncreaseAmmount = 0.1f; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSongTimer){
            source.volume += volumeIncreaseAmmount; 
            nextSongTimer = Time.time + SongRate;
            source.PlayOneShot(clip);

            } 
    }
}
