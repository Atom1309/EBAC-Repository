using System.Runtime.CompilerServices;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.LogWarning("algo va a pasar");
        Debug.LogError("algo esta muy muy mal");
       
    }


    // Update is called once per frame
    void Update()
    {
        // = x + 1;
        //ebug.Log(x);

        Debug.Log("hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde fixed update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde late update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto a sido inhabilitado");
    }
}
