using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroyer : MonoBehaviour
{

    //public float BulletLife = 3f;
    //private float Timer = 3.0f;
    public GameObject Bullet;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col){
            Destroy(Bullet); 
    }

}
