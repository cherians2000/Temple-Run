using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySession : MonoBehaviour
{
    public string parentName = "section";
    public GameObject PausePanel;
    public GameObject GameOverPanel;

    private void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(250);

        // Check if PausePanel and GameOverPanel are not active
        if (!PausePanel.active && !GameOverPanel.activeSelf)
        {
            // Check if the game object's name is "section(Clone)"
            if (parentName == "section(Clone)")
            {
                Destroy(gameObject);
            }
        }
    }
}
