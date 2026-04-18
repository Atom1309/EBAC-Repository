using UnityEngine;

public class onenableondesable : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("objeto activado:" + gameObject.name);
    }
    private void OnDisable()
    {
        Debug.Log("objeto desactivado:" + gameObject.name);       
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
