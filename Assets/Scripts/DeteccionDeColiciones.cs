using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto" + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}

