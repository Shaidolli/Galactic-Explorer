using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rottsc : MonoBehaviour
{
    public Quaternion rot;
    

    void Update()
    {

        this.transform.rotation = rot;

        if(Input.GetKey(KeyCode.W))
        {
            rot.y = 0f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            rot.y = 1f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            rot.y = -1f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            rot.y = 180f;
        }
    }
}
