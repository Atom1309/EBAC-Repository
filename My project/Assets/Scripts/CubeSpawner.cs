using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public System.Collections.Generic.List<GameObject> listaDeCubos;
    public float factordeescalamiento;
    public int numCubos = 0;



    // Start is called once before the first frame update
    void Start() 
    {
        listaDeCubos = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObjet = Instantiate<GameObject>(PrefabCubo);
        tempGameObjet.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        tempGameObjet.GetComponent<MeshRenderer>().material.color = c;
        tempGameObjet.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(tempGameObjet);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.lossyScale.x;
            scale *= factordeescalamiento;
            go.transform.localScale = Vector3.one * scale;

            if(scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach(GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
