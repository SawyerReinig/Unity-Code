using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdModuleSpawner : MonoBehaviour
{

     public GameObject Module;
     public Transform nextModPoint;
     public int modCount; 
     public Vector3 spacing; 
  

    // Start is called before the first frame update
    void Start()
    {
        for(int M = 0; M < modCount; M++){
                
                GameObject CurrentModule = Instantiate(Module, nextModPoint.localPosition, Quaternion.identity);
                nextModPoint.localPosition = nextModPoint.localPosition + spacing;
                //CurrentModule.transform.SetParent(nextModPoint);
        }
    }

  

  
}
