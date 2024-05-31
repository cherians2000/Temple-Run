using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalecalc : MonoBehaviour
{
    public Vector3 Rotation;
    public Vector3 Scale;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Rotation);
        transform.localScale += Scale;
    }
}
