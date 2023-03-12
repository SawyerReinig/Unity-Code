using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{

    public Transform PointA, PointB, MainObject; 
    public float SudoSpeed; 
    public float MoveRate = 5f;
    private float nextMoveTimer;
    Vector3 TargetPoint; 
    bool AtPointA; 
    // Start is called before the first frame update
    void Start()
    {
    TargetPoint = PointA.position;
    AtPointA = true; 
    nextMoveTimer = MoveRate; 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = MainObject.position;
        MainObject.position = Vector3.Lerp(a, TargetPoint, SudoSpeed); 

        if(Time.time > nextMoveTimer){
            nextMoveTimer = Time.time + MoveRate;
            if(AtPointA){
                TargetPoint = new Vector3(PointB.position.x, PointB.position.y, PointB.position.z);
                AtPointA = false; 
            }
            else{
                TargetPoint = new Vector3(PointA.position.x, PointA.position.y, PointA.position.z);
                AtPointA = true; 
            }
            
            
        } 
    
        
    }
}

