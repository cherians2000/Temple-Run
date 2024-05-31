using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fall : MonoBehaviour
{
    public Animator anim;
  

    private void Start()
    {
        Debug.Log("started");
        anim = GetComponent<Animator>();
       
    }
    void Awake()
    {
        anim.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
       
            if (collision.gameObject.CompareTag("collider"))
            {
                anim.SetBool("fall", true);

            }
            else
            {
                anim.SetBool("fall", false);
            }
        
        
    }


}
