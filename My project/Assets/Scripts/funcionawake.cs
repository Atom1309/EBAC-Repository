using JetBrains.Annotations;
using UnityEngine;

public class funcionawake : MonoBehaviour
{
    void Awake()
    {
        Renderer Renderer = GetComponent<Renderer>();
        if (Renderer != null)
        {
            Renderer.material.color = Color.white;
        }
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
