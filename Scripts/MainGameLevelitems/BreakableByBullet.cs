using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableByBullet : MonoBehaviour
{
    public GameObject Glass; //the thing that is gunna get borken
    BoxCollider GlassCollider; 
    MeshRenderer GlassRenderer; 

    public ParticleSystem BreakParticles; 

    public AudioSource source; 
    public AudioClip clip; 

    
    void Start()
    {
        GlassRenderer = Glass.GetComponent<MeshRenderer>();

        GlassCollider = Glass.GetComponent<BoxCollider>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Bullet(Clone)"){
            GlassCollider.enabled = false;
            GlassRenderer.enabled = false;
            BreakParticles.Play();
            source.PlayOneShot(clip); 
 
        }
    }
    public void resetGlass(){

        GlassCollider.enabled = true;
        GlassRenderer.enabled = true;

    }
}
