using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float damageAmount = 1f;

    public float range = 150;

    public Camera playerCam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {


            shoot();
        }
    }
    void shoot() {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
             target target = hit.transform.GetComponent<target>();
        if (target != null)
        {
            target.damageReceived(damageAmount);
        }
           
        }
       
}
}
