using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveControl : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 20f;
    public float jump = 10f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = 10f;
     
        
        

        if(Input.GetKeyDown("space"))
        {
            Vector3 pos;
            pos = transform.position;
           // pos = pos + new Vector3(0, 1 * jump * Time.deltaTime, 0);
            pos = pos  + transform.up * y  * Time.deltaTime;

            transform.position = pos;
        }
        

        Vector3 movement = transform.right * x + Physics.gravity + transform.forward * z;
        controller.Move(movement * speed * Time.deltaTime);
    }
}
