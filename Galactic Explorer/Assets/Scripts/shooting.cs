using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject laser;
    public Camera shootingcamera;
    public Transform spawnLaser;
    public float shootForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Ray ray = shootingcamera.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if(Physics.Raycast(ray, out hit))
        targetPoint = hit.point;
        else
        targetPoint = ray.GetPoint(40);
        Vector3 withoutSpead = targetPoint - spawnLaser.position;

        GameObject currectLaser = Instantiate(laser, spawnLaser.position, Quaternion.identity);

        currectLaser.transform.forward = withoutSpead.normalized;
        currectLaser.GetComponent<Rigidbody>().AddForce(withoutSpead.normalized * shootForce, ForceMode.Impulse);
        

    }
    
}
