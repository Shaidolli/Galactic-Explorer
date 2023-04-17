using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public CharacterController camera1;

    public float speed = 5;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z  = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        camera1.Move(move*speed*Time.deltaTime);
    }
}
