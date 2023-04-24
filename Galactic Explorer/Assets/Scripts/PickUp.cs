using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject blasterONplayer;
    public GameObject blasterOnGround;
    void Start()
    {
        blasterONplayer.SetActive(false);
        blasterOnGround.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            blasterONplayer.SetActive(true);
            blasterOnGround.SetActive(false);
        }
    }


}
