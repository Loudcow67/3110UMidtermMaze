using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceTrap : MonoBehaviour
{
    public static string correctSequence = "213";

    public static string playerCode = "";

    public static int totalCode = 0;

    private void Update()
    {
        if (totalCode == 3)
        {
            if (playerCode == correctSequence)
            {
                Destroy(gameObject);
            }
            else
            {
                playerCode = "";
                totalCode = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCode += gameObject.name;
            totalCode += 1;
        }
    }
}
