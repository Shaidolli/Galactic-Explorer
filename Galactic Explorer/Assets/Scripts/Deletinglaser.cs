using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletinglaser : MonoBehaviour
{
    public float deletelaser = 3;
    public float damage = 40;

    private void Awake()
    {
        Destroy(gameObject, deletelaser);
    }

    void OnCollisionEnter(Collision other)
    {
        healthrobot.health -= damage;
    }
}
