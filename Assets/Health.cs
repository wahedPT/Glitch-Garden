using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currenthealth=100f;
    
    public void Healthdamage(float damage)
    {
        currenthealth -= damage;
        if(currenthealth < 0)
        {
            //death animation
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
