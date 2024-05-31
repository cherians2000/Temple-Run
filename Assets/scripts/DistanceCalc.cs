using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceCalc : MonoBehaviour
{
    public static int DisRun;
    public TextMeshProUGUI distanceDisplay;
    public TextMeshProUGUI distanceEndDisplay;
    public bool distanceCovered=false;
    void Update()
    {
        if (distanceCovered == false)
        {
            distanceCovered = true;
            StartCoroutine(DistanceCovered());
        }
        
        
    }
    IEnumerator DistanceCovered()
    {
        int DisRun = MovePlayer1.disRun+59;
        distanceDisplay.GetComponent<TextMeshProUGUI>().text=""+DisRun;
        distanceEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + DisRun;
        yield return new WaitForSeconds(0.25f) ;
        distanceCovered = false;
    }
}
