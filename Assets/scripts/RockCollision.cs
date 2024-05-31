using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource FellDown;
    public GameObject GameOverP;
    public GameObject Scorepanel;

    void OnTriggerEnter(Collider other)
    {
       this.gameObject.GetComponent<BoxCollider>().enabled = false;
       thePlayer.GetComponent<MovePlayer1>().enabled = false;
        charModel.GetComponent<Animator>().Play("Hit To Head");
        FellDown.Play();
        Scorepanel.SetActive(false);

        StartCoroutine(Overpanel());
    }
    public IEnumerator Overpanel()
    {
        yield return new WaitForSeconds(2f);
        GameOverP.SetActive(true);
    }

}
