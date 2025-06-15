using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int damagePoints;
    public HealthManager healthManager;

    void Start()
    {
        healthManager = FindFirstObjectByType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //restart damagePoints a la salud del player
            healthManager.UpdateHealth(-damagePoints);
        }
    }
}
