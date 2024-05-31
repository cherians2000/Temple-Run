using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource HitPillar;
    public GameObject cam;
    public GameObject GameOverP;
    public GameObject Scorepanel;


    void OnTriggerEnter(Collider other)
    {
       this.gameObject.GetComponent<BoxCollider>().enabled = false;
       thePlayer.GetComponent<MovePlayer1>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        HitPillar.Play();
       cam.GetComponent<Animator>().Play("falldown animation");

        Scorepanel.SetActive(false);

        StartCoroutine(Overpanel());
    }
    public IEnumerator  Overpanel()
    {
        yield return new WaitForSeconds(2f);
        GameOverP.SetActive(true);
    }
}
