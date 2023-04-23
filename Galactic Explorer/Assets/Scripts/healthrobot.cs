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
/*
        void detectedCOl(Collider other)
        {
            if(other.gameObject.tag == "laser")
            {
                health -= Deletinglaser.damage;
                if(health <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
*/
    }
    
}
