using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource source; 
    public AudioClip clip;
    public float SongRate = 34f;
    private float nextSongTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSongTimer){
            nextSongTimer = Time.time + SongRate;
            source.PlayOneShot(clip);

            } 
    }

    IEnumerator replaySong(){

        yield return new WaitForSeconds(10f); 
        source.PlayOneShot(clip);
        
    }
}
