using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public CharacterController controller1;

    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z  = Input.GetAxis("Vertical");

        Vector3 move = transform.right * -x + transform.forward * -z;
        controller1.Move(move*speed*Time.deltaTime);
    }
}