using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotblaster : MonoBehaviour
{
    public Quaternion rot;
   // public Transform player;
    //public Vector3 raznica;

    void Start()
    {
       // raznica = transform.position - player.position;
    }

    void Update()
    {
        //transform.position = player.position + raznica;

        this.transform.rotation = rot;

        if(Input.GetKey(KeyCode.W))
        {
            rot.y = 0f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            rot.y = 0f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            rot.y = 0f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            rot.y = 0f;
        }
    }
}
