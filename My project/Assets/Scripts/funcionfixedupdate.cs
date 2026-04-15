using UnityEngine;

public class funcionfixedupdate : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad = 10f;

    void Start()
        { 
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
    Vector3 movimiento = new Vector3(0, 0, 1) * velocidad;
        rb.linearVelocity = movimiento;

    }


    
}
