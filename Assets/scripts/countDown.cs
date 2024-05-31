using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDown : MonoBehaviour
{

    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject coutDownGo;
    public GameObject fadeIn;
    

    void Start()
    {
        StartCoroutine(CountSeq());
    }

   IEnumerator CountSeq() 
    {
        yield return new WaitForSeconds(0.5f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        coutDownGo.SetActive(true);
        yield return new WaitForSeconds(1f);
        fadeIn.SetActive(true);
       MovePlayer1.canMove = true;
    }
}
