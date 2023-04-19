using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
    public Vector3 raznica;

    void Start()
    {
        raznica = transform.position - player.position;
    }

    void Update()
    {
        transform.position = player.position + raznica;
    }
}


