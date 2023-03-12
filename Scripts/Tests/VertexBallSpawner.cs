using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexBallSpawner : MonoBehaviour
{

    public GameObject Hollogramize; 
    public GameObject tinyball; 

    //public Mesh mesh;
    // Start is called before the first frame update
    void Start (){
        Mesh mesh = Hollogramize.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        for (int i = 0; i < vertices.Length; i++){
            //direction = transform.TransformPoint(vertices[i]);
            //transform.TransformPoint(vertices[i]
            GameObject CurrentModule = Instantiate(tinyball, transform.TransformPoint(vertices[i]), Quaternion.identity);
        }
}


    // Update is called once per frame
    void Update()
    {
        
    }
}
