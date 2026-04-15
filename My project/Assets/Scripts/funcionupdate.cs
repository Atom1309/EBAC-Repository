using UnityEngine;

public class funcionupdate : MonoBehaviour
{

    public float velocidad = 5.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        { Debug.Log("salto detectado");
        }

    }


          
    
}
