using UnityEngine;
using UnityEngine.InputSystem;

public class cubo1 : MonoBehaviour
{
          
        GameObject objtospanw;
        Vector3[] vertices = {
        new Vector3(0, 0, 0),  //vertice0
        new Vector3(1, 0, 0),  //vertice1
        new Vector3(1, 1, 0),  //vertice2
        new Vector3(0, 1, 0),  //vertice3
        new Vector3(0, 1, 1),  //vertice4
        new Vector3(1, 1, 1),  //vertice5
        new Vector3(1, 0, 1),  //vertice6
        new Vector3(0, 0, 1),  //vertice7
        };
                               
        int[] Triangles = {
        0,2,1,  //cara 1
        0,3,2,
        2,3,4,  //cara 2
        2,4,5,
        1,2,5,  //cara 3
        1,5,6,
        0,7,4,  //cara 4
        0,4,3,
        5,4,7,  //cara 5
        5,7,6,
        0,6,7,  //cara 6
        0,1,6,
        };
    // Start is called once before the first frame update
    void Start()
    {
        objtospanw = new GameObject("cubo1");
        objtospanw.AddComponent<MeshFilter>();
        var meshfilter = objtospanw.GetComponent<MeshFilter>().mesh;
        meshfilter.Clear();
        meshfilter.vertices = vertices;
        meshfilter.triangles = Triangles;
        meshfilter.Optimize();
        meshfilter.RecalculateNormals();
        objtospanw.AddComponent<BoxCollider>();
        var boxcollider = objtospanw.GetComponent<BoxCollider>();
        objtospanw.AddComponent<MeshRenderer>();
        var meshrenderermaterial = objtospanw.GetComponent<MeshRenderer>().material;
        objtospanw.transform.position = Vector3.one;
       


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
