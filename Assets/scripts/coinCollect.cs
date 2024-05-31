using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    public AudioSource coinFX;
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        COINMANAGE.coinCount++;
        this.gameObject.SetActive(false);
    }
}
