using System;
using UnityEngine;

public class componente1 : MonoBehaviour
{
    public static GameObject miObjeto;
    private void Awake()
    {
        miObjeto = this.gameObject;
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
