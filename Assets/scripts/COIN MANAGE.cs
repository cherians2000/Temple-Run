using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class COINMANAGE : MonoBehaviour
{
    public static int coinCount;
    public TextMeshProUGUI coinDisplay;
    public TextMeshProUGUI coinEndDisplay;
    void Update()
    {
        coinDisplay.GetComponent<TextMeshProUGUI>().text=""+coinCount;
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
    }
}
