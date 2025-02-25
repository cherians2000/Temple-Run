using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVELGENERATE : MonoBehaviour
{
    public GameObject[] section;
    public static int zPos = 100;
    public bool creatingSection = false;
    public static int secNum;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }

    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSection = false;
    }
}