using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointMaster : MonoBehaviour
{
    public GameObject[] checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = checkpoint.Length-1; i >= 0; i--)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(checkpoint[i]);
                Destroy(gameObject);
            }
        }
    }
}
