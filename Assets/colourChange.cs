using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class colourChange : MonoBehaviour
{
    public Image image;
    private Color[] colour = new Color[] { Color.green, Color.red, Color.blue, Color.gray };
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ChangeColourOnClick()
    {
        Color randomColour = colour[Random.Range(0, colour.Length)];
        
    }
}
