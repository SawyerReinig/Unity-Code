using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyBird : MonoBehaviour
{

    public Transform spawnpoint, player, lefthand, righthand;
    public GrapplingGun grappleRight, grappleLeft; 

    public List<BreakableByBullet> Glasses; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "XR Origin"){
            
            grappleRight.StopGrappleNoButton();
            if(grappleLeft != null){
                 grappleLeft.StopGrappleNoButton();
            }
            player.position = spawnpoint.position;     
            righthand.position = spawnpoint.position;
            lefthand.position = spawnpoint.position;    
            player.GetComponent<Rigidbody>().velocity = Vector3.zero; 
            player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            foreach(BreakableByBullet glass in Glasses ){
                glass.resetGlass(); 
            }
            
            
        }
    }
}
