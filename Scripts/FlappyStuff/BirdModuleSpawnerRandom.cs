using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdModuleSpawnerRandom : MonoBehaviour
{

     public GameObject Module;
     public Transform nextModPoint;
     public int modCount; 
     public Vector3 Minspacing; 
     public Vector3 Maxspacing; 
     float randSpacingX; 


    // Start is called before the first frame update
    void Start()
    {

        for(int M = 0; M < modCount; M++){

                Vector3 randSpacing3 = new Vector3(Random.Range(Maxspacing.x, Minspacing.x), 0f, 0f); 
                GameObject CurrentModule = Instantiate(Module, nextModPoint.localPosition, Quaternion.identity);
                nextModPoint.localPosition = nextModPoint.localPosition + randSpacing3;
                //CurrentModule.transform.SetParent(nextModPoint);
        }
    }

  
  
}

