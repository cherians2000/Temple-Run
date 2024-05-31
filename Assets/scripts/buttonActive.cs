using UnityEngine;

using System.Collections;


public class buttonActive : MonoBehaviour
{
    public GameObject canvasToActivate;
    public float activationDelay = 5f; // Time in seconds before activating the canvas.

    void Start()
    {
        // Start the Coroutine to activate the canvas after the delay.
        StartCoroutine(ActivateCanvasAfterDelay());
    }

    IEnumerator ActivateCanvasAfterDelay()
    {
        // Wait for the specified delay duration.
        yield return new WaitForSeconds(activationDelay);

        // Activate the canvas.
        if (canvasToActivate != null)
        {
            canvasToActivate.SetActive(true);
            // You can also perform any other desired actions here.
        }
    }
}
