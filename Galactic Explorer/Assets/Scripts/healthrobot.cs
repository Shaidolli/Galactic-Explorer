using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthrobot : MonoBehaviour
{

    public static float health;
    void Start()
    {
        health = 100f;
    }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }

    }
    
}
