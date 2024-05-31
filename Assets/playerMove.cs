using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove22 : MonoBehaviour
{
    public int speed;
    private Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement= new Vector3(horizontal,0f,vertical)*speed*Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
