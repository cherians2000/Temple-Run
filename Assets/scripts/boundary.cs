using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour
{
    public static float leftside=-4.8f;
    public static float rightside=4.8f;
    public static float upside = 3f;
    public static float BottomSide = 1.67f;
    public float internalLeft;
    public float internalRight;
  
    void Update()
    {
        internalLeft = leftside;
        internalRight = rightside;
    }
}
