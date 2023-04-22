using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject blasterONplayer;
    void Start()
    {
        blasterONplayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            blasterONplayer.SetActive(true);
        }
    }


}
